Write-Host "Provision ShoeStore resources on Azure"

Write-Host "Import Az module"
#Install-Module -Name Az -AllowClobber -Scope CurrentUser -Force

Write-Host "Connect to Azure using Service Principal"
#[string] $tenant = $env:AzureTenant
#[string] $clientId = $env:ShoeStoreId
#[string] $clientPassword = 'it is $(one)'

Write-Host '$(variables.test)' 
Write-Host '$(test)'
Write-Host '${{ variables.test }}'
Write-Host '${{ test }}'
Write-Host $env:TEST 
Write-Host '$env:test'
Write-Host '$(env:test)'
Write-Host '${{ env:test }}'

[securestring] $clientPasswordSecure1 = ConvertTo-SecureString -String '$(variables.one)' -AsPlainText -Force
write-host $clientPasswordSecure1

[securestring] $clientPasswordSecure2 = ConvertTo-SecureString -String '$(one)' -AsPlainText -Force
write-host $clientPasswordSecure2

[securestring] $clientPasswordSecure3 = ConvertTo-SecureString -String '${{ variables.one }}' -AsPlainText -Force
write-host $clientPasswordSecure3

[securestring] $clientPasswordSecure4 = ConvertTo-SecureString -String '${{ one }}' -AsPlainText -Force
write-host $clientPasswordSecure4

[securestring] $clientPasswordSecure5 = ConvertTo-SecureString -String $env:ONE -AsPlainText -Force
write-host $clientPasswordSecure5

[securestring] $clientPasswordSecure6 = ConvertTo-SecureString -String '$env:ONE' -AsPlainText -Force
write-host $clientPasswordSecure6

[securestring] $clientPasswordSecure7 = ConvertTo-SecureString -String '$(env:ONE)' -AsPlainText -Force
write-host $clientPasswordSecure7

[securestring] $clientPasswordSecure8 = ConvertTo-SecureString -String '${{ env:ONE }}' -AsPlainText -Force
write-host $clientPasswordSecure8

#$pscredential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $clientId, $clientPasswordSecure
#Connect-AzAccount -ServicePrincipal -Credential $pscredential -Tenant $tenant | Out-Null