// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Statics
{
	public class UnusedStaticMethodGetsRemoved
	{
		public static void Main ()
		{
			A.UsedMethod ();
		}
	}

	[Kept]
	class A
	{
		[Kept]
		public static void UsedMethod ()
		{
		}

		static void UnusedMethod ()
		{
		}
	}
}