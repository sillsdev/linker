// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType.NoKeptCtor
{
	public class GenericType
	{
		public static void Main ()
		{
			object o = new Bar<Foo> ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		class Bar<T>
		{
		}

		[Kept]
		class Foo : IFoo
		{
		}

		interface IFoo
		{
		}
	}
}