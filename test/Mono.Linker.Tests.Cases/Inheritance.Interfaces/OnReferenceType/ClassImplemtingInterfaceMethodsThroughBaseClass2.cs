// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType
{
	class ClassImplemtingInterfaceMethodsThroughBaseClass2
	{
		public static void Main ()
		{
			new B ();
			IFoo i = null;
			i.Foo ();
		}

		interface IFoo
		{
			[Kept]
			void Foo ();
		}

		[KeptMember (".ctor()")]
		class B
		{
			[Kept] // FIXME: Should be removed
			public void Foo ()
			{
			}
		}

		class A : B, IFoo
		{
			//my IFoo.Foo() is actually implemented by B which doesn't know about it.
		}
	}
}
