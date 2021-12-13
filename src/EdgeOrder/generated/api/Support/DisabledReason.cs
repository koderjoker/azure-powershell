// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support
{

    /// <summary>Reason why the product is disabled.</summary>
    public partial struct DisabledReason :
        System.IEquatable<DisabledReason>
    {
        /// <summary>Not available in the requested country.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason Country = @"Country";

        /// <summary>Required features are not enabled.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason Feature = @"Feature";

        /// <summary>
        /// Subscription has not registered to Microsoft.DataBox and Service does not have the subscription notification.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason NoSubscriptionInfo = @"NoSubscriptionInfo";

        /// <summary>Not disabled.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason None = @"None";

        /// <summary>The product is not yet available.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason NotAvailable = @"NotAvailable";

        /// <summary>Subscription does not have required offer types.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason OfferType = @"OfferType";

        /// <summary>The product is out of stock.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason OutOfStock = @"OutOfStock";

        /// <summary>Not available to push data to the requested Azure region.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason Region = @"Region";

        /// <summary>the value for an instance of the <see cref="DisabledReason" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DisabledReason</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DisabledReason" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DisabledReason(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DisabledReason" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DisabledReason(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DisabledReason</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DisabledReason (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DisabledReason && Equals((DisabledReason)obj);
        }

        /// <summary>Returns hashCode for enum DisabledReason</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DisabledReason</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DisabledReason</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DisabledReason" />.</param>

        public static implicit operator DisabledReason(string value)
        {
            return new DisabledReason(value);
        }

        /// <summary>Implicit operator to convert DisabledReason to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DisabledReason" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DisabledReason</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DisabledReason</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason e1, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason e2)
        {
            return e2.Equals(e1);
        }
    }
}