// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Resources
{
	[IgnoreDescriptors (true)]
	[StripDescriptors (true)]

	[SetupCompileResource ("Dependencies/EmbeddedLinkXmlFileIsNotProcessedWithIgnoreDescriptorsAndRemoved.xml", "ILLink.Descriptors.xml")]
	[SkipPeVerify]
	[RemovedResourceInAssembly ("test.exe", "ILLink.Descriptors.xml")]
	public class EmbeddedLinkXmlFileIsNotProcessedWithIgnoreDescriptorsAndRemoved
	{
		public static void Main ()
		{
		}

		public class Unused
		{
		}
	}
}
