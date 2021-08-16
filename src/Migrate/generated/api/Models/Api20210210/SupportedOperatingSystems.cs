namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Supported operating systems.</summary>
    public partial class SupportedOperatingSystems :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOperatingSystems,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOperatingSystemsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.Resource();

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; }

        /// <summary>Resource Location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOperatingSystemsInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.SupportedOSProperties()); set { {_property = value;} } }

        /// <summary>Resource Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperties _property;

        /// <summary>The supported operating systems properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.SupportedOSProperties()); set => this._property = value; }

        /// <summary>The supported operating systems property list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty[] SupportedOSList { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSPropertiesInternal)Property).SupportedOSList; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSPropertiesInternal)Property).SupportedOSList = value ?? null /* arrayOf */; }

        /// <summary>Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="SupportedOperatingSystems" /> instance.</summary>
        public SupportedOperatingSystems()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Supported operating systems.
    public partial interface ISupportedOperatingSystems :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource
    {
        /// <summary>The supported operating systems property list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The supported operating systems property list.",
        SerializedName = @"supportedOsList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty[] SupportedOSList { get; set; }

    }
    /// Supported operating systems.
    internal partial interface ISupportedOperatingSystemsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal
    {
        /// <summary>The supported operating systems properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperties Property { get; set; }
        /// <summary>The supported operating systems property list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSProperty[] SupportedOSList { get; set; }

    }
}