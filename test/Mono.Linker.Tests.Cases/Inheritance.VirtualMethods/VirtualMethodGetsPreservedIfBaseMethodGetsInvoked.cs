// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.VirtualMethods
{
	class VirtualMethodGetsPreservedIfBaseMethodGetsInvoked
	{
		public static void Main ()
		{
			new A ();
			new B ().Foo ();
		}

		[KeptMember (".ctor()")]
		class B
		{
			[Kept]
			public virtual void Foo ()
			{
			}
		}

		[KeptMember (".ctor()")]
		[KeptBaseType (typeof (B))]
		class A : B
		{
			[Kept]
			public override void Foo ()
			{
			}
		}
	}
}
