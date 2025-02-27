// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Update classifications included in the software update configuration. </summary>
    public readonly partial struct LinuxUpdateClass : IEquatable<LinuxUpdateClass>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LinuxUpdateClass"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LinuxUpdateClass(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnclassifiedValue = "Unclassified";
        private const string CriticalValue = "Critical";
        private const string SecurityValue = "Security";
        private const string OtherValue = "Other";

        /// <summary> Unclassified. </summary>
        public static LinuxUpdateClass Unclassified { get; } = new LinuxUpdateClass(UnclassifiedValue);
        /// <summary> Critical. </summary>
        public static LinuxUpdateClass Critical { get; } = new LinuxUpdateClass(CriticalValue);
        /// <summary> Security. </summary>
        public static LinuxUpdateClass Security { get; } = new LinuxUpdateClass(SecurityValue);
        /// <summary> Other. </summary>
        public static LinuxUpdateClass Other { get; } = new LinuxUpdateClass(OtherValue);
        /// <summary> Determines if two <see cref="LinuxUpdateClass"/> values are the same. </summary>
        public static bool operator ==(LinuxUpdateClass left, LinuxUpdateClass right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LinuxUpdateClass"/> values are not the same. </summary>
        public static bool operator !=(LinuxUpdateClass left, LinuxUpdateClass right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LinuxUpdateClass"/>. </summary>
        public static implicit operator LinuxUpdateClass(string value) => new LinuxUpdateClass(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LinuxUpdateClass other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LinuxUpdateClass other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
