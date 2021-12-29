// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.TypeForwarding
{
	[SkipUnresolved (true)]
	[Define ("IL_ASSEMBLY_AVAILABLE")]
	[SetupCompileBefore ("TypeForwarderMissingReference.dll", new[] { "Dependencies/TypeForwarderMissingReference.il" })]
	[SetupLinkerAction ("link", "TypeForwarderMissingReference.dll")]

	[KeptMemberInAssembly ("TypeForwarderMissingReference.dll", "DummyClass", ".ctor()")]
	[RemovedForwarder ("TypeForwarderMissingReference.dll", "C")]
	[RemovedForwarder ("TypeForwarderMissingReference.dll", "G<>")]
	public class MissingTargetReference
	{
		public static void Main ()
		{
#if IL_ASSEMBLY_AVAILABLE
			Console.WriteLine (new DummyClass ());
#endif
		}
	}
}
