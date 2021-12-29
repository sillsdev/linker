// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.CommandLine
{
	[SetupLinkerArgument ("--verbose", "--invalidArgument")]
	[LogContains ("Unrecognized command-line option")]
	[NoLinkedOutput]
	public class InvalidArguments
	{
		public static void Main ()
		{
		}
	}
}
