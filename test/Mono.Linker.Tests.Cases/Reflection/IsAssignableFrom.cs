// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Reflection
{
	class IsAssignableFrom
	{
		[Kept]
		interface IFoo { }

		[Kept]
		[KeptInterface (typeof (IFoo))]
		class Foo : IFoo { }

		static void Main ()
		{
			typeof (IFoo).IsAssignableFrom (typeof (Foo));
		}

	}
}
