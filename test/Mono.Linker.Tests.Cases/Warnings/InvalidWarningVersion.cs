// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Warnings
{
	[SetupLinkerArgument ("--verbose")]
	[SetupLinkerArgument ("--warn", "invalid")]
	[LogContains ("IL1016")]
	[NoLinkedOutput]
	public class InvalidWarningVersion
	{
		public static void Main ()
		{
		}
	}
}
