// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.LinkXml.FeatureExclude
{
	[TestCaseRequirements (TestRunCharacteristics.TargetingNetFramework, "--exclude-feature is not supported on .NET Core")]
	[SetupLinkerArgument ("--exclude-feature", "one")]
	[SetupLinkerDescriptorFile ("OnField.xml")]
	public class OnField
	{
		public static void Main ()
		{
		}

		private int _featureOne;

		[Kept]
		private int _featureTwo;
	}
}
