// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> Provisioning state of the Container App. </summary>
    public readonly partial struct ContainerAppProvisioningState : IEquatable<ContainerAppProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> InProgress. </summary>
        public static ContainerAppProvisioningState InProgress { get; } = new ContainerAppProvisioningState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static ContainerAppProvisioningState Succeeded { get; } = new ContainerAppProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ContainerAppProvisioningState Failed { get; } = new ContainerAppProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ContainerAppProvisioningState Canceled { get; } = new ContainerAppProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="ContainerAppProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContainerAppProvisioningState left, ContainerAppProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppProvisioningState left, ContainerAppProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerAppProvisioningState"/>. </summary>
        public static implicit operator ContainerAppProvisioningState(string value) => new ContainerAppProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
