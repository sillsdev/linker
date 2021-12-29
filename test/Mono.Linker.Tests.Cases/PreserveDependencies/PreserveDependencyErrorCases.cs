// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.PreserveDependencies
{
	[SetupCompileBefore ("FakeSystemAssembly.dll", new[] { "Dependencies/PreserveDependencyAttribute.cs" })]
	[SetupLinkerArgument ("--skip-unresolved", "true")]
	class PreserveDependencyErrorCases
	{
		public static void Main ()
		{
			UnresolvedAssembly ();
			UnresolvedType ();
			UnresolvedMember ();
		}

		[Kept]
		[PreserveDependency ("*", "TypeName", "UnresolvedAssembly_AssemblyName")]
		[ExpectedWarning ("IL2003", "UnresolvedAssembly_AssemblyName")]
		static void UnresolvedAssembly ()
		{
		}

		[Kept]
		[PreserveDependency ("*", "UnresolvedType_TypeName")]
		[ExpectedWarning ("IL2004", "UnresolvedType_TypeName")]
		static void UnresolvedType ()
		{
		}

		[Kept]
		[PreserveDependency ("UnresolvedMember_MemberName")]
		[ExpectedWarning ("IL2005", "UnresolvedMember_MemberName")]
		static void UnresolvedMember ()
		{
		}
	}
}
