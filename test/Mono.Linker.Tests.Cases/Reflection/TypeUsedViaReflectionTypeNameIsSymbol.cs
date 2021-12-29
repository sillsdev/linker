// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.Reflection
{
	public class TypeUsedViaReflectionTypeNameIsSymbol
	{
		public static void Main ()
		{
			var typeName = "+, test";
			var typeKept = Type.GetType (typeName, false);
		}

		public class Full { }
	}
}