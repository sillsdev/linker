// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using System.Timers;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Helpers;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Attributes
{
	[Reference ("System.dll")]
	[SetupLinkerTrimMode ("link")]
	// System.dll referenced by a dynamically (for example in TypeConverterAttribute on IComponent)
	// has unresolved references.
	[SetupLinkerArgument ("--skip-unresolved", "true")]
	[KeptAttributeInAssembly (PlatformAssemblies.CoreLib, typeof (AssemblyDescriptionAttribute))]
	[KeptAttributeInAssembly (PlatformAssemblies.CoreLib, typeof (AssemblyCompanyAttribute))]
#if !NETCOREAPP
	[KeptAttributeInAssembly ("System.dll", typeof (AssemblyDescriptionAttribute))]
	[KeptAttributeInAssembly ("System.dll", typeof (AssemblyCompanyAttribute))]
#endif
	[SkipPeVerify]
	public class CoreLibraryAssemblyAttributesAreKept
	{
		public static void Main ()
		{
			// Use something from System so that the entire reference isn't linked away
			var system = new Timer ();
		}
	}
}