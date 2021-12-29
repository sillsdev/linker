// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.CoreLink.Dependencies
{
	public static class NonTrimmableAssembly
	{
		public static void Used ()
		{
		}

		public static void Unused ()
		{
		}
	}
}