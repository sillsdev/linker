// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.DynamicDependencies.Dependencies
{
	public class DynamicDependencyInCopyAssembly
	{
		[DynamicDependency ("ExtraMethod1")]
		public DynamicDependencyInCopyAssembly ()
		{
		}

		static void ExtraMethod1 ()
		{
		}
	}
}
