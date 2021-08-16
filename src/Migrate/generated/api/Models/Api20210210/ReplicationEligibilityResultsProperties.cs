namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Properties model for replication eligibility results API.</summary>
    public partial class ReplicationEligibilityResultsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClientRequestId" /> property.</summary>
        private string _clientRequestId;

        /// <summary>The client request Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ClientRequestId { get => this._clientRequestId; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsErrorInfo[] _error;

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsErrorInfo[] Error { get => this._error; set => this._error = value; }

        /// <summary>Internal Acessors for ClientRequestId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsPropertiesInternal.ClientRequestId { get => this._clientRequestId; set { {_clientRequestId = value;} } }

        /// <summary>Creates an new <see cref="ReplicationEligibilityResultsProperties" /> instance.</summary>
        public ReplicationEligibilityResultsProperties()
        {

        }
    }
    /// Properties model for replication eligibility results API.
    public partial interface IReplicationEligibilityResultsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The client request Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The client request Id.",
        SerializedName = @"clientRequestId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientRequestId { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The error details.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsErrorInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsErrorInfo[] Error { get; set; }

    }
    /// Properties model for replication eligibility results API.
    internal partial interface IReplicationEligibilityResultsPropertiesInternal

    {
        /// <summary>The client request Id.</summary>
        string ClientRequestId { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationEligibilityResultsErrorInfo[] Error { get; set; }

    }
}