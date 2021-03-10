Write-Host "Provision ShoeStore resources on Azure"

Write-Host "Import Az module"
Install-Module -Name Az -AllowClobber -Scope CurrentUser -Force

Write-Host "Connect to Azure using Service Principal"
Write-Host $env:TEST
Write-Host $env:AZURETENANT
Write-Host $env:SHOESTOREID
Write-Host $env:SHOESTORESECRET

[securestring] $clientPasswordSecure = ConvertTo-SecureString -String $env:SHOESTORESECRET -AsPlainText -Force
$pscredential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $env:SHOESTOREID, $clientPasswordSecure
Connect-AzAccount -ServicePrincipal -Credential $pscredential -Tenant $env:AZURETENANT | Out-Null