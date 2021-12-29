// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Permissions;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Attributes.NoSecurity
{
	[SetupLinkerArgument ("--strip-security", "true")]
	public class SecurityAttributesOnUsedMethodAreRemoved
	{
		static void Main ()
		{
			new Foo ().Method ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		class Foo
		{
			[SecurityPermission (SecurityAction.LinkDemand)]
			[Kept]
			[RemovedPseudoAttribute (16384)]
			public void Method ()
			{
			}
		}
	}
}