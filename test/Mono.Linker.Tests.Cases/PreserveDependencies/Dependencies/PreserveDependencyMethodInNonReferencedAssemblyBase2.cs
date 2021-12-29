// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.PreserveDependencies.Dependencies
{
	public class PreserveDependencyMethodInNonReferencedAssemblyBase2 : PreserveDependencyMethodInNonReferencedAssemblyBase
	{
		public override string Method ()
		{
			return "Base2";
		}
	}
}