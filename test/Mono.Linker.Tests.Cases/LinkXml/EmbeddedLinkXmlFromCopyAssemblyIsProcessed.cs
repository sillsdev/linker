// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.LinkXml.Dependencies.EmbeddedLinkXmlFromCopyAssemblyIsProcessed;

namespace Mono.Linker.Tests.Cases.LinkXml
{
	[SetupCompileBefore ("Library.dll",
		new[] { "Dependencies/EmbeddedLinkXmlFromCopyAssemblyIsProcessed/OtherLibrary.cs" })]
	[SetupCompileBefore ("CopyLibrary.dll",
		new[] { "Dependencies/EmbeddedLinkXmlFromCopyAssemblyIsProcessed/CopyLibrary.cs" },
		resources: new object[] { "Dependencies/EmbeddedLinkXmlFromCopyAssemblyIsProcessed/CopyLibrary.xml" })]
	[IgnoreDescriptors (false)]
	[SetupLinkerAction ("copy", "CopyLibrary")]

	[KeptTypeInAssembly ("CopyLibrary.dll", typeof (CopyLibrary))]
	[KeptTypeInAssembly ("Library.dll", typeof (OtherLibrary))]
	public class EmbeddedLinkXmlFromCopyAssemblyIsProcessed
	{
		public static void Main ()
		{
			var tmp = new CopyLibrary ();
			tmp.Method ();
		}
	}
}