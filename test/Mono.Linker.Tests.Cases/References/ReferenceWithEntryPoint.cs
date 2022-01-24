// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.References.Dependencies;

namespace Mono.Linker.Tests.Cases.References
{
	// Actions:
	// link - This assembly
	// link - lib.exe

	[SetupCompileBefore ("lib.exe", new[] { "Dependencies/ReferenceWithEntryPoint_Lib.cs" })]
	[KeptAssembly ("lib.exe")]
	[KeptMemberInAssembly ("lib.exe", typeof (ReferenceWithEntryPoint_Lib), "UsedMethod()")]
	class ReferenceWithEntryPoint
	{
		public static void Main ()
		{
			ReferenceWithEntryPoint_Lib.UsedMethod ();
		}
	}
}
