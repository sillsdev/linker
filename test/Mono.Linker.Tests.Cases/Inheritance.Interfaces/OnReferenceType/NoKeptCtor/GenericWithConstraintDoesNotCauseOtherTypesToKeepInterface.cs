// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType.NoKeptCtor
{
	public class GenericWithConstraintDoesNotCauseOtherTypesToKeepInterface
	{
		public static void Main ()
		{
			Foo f = null;
			Helper (f);
			OtherMethodToDoStuff ();
		}

		[Kept]
		static void Helper<T> (T f) where T : IFoo
		{
		}

		[Kept]
		static void OtherMethodToDoStuff ()
		{
			HelperToUseFoo2 (null);
		}

		[Kept]
		static void HelperToUseFoo2 (Foo2 f)
		{
		}

		[Kept]
		[KeptInterface (typeof (IFoo))]
		class Foo : IFoo
		{
		}

		[Kept]
		class Foo2 : IFoo
		{
		}

		[Kept]
		interface IFoo
		{
		}
	}
}