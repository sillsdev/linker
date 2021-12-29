// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.TypeForwarding
{
	[SetupLinkerArgument ("--skip-unresolved", "true")]
	// Actions:
	// link - This assembly, TypeForwarderModifiersLibDef.dll and TypeForwardersModifiersLib.dll
	[SetupLinkerDefaultAction ("link")]
	[KeepTypeForwarderOnlyAssemblies ("false")]

	[Define ("IL_ASSEMBLY_AVAILABLE")]

	[SetupCompileBefore ("TypeForwarderModifiersLibDef.dll", new[] { "Dependencies/TypeForwardersModifiersLibDef.cs" })]
	[SetupCompileBefore ("TypeForwarderModifiersLibFwd.dll", new[] { "Dependencies/TypeForwardersModifiersLibFwd.cs" }, new[] { "TypeForwarderModifiersLibDef.dll" })]
	[SetupCompileBefore ("TypeForwardersModifiersLib.dll", new[] { "Dependencies/TypeForwardersModifiersLib.il" })]

	[RemovedAssembly ("TypeForwarderModifiersLibFwd.dll")]
	[RemovedAssemblyReference ("TypeForwardersModifiersLib", "TypeForwarderModifiersLibFwd")]

	[SkipPeVerify (SkipPeVerifyForToolchian.Pedump)]

	class TypeForwardersModifiers
	{
		static void Main ()
		{
#if IL_ASSEMBLY_AVAILABLE
			TestClass.TestAll ();
#endif
		}
	}
}
