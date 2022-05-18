
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ScaleRule.
.Description
Create an in-memory object for ScaleRule.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ScaleRule
.Link
https://docs.microsoft.com/powershell/module/az./new-AzScaleRule
#>
function New-AzScaleRule {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ScaleRule')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Authentication secrets for the queue scale rule.")]
        [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth[]]
        $AzureQueueAuth,
        [Parameter(HelpMessage="Queue length.")]
        [int]
        $AzureQueueLength,
        [Parameter(HelpMessage="Queue name.")]
        [string]
        $AzureQueueName,
        [Parameter(HelpMessage="Authentication secrets for the custom scale rule.")]
        [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth[]]
        $CustomAuth,
        [Parameter(HelpMessage="Metadata properties to describe custom scale rule.")]
        [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRuleMetadata]
        $CustomMetadata,
        [Parameter(HelpMessage="Type of the custom scale rule
        eg: azure-servicebus, redis etc.")]
        [string]
        $CustomType,
        [Parameter(HelpMessage="Authentication secrets for the custom scale rule.")]
        [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth[]]
        $HttpAuth,
        [Parameter(HelpMessage="Metadata properties to describe http scale rule.")]
        [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpScaleRuleMetadata]
        $HttpMetadata,
        [Parameter(HelpMessage="Scale Rule Name.")]
        [string]
        $Name
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ScaleRule]::New()

        if ($PSBoundParameters.ContainsKey('AzureQueueAuth')) {
            $Object.AzureQueueAuth = $AzureQueueAuth
        }
        if ($PSBoundParameters.ContainsKey('AzureQueueLength')) {
            $Object.AzureQueueLength = $AzureQueueLength
        }
        if ($PSBoundParameters.ContainsKey('AzureQueueName')) {
            $Object.AzureQueueName = $AzureQueueName
        }
        if ($PSBoundParameters.ContainsKey('CustomAuth')) {
            $Object.CustomAuth = $CustomAuth
        }
        if ($PSBoundParameters.ContainsKey('CustomMetadata')) {
            $Object.CustomMetadata = $CustomMetadata
        }
        if ($PSBoundParameters.ContainsKey('CustomType')) {
            $Object.CustomType = $CustomType
        }
        if ($PSBoundParameters.ContainsKey('HttpAuth')) {
            $Object.HttpAuth = $HttpAuth
        }
        if ($PSBoundParameters.ContainsKey('HttpMetadata')) {
            $Object.HttpMetadata = $HttpMetadata
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        return $Object
    }
}

