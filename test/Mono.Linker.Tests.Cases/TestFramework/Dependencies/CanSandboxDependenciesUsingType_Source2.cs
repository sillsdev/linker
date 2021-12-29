// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.TestFramework.Dependencies
{
	[Kept]
	public class CanSandboxDependenciesUsingType_Source2
	{
		[Kept]
		public class Nested1
		{
			[Kept]
			public class Nested2
			{
				[Kept]
				public static void Method ()
				{
				}
			}
		}
	}
}