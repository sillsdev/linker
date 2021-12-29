// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.TestFramework
{
	[SetupCompileArgument ("/debug:pdbonly")]
	class CanCompileTestCaseWithDebugPdbs
	{
		static void Main ()
		{
			new Foo ().Method ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		class Foo
		{
			[Kept]
			public void Method ()
			{
			}
		}
	}
}
