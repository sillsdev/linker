// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType.NoKeptCtorButInterfaceNeeded
{
	public class GenericType
	{
		public static void Main ()
		{
			Foo f = null;
			Bar<IFoo> o = new Bar<IFoo> ();
			o.Method (f);
		}

		[Kept]
		[KeptMember (".ctor()")]
		class Bar<T>
		{
			[Kept]
			public void Method (T arg)
			{
			}
		}

		[Kept]
		[KeptInterface (typeof (IFoo))]
		class Foo : IFoo
		{
		}

		[Kept]
		interface IFoo
		{
		}
	}
}