// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Mono.Linker.Tests.Cases.DynamicDependencies.Dependencies
{
	public class DynamicDependencyMethodInNonReferencedAssemblyChainedLibrary : DynamicDependencyMethodInNonReferencedAssemblyBase
	{
		public override string Method ()
		{
			Dependency ();
			return "Dependency";
		}

		[DynamicDependency ("#ctor()", "Mono.Linker.Tests.Cases.DynamicDependencies.Dependencies.DynamicDependencyMethodInNonReferencedAssemblyBase2", "base2")]
		public static void Dependency ()
		{
		}
	}
}