// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType
{
	public class ClassUsedFromConcreteTypeHasInterfaceMethodRemoved2
	{
		public static void Main ()
		{
			A a = new A ();
			a.Foo ();

			// If IFoo is marked for any reason then all of a sudden we do need to keep IFoo on A
			var tmp = typeof (IFoo).ToString ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptInterface (typeof (IFoo))]
		class A : IFoo
		{
			[Kept]
			public void Foo ()
			{
			}
		}

		[Kept]
		public interface IFoo
		{
			void Foo ();
		}
	}
}