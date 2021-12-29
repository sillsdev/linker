// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Resources
{
	[IgnoreDescriptors (false)]
	[SetupCompileResource ("Dependencies/EmbeddedLinkXmlFileIsNotProcessedIfNameDoesNotMatchAnAssembly.xml", "NotMatchingAnAssemblyName.xml")]
	[SkipPeVerify]
	[KeptResource ("NotMatchingAnAssemblyName.xml")]
	public class EmbeddedLinkXmlFileIsNotProcessedIfNameDoesNotMatchAnAssembly
	{
		public static void Main ()
		{
		}

		public class Unused
		{
		}
	}
}
