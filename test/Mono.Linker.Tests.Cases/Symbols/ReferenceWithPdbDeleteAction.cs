﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.Symbols.Dependencies;

namespace Mono.Linker.Tests.Cases.Symbols
{
	[SetupLinkerArgument ("--skip-unresolved", "true")]
	[Reference ("Dependencies/LibraryWithPdb/LibraryWithPdb.dll")]
	[ReferenceDependency ("Dependencies/LibraryWithPdb/LibraryWithPdb.pdb")]
	[SetupLinkerLinkSymbols ("false")]

	[RemovedAssembly ("LibraryWithPdb.dll")]
	[RemovedSymbols ("LibraryWithPdb.dll")]
	public class ReferenceWithPdbDeleteAction
	{
		static void Main ()
		{
		}

		/// <summary>
		/// By not using this method we will cause the linker to delete the reference
		/// </summary>
		static void UnusedCodePath ()
		{
			LibraryWithPdb.SomeMethod ();
		}
	}
}