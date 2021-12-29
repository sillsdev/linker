// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.Resources.Dependencies;

namespace Mono.Linker.Tests.Cases.Resources
{
	[SetupCompileBefore (
		"library.dll",
		new[] { "Dependencies/EmbeddedLinkXmlFileInReferencedAssemblyIsNotProcessedIfNameDoesNotMatchAnAssembly_Lib1.cs" },
		resources: new object[] { "Dependencies/EmbeddedLinkXmlFileInReferencedAssemblyIsNotProcessedIfNameDoesNotMatchAnAssembly_Lib1_NotMatchingName.xml" })]
	[IgnoreDescriptors (false)]

	[KeptResourceInAssembly ("library.dll", "EmbeddedLinkXmlFileInReferencedAssemblyIsNotProcessedIfNameDoesNotMatchAnAssembly_Lib1_NotMatchingName.xml")]
	[RemovedMemberInAssembly ("library.dll", typeof (EmbeddedLinkXmlFileInReferencedAssemblyIsNotProcessedIfNameDoesNotMatchAnAssembly_Lib1), "Unused()")]
	public class EmbeddedLinkXmlFileInReferencedAssemblyIsNotProcessedIfNameDoesNotMatchAnAssembly
	{
		public static void Main ()
		{
			EmbeddedLinkXmlFileInReferencedAssemblyIsNotProcessedIfNameDoesNotMatchAnAssembly_Lib1.Used ();
		}
	}
}