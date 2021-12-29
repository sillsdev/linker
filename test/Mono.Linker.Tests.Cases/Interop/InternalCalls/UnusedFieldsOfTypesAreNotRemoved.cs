// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Interop.InternalCalls
{
	class UnusedFieldsOfTypesAreNotRemoved
	{
		public static void Main ()
		{
			var a = new A ();
			SomeMethod (a);
		}

		[KeptMember (".ctor()")]
		class A
		{
			[Kept] private int field1;

			[Kept] private int field2;
		}

		[Kept]
		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern void SomeMethod (A a);
	}
}