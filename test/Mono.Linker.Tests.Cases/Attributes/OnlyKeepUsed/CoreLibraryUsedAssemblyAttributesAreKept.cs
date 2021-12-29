// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using System.Timers;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Helpers;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Attributes.OnlyKeepUsed
{
	[Reference ("System.dll")]
	[SetupLinkerTrimMode ("link")]
	[SetupLinkerArgument ("--used-attrs-only", "true")]
	[KeptAttributeInAssembly (PlatformAssemblies.CoreLib, typeof (AssemblyDescriptionAttribute))]
#if !NETCOREAPP
	[KeptAttributeInAssembly ("System.dll", typeof (AssemblyDescriptionAttribute))]
#endif
	[SkipPeVerify]
	public class CoreLibraryUsedAssemblyAttributesAreKept
	{
		public static void Main ()
		{
			// Use something from System so that the entire reference isn't linked away
			var system = new Timer ();

			// use one of the attribute types so that it is marked
			var tmp = typeof (AssemblyDescriptionAttribute).ToString ();
		}
	}
}