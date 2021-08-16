// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(MigrateIdentityTypeConverter))]
    public partial class MigrateIdentity
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.MigrateIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MigrateIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.MigrateIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MigrateIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MigrateIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.MigrateIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MigrateIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SiteName = (string) content.GetValueForProperty("SiteName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SiteName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ClusterName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).HostName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).JobName = (string) content.GetValueForProperty("JobName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).JobName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MachineName = (string) content.GetValueForProperty("MachineName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MachineName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).OperationStatusName = (string) content.GetValueForProperty("OperationStatusName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).OperationStatusName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AccountName = (string) content.GetValueForProperty("AccountName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrateProjectName = (string) content.GetValueForProperty("MigrateProjectName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrateProjectName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VcenterName = (string) content.GetValueForProperty("VcenterName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VcenterName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseInstanceName = (string) content.GetValueForProperty("DatabaseInstanceName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseInstanceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).EventName = (string) content.GetValueForProperty("EventName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).EventName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SolutionName = (string) content.GetValueForProperty("SolutionName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SolutionName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AlertSettingName = (string) content.GetValueForProperty("AlertSettingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AlertSettingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VirtualMachineName = (string) content.GetValueForProperty("VirtualMachineName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VirtualMachineName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).FabricName = (string) content.GetValueForProperty("FabricName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).FabricName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).LogicalNetworkName = (string) content.GetValueForProperty("LogicalNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).LogicalNetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkName = (string) content.GetValueForProperty("NetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkMappingName = (string) content.GetValueForProperty("NetworkMappingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkMappingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectionContainerName = (string) content.GetValueForProperty("ProtectionContainerName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectionContainerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationItemName = (string) content.GetValueForProperty("MigrationItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationRecoveryPointName = (string) content.GetValueForProperty("MigrationRecoveryPointName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationRecoveryPointName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectableItemName = (string) content.GetValueForProperty("ProtectableItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectableItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicatedProtectedItemName = (string) content.GetValueForProperty("ReplicatedProtectedItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicatedProtectedItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicationProtectedItemName = (string) content.GetValueForProperty("ReplicationProtectedItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicationProtectedItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPointName = (string) content.GetValueForProperty("RecoveryPointName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPointName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MappingName = (string) content.GetValueForProperty("MappingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MappingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProviderName = (string) content.GetValueForProperty("ProviderName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProviderName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationName = (string) content.GetValueForProperty("StorageClassificationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationMappingName = (string) content.GetValueForProperty("StorageClassificationMappingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationMappingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).PolicyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).IntentObjectName = (string) content.GetValueForProperty("IntentObjectName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).IntentObjectName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPlanName = (string) content.GetValueForProperty("RecoveryPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPlanName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VaultSettingName = (string) content.GetValueForProperty("VaultSettingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VaultSettingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.MigrateIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MigrateIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SiteName = (string) content.GetValueForProperty("SiteName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SiteName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ClusterName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).HostName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).JobName = (string) content.GetValueForProperty("JobName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).JobName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MachineName = (string) content.GetValueForProperty("MachineName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MachineName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).OperationStatusName = (string) content.GetValueForProperty("OperationStatusName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).OperationStatusName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AccountName = (string) content.GetValueForProperty("AccountName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrateProjectName = (string) content.GetValueForProperty("MigrateProjectName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrateProjectName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VcenterName = (string) content.GetValueForProperty("VcenterName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VcenterName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseInstanceName = (string) content.GetValueForProperty("DatabaseInstanceName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseInstanceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseName = (string) content.GetValueForProperty("DatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).DatabaseName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).EventName = (string) content.GetValueForProperty("EventName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).EventName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SolutionName = (string) content.GetValueForProperty("SolutionName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).SolutionName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ResourceName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AlertSettingName = (string) content.GetValueForProperty("AlertSettingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).AlertSettingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VirtualMachineName = (string) content.GetValueForProperty("VirtualMachineName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VirtualMachineName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).FabricName = (string) content.GetValueForProperty("FabricName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).FabricName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).LogicalNetworkName = (string) content.GetValueForProperty("LogicalNetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).LogicalNetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkName = (string) content.GetValueForProperty("NetworkName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkMappingName = (string) content.GetValueForProperty("NetworkMappingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).NetworkMappingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectionContainerName = (string) content.GetValueForProperty("ProtectionContainerName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectionContainerName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationItemName = (string) content.GetValueForProperty("MigrationItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationRecoveryPointName = (string) content.GetValueForProperty("MigrationRecoveryPointName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MigrationRecoveryPointName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectableItemName = (string) content.GetValueForProperty("ProtectableItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProtectableItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicatedProtectedItemName = (string) content.GetValueForProperty("ReplicatedProtectedItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicatedProtectedItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicationProtectedItemName = (string) content.GetValueForProperty("ReplicationProtectedItemName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ReplicationProtectedItemName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPointName = (string) content.GetValueForProperty("RecoveryPointName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPointName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MappingName = (string) content.GetValueForProperty("MappingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).MappingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProviderName = (string) content.GetValueForProperty("ProviderName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).ProviderName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationName = (string) content.GetValueForProperty("StorageClassificationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationMappingName = (string) content.GetValueForProperty("StorageClassificationMappingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).StorageClassificationMappingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).PolicyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).IntentObjectName = (string) content.GetValueForProperty("IntentObjectName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).IntentObjectName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPlanName = (string) content.GetValueForProperty("RecoveryPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).RecoveryPlanName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VaultSettingName = (string) content.GetValueForProperty("VaultSettingName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).VaultSettingName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentityInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(MigrateIdentityTypeConverter))]
    public partial interface IMigrateIdentity

    {

    }
}