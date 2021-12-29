// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.TypeForwarding.Dependencies;

namespace Mono.Linker.Tests.Cases.TypeForwarding
{
	// Actions:
	// link - This assembly, Forwarder.dll and Implementation.dll
	// --keep-facades
	[SetupLinkerDefaultAction ("link")]
	[KeepTypeForwarderOnlyAssemblies ("true")]

	[SetupCompileBefore ("Forwarder.dll", new[] { "Dependencies/ReferenceImplementationLibrary.cs" }, defines: new[] { "INCLUDE_REFERENCE_IMPL" })]

	// After compiling the test case we then replace the reference impl with implementation + type forwarder
	[SetupCompileAfter ("Implementation.dll", new[] { "Dependencies/ImplementationLibrary.cs" })]
	[SetupCompileAfter ("Forwarder.dll", new[] { "Dependencies/ForwarderLibrary.cs" }, references: new[] { "Implementation.dll" })]

	[KeptAssembly ("Forwarder.dll")]
	[RemovedForwarder ("Forwarder.dll", "ImplementationLibrary")]
	[RemovedAssembly ("Implementation.dll")]
	class UnusedForwarderWithAssemblyLinkedAndFacadesKept
	{
		static void Main ()
		{
		}

		static void Unused ()
		{
			new ImplementationLibrary ().GetSomeValue ();
		}
	}
}
