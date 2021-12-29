// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Basic
{
	class UsedStructIsKept
	{
		public static void Main ()
		{
			A a;
			a.MethodVerifiedByKeptMember ();
		}

		[Kept]
		// This KeptMember is here to make sure the test framework's support of KeptMember on value types is working correctly
		[KeptMember ("MethodVerifiedByKeptMember()")]
		struct A
		{
			public void MethodVerifiedByKeptMember ()
			{
			}
		}
	}
}
