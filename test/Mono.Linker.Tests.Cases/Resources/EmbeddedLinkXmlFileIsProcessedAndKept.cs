// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Resources
{
	[IgnoreDescriptors (false)]
	[StripDescriptors (false)]

	[SetupCompileResource ("Dependencies/EmbeddedLinkXmlFileIsProcessedAndKept.xml", "ILLink.Descriptors.xml")]
	[SkipPeVerify]
	[KeptResource ("ILLink.Descriptors.xml")]
	public class EmbeddedLinkXmlFileIsProcessedAndKept
	{
		public static void Main ()
		{
		}

		[Kept]
		[KeptMember (".ctor()")]
		public class Unused
		{
		}
	}
}
