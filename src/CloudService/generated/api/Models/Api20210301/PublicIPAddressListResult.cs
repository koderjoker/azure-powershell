// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Response for ListPublicIpAddresses API service call.</summary>
    public partial class PublicIPAddressListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressListResult,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress[] _value;

        /// <summary>A list of public IP addresses that exists in a resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PublicIPAddressListResult" /> instance.</summary>
        public PublicIPAddressListResult()
        {

        }
    }
    /// Response for ListPublicIpAddresses API service call.
    public partial interface IPublicIPAddressListResult :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to get the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>A list of public IP addresses that exists in a resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of public IP addresses that exists in a resource group.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress[] Value { get; set; }

    }
    /// Response for ListPublicIpAddresses API service call.
    internal partial interface IPublicIPAddressListResultInternal

    {
        /// <summary>The URL to get the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>A list of public IP addresses that exists in a resource group.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress[] Value { get; set; }

    }
}