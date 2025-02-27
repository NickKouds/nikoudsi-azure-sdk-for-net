// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Backup state of the backed up item. </summary>
    public readonly partial struct ProtectedItemState : IEquatable<ProtectedItemState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProtectedItemState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProtectedItemState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string IRPendingValue = "IRPending";
        private const string ProtectedValue = "Protected";
        private const string ProtectionErrorValue = "ProtectionError";
        private const string ProtectionStoppedValue = "ProtectionStopped";
        private const string ProtectionPausedValue = "ProtectionPaused";

        /// <summary> Invalid. </summary>
        public static ProtectedItemState Invalid { get; } = new ProtectedItemState(InvalidValue);
        /// <summary> IRPending. </summary>
        public static ProtectedItemState IRPending { get; } = new ProtectedItemState(IRPendingValue);
        /// <summary> Protected. </summary>
        public static ProtectedItemState Protected { get; } = new ProtectedItemState(ProtectedValue);
        /// <summary> ProtectionError. </summary>
        public static ProtectedItemState ProtectionError { get; } = new ProtectedItemState(ProtectionErrorValue);
        /// <summary> ProtectionStopped. </summary>
        public static ProtectedItemState ProtectionStopped { get; } = new ProtectedItemState(ProtectionStoppedValue);
        /// <summary> ProtectionPaused. </summary>
        public static ProtectedItemState ProtectionPaused { get; } = new ProtectedItemState(ProtectionPausedValue);
        /// <summary> Determines if two <see cref="ProtectedItemState"/> values are the same. </summary>
        public static bool operator ==(ProtectedItemState left, ProtectedItemState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProtectedItemState"/> values are not the same. </summary>
        public static bool operator !=(ProtectedItemState left, ProtectedItemState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProtectedItemState"/>. </summary>
        public static implicit operator ProtectedItemState(string value) => new ProtectedItemState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProtectedItemState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProtectedItemState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
