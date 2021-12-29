﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.DynamicDependencies.Dependencies
{
	public class AssemblyDependency
	{
		public AssemblyDependency ()
		{
		}

		public static void UsedToKeepReferenceAtCompileTime ()
		{
		}

		class TypeThatIsUsedViaReflection
		{
		}
	}
}
