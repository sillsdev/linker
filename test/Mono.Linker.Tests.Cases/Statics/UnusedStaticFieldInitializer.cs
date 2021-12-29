// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Statics
{
	public class UnusedStaticFieldInitializer
	{
		public static void Main ()
		{
			C.Foo ();
		}

		static class C
		{
			public static object o = new object ();

			[Kept]
			public static void Foo ()
			{
			}
		}
	}
}
