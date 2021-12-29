// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Advanced
{
	[SetupCompileArgument ("/optimize+")]
	[SetupLinkerArgument ("--disable-opt", "unusedtypechecks")]
	class TypeCheckRemovalDisabled
	{
		public static void Main ()
		{
			TestTypeCheckKept_1 (null);
		}

		[Kept]
		static void TestTypeCheckKept_1 (object o)
		{
			if (o is C1)
				return;
		}

		[Kept]
		public class C1
		{
		}
	}
}