// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support
{

    /// <summary>The status of data ingestion for this workspace.</summary>
    public partial struct DataIngestionStatus :
        System.IEquatable<DataIngestionStatus>
    {
        /// <summary>80% of daily cap quota reached.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus ApproachingQuota = @"ApproachingQuota";

        /// <summary>Ingestion stopped following service setting change.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus ForceOff = @"ForceOff";

        /// <summary>Ingestion started following service setting change.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus ForceOn = @"ForceOn";

        /// <summary>Reached daily cap quota, ingestion stopped.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus OverQuota = @"OverQuota";

        /// <summary>Ingestion enabled following daily cap quota reset, or subscription enablement.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus RespectQuota = @"RespectQuota";

        /// <summary>Ingestion stopped following suspended subscription.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus SubscriptionSuspended = @"SubscriptionSuspended";

        /// <summary>the value for an instance of the <see cref="DataIngestionStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DataIngestionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataIngestionStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DataIngestionStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DataIngestionStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DataIngestionStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DataIngestionStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DataIngestionStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DataIngestionStatus && Equals((DataIngestionStatus)obj);
        }

        /// <summary>Returns hashCode for enum DataIngestionStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DataIngestionStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DataIngestionStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataIngestionStatus" />.</param>

        public static implicit operator DataIngestionStatus(string value)
        {
            return new DataIngestionStatus(value);
        }

        /// <summary>Implicit operator to convert DataIngestionStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DataIngestionStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DataIngestionStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DataIngestionStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus e1, Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Support.DataIngestionStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}