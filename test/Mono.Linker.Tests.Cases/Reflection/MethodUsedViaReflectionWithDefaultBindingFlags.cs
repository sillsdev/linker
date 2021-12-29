// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Reflection
{
	public class MethodUsedViaReflectionWithDefaultBindingFlags
	{
		public static void Main ()
		{
			new Foo (); // Needed to avoid lazy body marking stubbing
			var method = typeof (Foo).GetMethod ("OnlyCalledViaReflection");
			method.Invoke (null, new object[] { });
		}

		[KeptMember (".ctor()")]
		class Foo
		{
			private static int OnlyCalledViaReflection ()
			{
				return 42;
			}

			private int OnlyCalledViaReflection (int foo)
			{
				return 43;
			}

			[Kept]
			public int OnlyCalledViaReflection (int foo, int bar)
			{
				return 44;
			}

			[Kept]
			public static int OnlyCalledViaReflection (int foo, int bar, int baz)
			{
				return 45;
			}
		}
	}
}
