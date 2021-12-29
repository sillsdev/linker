// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Interop.InternalCalls
{
	class UnusedFieldsOfTypesWhenHasThisAreNotRemoved
	{
		public static void Main ()
		{
			A a = new A ();
			a.SomeMethod ();
		}

		[KeptMember (".ctor()")]
		class A
		{
			[Kept] private int field1;

			[Kept]
			[MethodImpl (MethodImplOptions.InternalCall)]
			public extern void SomeMethod ();
		}
	}
}