// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.PreserveDependencies.Dependencies
{
	public class PreserveDependencyMethodInNonReferencedAssemblyLibrary : PreserveDependencyMethodInNonReferencedAssemblyBase
	{
		public override string Method ()
		{
			return "Dependency";
		}

		private void UnusedMethod ()
		{
		}
	}
}