// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Substitutions
{
	[SetupCompileResource ("Dependencies/EmbeddedSubstitutionsKept.xml", "ILLink.Substitutions.xml")]
	[IgnoreSubstitutions (false)]
	[StripSubstitutions (false)]
	[KeptResource ("ILLink.Substitutions.xml")]
	public class EmbeddedSubstitutionsKept
	{
		public static void Main ()
		{
			ConvertToThrowMethod ();
		}

		[Kept]
		[ExpectedInstructionSequence (new[] {
			"ldstr 'Linked away'",
			"newobj System.Void System.NotSupportedException::.ctor(System.String)",
			"throw",
		})]
		public static void ConvertToThrowMethod ()
		{
		}
	}
}
