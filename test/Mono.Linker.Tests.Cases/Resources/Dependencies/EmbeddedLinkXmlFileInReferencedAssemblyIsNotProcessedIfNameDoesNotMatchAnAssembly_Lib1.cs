// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.Resources.Dependencies
{
	public class EmbeddedLinkXmlFileInReferencedAssemblyIsNotProcessedIfNameDoesNotMatchAnAssembly_Lib1
	{
		public static void Used ()
		{
		}

		public static void Unused ()
		{
		}
	}
}