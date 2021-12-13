// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Virtual IP mapping.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualIPMappingTypeConverter))]
    public partial class VirtualIPMapping
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VirtualIPMapping"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMapping" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMapping DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualIPMapping(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VirtualIPMapping"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMapping" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMapping DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualIPMapping(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualIPMapping" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMapping FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VirtualIPMapping"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualIPMapping(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).VirtualIP = (string) content.GetValueForProperty("VirtualIP",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).VirtualIP, global::System.Convert.ToString);
            }
            if (content.Contains("InternalHttpPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpPort = (int?) content.GetValueForProperty("InternalHttpPort",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InternalHttpsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpsPort = (int?) content.GetValueForProperty("InternalHttpsPort",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpsPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InUse"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InUse = (bool?) content.GetValueForProperty("InUse",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InUse, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ServiceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).ServiceName = (string) content.GetValueForProperty("ServiceName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).ServiceName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.VirtualIPMapping"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualIPMapping(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VirtualIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).VirtualIP = (string) content.GetValueForProperty("VirtualIP",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).VirtualIP, global::System.Convert.ToString);
            }
            if (content.Contains("InternalHttpPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpPort = (int?) content.GetValueForProperty("InternalHttpPort",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InternalHttpsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpsPort = (int?) content.GetValueForProperty("InternalHttpsPort",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InternalHttpsPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("InUse"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InUse = (bool?) content.GetValueForProperty("InUse",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).InUse, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ServiceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).ServiceName = (string) content.GetValueForProperty("ServiceName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IVirtualIPMappingInternal)this).ServiceName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Virtual IP mapping.
    [System.ComponentModel.TypeConverter(typeof(VirtualIPMappingTypeConverter))]
    public partial interface IVirtualIPMapping

    {

    }
}