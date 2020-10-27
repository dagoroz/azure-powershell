// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support
{

    /// <summary>Type of the source uploaded</summary>
    public partial struct UserSourceType :
        System.IEquatable<UserSourceType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType Jar = @"Jar";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType NetCoreZip = @"NetCoreZip";

        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType Source = @"Source";

        /// <summary>the value for an instance of the <see cref="UserSourceType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UserSourceType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UserSourceType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UserSourceType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UserSourceType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UserSourceType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UserSourceType && Equals((UserSourceType)obj);
        }

        /// <summary>Returns hashCode for enum UserSourceType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UserSourceType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="UserSourceType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UserSourceType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UserSourceType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UserSourceType" />.</param>

        public static implicit operator UserSourceType(string value)
        {
            return new UserSourceType(value);
        }

        /// <summary>Implicit operator to convert UserSourceType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UserSourceType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UserSourceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType e1, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UserSourceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType e1, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Support.UserSourceType e2)
        {
            return e2.Equals(e1);
        }
    }
}