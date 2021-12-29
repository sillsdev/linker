// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Helpers;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.CoreLink
{
	[SetupLinkerTrimMode ("copy")]
	// System.dll referenced by a dynamically (for example in TypeConverterAttribute on IComponent)
	// has unresolved references.
	[SetupLinkerArgument ("--skip-unresolved")]

	[KeptAssembly (PlatformAssemblies.CoreLib)]
	[KeptAllTypesAndMembersInAssembly (PlatformAssemblies.CoreLib)]

	[SkipPeVerify]
	class CopyOfCoreLibrariesKeepsUnusedTypes
	{
		public static void Main ()
		{
		}
	}
}
