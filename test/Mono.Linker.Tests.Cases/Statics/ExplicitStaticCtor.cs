// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Statics
{
	[SetupCompileArgument ("/optimize+")]
	public class ExplicitStaticCtor
	{
		public static void Main ()
		{
			C.Foo ();
			CEmpty.Foo ();
		}

		static class C
		{
			[Kept]
			static C ()
			{
				new object ();
			}

			[Kept]
			public static void Foo ()
			{
			}
		}

		[AddedPseudoAttributeAttribute ((uint) TypeAttributes.BeforeFieldInit)]
		static class CEmpty
		{
			static CEmpty ()
			{
			}

			[Kept]
			public static void Foo ()
			{
				++count;
			}

			[Kept]
			static int count;
		}
	}
}
