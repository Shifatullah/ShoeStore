Write-Host "Provision ShoeStore resources on Azure"

#Connect to Azure using Service Principal
[string] $tenant = $env:AZURETENANT
[string] $clientId = $env:SHOESTOREID
[string] $clientPassword = $env:SHOESTORESECRET
[securestring] $clientPasswordSecure = ConvertTo-SecureString -String $clientPassword -AsPlainText -Force
$pscredential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $clientId, $clientPasswordSecure
Connect-AzAccount -ServicePrincipal -Credential $pscredential -Tenant $tenant | Out-Null

#Display Tenant Id to verify it has successfully connected using Azure Service Principal
(Get-AzContext).Tenant.Id