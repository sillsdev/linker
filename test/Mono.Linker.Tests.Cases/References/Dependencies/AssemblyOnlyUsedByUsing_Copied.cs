// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// This is what triggers the behavior difference between Roslyn and mcs.  Roslyn will keep the reference
// to this assembly because of this whereas mcs will not
using ImportantForBug = Mono.Linker.Tests.Cases.References.Dependencies.AssemblyOnlyUsedByUsing_Lib;

namespace Mono.Linker.Tests.Cases.References.Dependencies
{
	public class AssemblyOnlyUsedByUsing_Copied
	{
		public static void UsedToKeepReference ()
		{
		}

		private static void Unused ()
		{
		}
	}
}