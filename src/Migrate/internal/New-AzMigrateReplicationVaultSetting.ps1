
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
The operation to configure vault setting.
.Description
The operation to configure vault setting.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInput
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSetting
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUT <IVaultSettingCreationInput>: Input to create vault setting.
  MigrationSolutionId <String>: The migration solution Id.

INPUTOBJECT <IMigrateIdentity>: Identity Parameter
  [AccountName <String>]: Run as account ARM name.
  [AlertSettingName <String>]: The name of the email notification configuration.
  [ClusterName <String>]: Cluster ARM name.
  [DatabaseInstanceName <String>]: Unique name of a database instance in Azure migration hub.
  [DatabaseName <String>]: Unique name of a database in Azure migration hub.
  [EventName <String>]: Unique name of an event within a migrate project.
  [FabricName <String>]: Fabric name.
  [HostName <String>]: Host ARM name.
  [Id <String>]: Resource identity path
  [IntentObjectName <String>]: Replication protection intent name.
  [JobName <String>]: Job ARM name.
  [LogicalNetworkName <String>]: Logical network name.
  [MachineName <String>]: Machine ARM name.
  [MappingName <String>]: Protection Container mapping name.
  [MigrateProjectName <String>]: Name of the Azure Migrate project.
  [MigrationItemName <String>]: Migration item name.
  [MigrationRecoveryPointName <String>]: The migration recovery point name.
  [NetworkMappingName <String>]: Network mapping name.
  [NetworkName <String>]: Primary network name.
  [OperationStatusName <String>]: Operation status ARM name.
  [PolicyName <String>]: Replication policy name.
  [ProtectableItemName <String>]: Protectable item name.
  [ProtectionContainerName <String>]: Protection container name.
  [ProviderName <String>]: Recovery services provider name.
  [RecoveryPlanName <String>]: Name of the recovery plan.
  [RecoveryPointName <String>]: The recovery point name.
  [ReplicatedProtectedItemName <String>]: Replication protected item name.
  [ReplicationProtectedItemName <String>]: The name of the protected item on which the agent is to be updated.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ResourceName <String>]: The name of the recovery services vault.
  [SiteName <String>]: Site name.
  [SolutionName <String>]: Unique name of a migration solution within a migrate project.
  [StorageClassificationMappingName <String>]: Storage classification mapping name.
  [StorageClassificationName <String>]: Storage classification name.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VaultSettingName <String>]: Vault setting name.
  [VcenterName <String>]: VCenter ARM name.
  [VirtualMachineName <String>]: Virtual Machine name.
.Link
https://docs.microsoft.com/powershell/module/az.migrate/new-azmigratereplicationvaultsetting
#>
function New-AzMigrateReplicationVaultSetting {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSetting])]
[CmdletBinding(DefaultParameterSetName='CreateViaIdentity', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Path')]
    [System.String]
    # The name of the resource group where the recovery services vault is present.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Create', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Path')]
    [System.String]
    # The name of the recovery services vault.
    ${ResourceName},

    [Parameter(ParameterSetName='Create')]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Azure Subscription Id in which migrate project was created.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Create', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Path')]
    [System.String]
    # Vault setting name.
    ${VaultSettingName},

    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultSettingCreationInput]
    # Input to create vault setting.
    # To construct, see NOTES section for INPUT properties and create a hash table.
    ${Input},

    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Body')]
    [System.String]
    # The migration solution Id.
    ${MigrationSolutionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Create = 'Az.Migrate.private\New-AzMigrateReplicationVaultSetting_Create';
            CreateViaIdentity = 'Az.Migrate.private\New-AzMigrateReplicationVaultSetting_CreateViaIdentity';
            CreateViaIdentityExpanded = 'Az.Migrate.private\New-AzMigrateReplicationVaultSetting_CreateViaIdentityExpanded';
        }
        if (('Create') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
