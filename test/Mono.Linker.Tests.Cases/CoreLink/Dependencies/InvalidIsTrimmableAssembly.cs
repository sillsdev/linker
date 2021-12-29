// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;

[assembly: AssemblyMetadata ("IsTrimmable", "true")]
[assembly: AssemblyMetadata ("IsTrimmable", "False")]

namespace Mono.Linker.Tests.Cases.CoreLink.Dependencies
{
	public static class InvalidIsTrimmableAssembly
	{
		public static void Used ()
		{
		}

		public static void Unused ()
		{
		}
	}
}