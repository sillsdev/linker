﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Symbols
{
	[SetupCompileArgument ("/debug:full")]
	[SetupLinkerLinkSymbols ("false")]
	[RemovedSymbols ("test.exe")]
	public class AssemblyWithDefaultSymbols
	{
		static void Main ()
		{
		}
	}
}