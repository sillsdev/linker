// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Substitutions
{
	[SetupCompileResource ("Dependencies/EmbeddedSubstitutionsNotProcessedWithIgnoreSubstitutionsAndRemoved.xml", "ILLink.Substitutions.xml")]
	[IgnoreSubstitutions (true)]
	[StripSubstitutions (true)]
	[RemovedResourceInAssembly ("test.exe", "ILLink.Substitutions.xml")]
	public class EmbeddedSubstitutionsNotProcessedWithIgnoreSubstitutionsAndRemoved
	{
		public static void Main ()
		{
			ConvertToThrowMethod ();
		}

		[Kept]
		[ExpectedInstructionSequence (new[] {
			"nop",
			"ret"
		})]
		public static void ConvertToThrowMethod ()
		{
		}
	}
}
