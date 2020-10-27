// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>The action to take when an unauthenticated client attempts to access the app.</summary>
    public partial struct UnauthenticatedClientAction :
        System.IEquatable<UnauthenticatedClientAction>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction AllowAnonymous = @"AllowAnonymous";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction RedirectToLoginPage = @"RedirectToLoginPage";

        /// <summary>
        /// the value for an instance of the <see cref="UnauthenticatedClientAction" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UnauthenticatedClientAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UnauthenticatedClientAction" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UnauthenticatedClientAction(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UnauthenticatedClientAction</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UnauthenticatedClientAction (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UnauthenticatedClientAction && Equals((UnauthenticatedClientAction)obj);
        }

        /// <summary>Returns hashCode for enum UnauthenticatedClientAction</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UnauthenticatedClientAction</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="UnauthenticatedClientAction" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UnauthenticatedClientAction(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UnauthenticatedClientAction</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UnauthenticatedClientAction" />.</param>

        public static implicit operator UnauthenticatedClientAction(string value)
        {
            return new UnauthenticatedClientAction(value);
        }

        /// <summary>Implicit operator to convert UnauthenticatedClientAction to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UnauthenticatedClientAction" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UnauthenticatedClientAction</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UnauthenticatedClientAction</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.UnauthenticatedClientAction e2)
        {
            return e2.Equals(e1);
        }
    }
}