#  
# Module manifest for module 'AzureRM'  
#  
# Generated by: Microsoft Corporation  
#  
# Generated on: 12/04/2017 14:48:40
#  

$PSDefaultParameterValues.Clear()
Set-StrictMode -Version Latest

Import-Module AzureRM.Profile -RequiredVersion 4.0.0
Import-Module Azure.Storage -RequiredVersion 1.0.5.4
Import-Module AzureRM.Compute -RequiredVersion 1.2.3.4
Import-Module AzureRM.Dns -RequiredVersion 4.0.0
Import-Module AzureRM.KeyVault -RequiredVersion 4.0.0
Import-Module AzureRM.Network -RequiredVersion 1.0.5.4
Import-Module AzureRM.Resources -RequiredVersion 5.0.0
Import-Module AzureRM.Storage -RequiredVersion 1.0.5.4
Import-Module AzureRM.Tags -RequiredVersion 4.0.0
Import-Module AzureRM.UsageAggregates -RequiredVersion 4.0.0


if ($PSVersionTable.PSVersion.Major -ge 5)
{
    $completerCommands = @()
    
    $completerCommands | ForEach-Object {
        $type = $_.AttributeType
        $args = "@()"
        if ($_.ArgumentList.Count -ne 0) {
		    $temp = $_.ArgumentList -join "`", `"" 
            $args = "@(`"" + $temp + "`")" 
        }
        $sb = [scriptblock]::Create("param(`$commandName, `$parameterName, `$wordToComplete, `$commandAst, `$fakeBoundParameter) `
        `$completerObject = New-Object $type -ArgumentList $args `
        `$arguments = `$completerObject.GetCompleterValues() `
        `$arguments | Where-Object { `$_ -Like `"`$wordToComplete*`" } | ForEach-Object { [System.Management.Automation.CompletionResult]::new(`$_, `$_, 'ParameterValue', `$_) }")
        Register-ArgumentCompleter -CommandName $_.Command -ParameterName $_.Parameter -ScriptBlock $sb
    }
}

$FilteredCommands = @()

$FilteredCommands | ForEach-Object {
	$global:PSDefaultParameterValues.Add($_,
		{
			$context = Get-AzureRmContext
			if (($context -ne $null) -and $context.ExtendedProperties.ContainsKey("Default Resource Group")) {
				$context.ExtendedProperties["Default Resource Group"]
			} 
		})
}
