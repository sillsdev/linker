// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Interop.InternalCalls
{
	class UnusedDefaultConstructorIsRemoved
	{
		public static void Main ()
		{
			var a = new A (1);
			SomeMethod (a);
		}

		class A
		{
			public A ()
			{
			}

			[Kept]
			public A (int other)
			{
			}
		}

		[Kept]
		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern void SomeMethod (A a);
	}
}