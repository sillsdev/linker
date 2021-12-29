// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Reflection
{
	public class TypeUsedViaReflectionLdstrValidButChanged
	{
		public static void Main ()
		{
			var replace = "Mono.Linker";
			var with = "Blah.Blah";
			var typeName = "Mono.Linker.Tests.Cases.Reflection.TypeUsedViaReflectionLdstrValidButChanged+Full, test";
			var typeKept = Type.GetType (typeName.Replace (replace, with), false);
		}

		public class Full { }
	}
}