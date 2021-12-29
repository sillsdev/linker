// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.PreserveDependencies
{
	[SetupCompileBefore ("FakeSystemAssembly.dll", new[] { "Dependencies/PreserveDependencyAttribute.cs" })]
	[SetupLinkerArgument ("--keep-dep-attributes", "true")]
	[KeptTypeInAssembly ("FakeSystemAssembly.dll", typeof (PreserveDependencyAttribute))]
	class PreserveDependencyKeptOption
	{
		public static void Main ()
		{
			B.Test ();
		}

		class B
		{
			[Kept]
			int field;

			[Kept]
			[KeptAttributeAttribute (typeof (PreserveDependencyAttribute))]

			[PreserveDependency ("field")]
			public static void Test ()
			{
			}
		}
	}
}