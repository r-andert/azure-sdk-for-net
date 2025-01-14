// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Is the schedule enabled or disabled?
    /// Serialized Name: ScheduleStatus
    /// </summary>
    public readonly partial struct MachineLearningScheduleStatus : IEquatable<MachineLearningScheduleStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningScheduleStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary>
        /// Enabled
        /// Serialized Name: ScheduleStatus.Enabled
        /// </summary>
        public static MachineLearningScheduleStatus Enabled { get; } = new MachineLearningScheduleStatus(EnabledValue);
        /// <summary>
        /// Disabled
        /// Serialized Name: ScheduleStatus.Disabled
        /// </summary>
        public static MachineLearningScheduleStatus Disabled { get; } = new MachineLearningScheduleStatus(DisabledValue);
        /// <summary> Determines if two <see cref="MachineLearningScheduleStatus"/> values are the same. </summary>
        public static bool operator ==(MachineLearningScheduleStatus left, MachineLearningScheduleStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningScheduleStatus"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningScheduleStatus left, MachineLearningScheduleStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningScheduleStatus"/>. </summary>
        public static implicit operator MachineLearningScheduleStatus(string value) => new MachineLearningScheduleStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningScheduleStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningScheduleStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
