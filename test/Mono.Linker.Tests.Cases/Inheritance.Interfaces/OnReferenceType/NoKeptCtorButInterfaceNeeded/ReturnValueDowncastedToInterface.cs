// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType.NoKeptCtorButInterfaceNeeded
{
	public class ReturnValueDowncastedToInterface
	{
		public static void Main ()
		{
			UseAnIFoo (GetAFoo ());
		}

		[Kept]
		static Foo GetAFoo ()
		{
			return null;
		}

		[Kept]
		static void UseAnIFoo (IFoo arg)
		{
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