// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnValueType
{
	class StructUsedFromInterfaceHasInterfaceMethodKept
	{
		public static void Main ()
		{
			IFoo a = new A ();
			a.Foo ();
		}

		[Kept]
		[KeptInterface (typeof (IFoo))]
		struct A : IFoo
		{
			[Kept]
			public void Foo ()
			{
			}
		}

		[Kept]
		public interface IFoo
		{
			[Kept]
			void Foo ();
		}
	}
}
