// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.LinkXml.FeatureExclude.Dependencies
{
	public class OnAssembly_Lib2
	{
		public static void UsedSoCompilerDoesntRemoveReference ()
		{
		}

		public class FeatureTwoClass
		{
		}
	}
}
