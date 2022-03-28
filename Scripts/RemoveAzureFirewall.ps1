[CmdletBinding(DefaultParameterSetName = 'None')]
param
(
  [String] [Parameter(Mandatory = $true)] $ServerName,
  [String] [Parameter(Mandatory = $true)] $ResourceGroupName,
  [String] $AzureFirewallName = "AzureWebAppFirewall"
)

$ErrorActionPreference = 'Stop'

If ((Get-AzureSqlDatabaseServerFirewallRule -ServerName $ServerName -FirewallRuleName $AzureFirewallName -ErrorAction SilentlyContinue))
{
  Remove-AzureSqlDatabaseServerFirewallRule -FirewallRuleName $AzureFirewallName -ServerName $ServerName 
}