// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Indicates the type of bot service. </summary>
    public readonly partial struct BotServiceKind : IEquatable<BotServiceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BotServiceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BotServiceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SdkValue = "sdk";
        private const string DesignerValue = "designer";
        private const string BotValue = "bot";
        private const string FunctionValue = "function";
        private const string AzurebotValue = "azurebot";

        /// <summary> sdk. </summary>
        public static BotServiceKind Sdk { get; } = new BotServiceKind(SdkValue);
        /// <summary> designer. </summary>
        public static BotServiceKind Designer { get; } = new BotServiceKind(DesignerValue);
        /// <summary> bot. </summary>
        public static BotServiceKind Bot { get; } = new BotServiceKind(BotValue);
        /// <summary> function. </summary>
        public static BotServiceKind Function { get; } = new BotServiceKind(FunctionValue);
        /// <summary> azurebot. </summary>
        public static BotServiceKind Azurebot { get; } = new BotServiceKind(AzurebotValue);
        /// <summary> Determines if two <see cref="BotServiceKind"/> values are the same. </summary>
        public static bool operator ==(BotServiceKind left, BotServiceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BotServiceKind"/> values are not the same. </summary>
        public static bool operator !=(BotServiceKind left, BotServiceKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BotServiceKind"/>. </summary>
        public static implicit operator BotServiceKind(string value) => new BotServiceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BotServiceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BotServiceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
