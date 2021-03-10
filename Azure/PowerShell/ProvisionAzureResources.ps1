Write-Host "Provision ShoeStore resources on Azure"

Write-Host "Import Az module"
#Install-Module -Name Az -AllowClobber -Scope CurrentUser -Force

Write-Host "Connect to Azure using Service Principal"
#[string] $tenant = $env:AzureTenant
#[string] $clientId = $env:ShoeStoreId
#[string] $clientPassword = 'it is $(one)'
[securestring] $clientPasswordSecure = ConvertTo-SecureString -String $(variables.one) -AsPlainText -Force
write-host $clientPasswordSecure
#$pscredential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $clientId, $clientPasswordSecure
#Connect-AzAccount -ServicePrincipal -Credential $pscredential -Tenant $tenant | Out-Null