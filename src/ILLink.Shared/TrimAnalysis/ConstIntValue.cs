﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using ILLink.Shared.DataFlow;

namespace ILLink.Shared.TrimAnalysis
{
	/// <summary>
	/// Represents a ldc on an int32.
	/// </summary>
	sealed record ConstIntValue : SingleValue
	{
		public ConstIntValue (int value) => Value = value;

		public readonly int Value;

		public override string ToString () => this.ValueToString (Value);
	}
}
