// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Backup status.</summary>
    public partial struct BackupItemStatus :
        System.IEquatable<BackupItemStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus Created = @"Created";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus DeleteFailed = @"DeleteFailed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus DeleteInProgress = @"DeleteInProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus Deleted = @"Deleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus InProgress = @"InProgress";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus PartiallySucceeded = @"PartiallySucceeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus Skipped = @"Skipped";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus TimedOut = @"TimedOut";

        /// <summary>the value for an instance of the <see cref="BackupItemStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="BackupItemStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private BackupItemStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to BackupItemStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BackupItemStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new BackupItemStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type BackupItemStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type BackupItemStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is BackupItemStatus && Equals((BackupItemStatus)obj);
        }

        /// <summary>Returns hashCode for enum BackupItemStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for BackupItemStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to BackupItemStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BackupItemStatus" />.</param>

        public static implicit operator BackupItemStatus(string value)
        {
            return new BackupItemStatus(value);
        }

        /// <summary>Implicit operator to convert BackupItemStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="BackupItemStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum BackupItemStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum BackupItemStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.BackupItemStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}