// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Statics
{
	class UnusedStaticConstructorGetsRemoved
	{
		public static void Main ()
		{
		}

		static void Dead ()
		{
			new B ();
		}

		class B
		{
			static B ()
			{
			}
		}
	}
}