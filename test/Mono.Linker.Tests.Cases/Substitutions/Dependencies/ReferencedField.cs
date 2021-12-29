// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.Substitutions.Dependencies
{
	public class ReferencedField
	{
		static ReferencedField ()
		{
			BoolValue = false;
		}
		public static bool BoolValue;
	}
}
