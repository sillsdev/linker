// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Tracing.Individual
{

	[SetupLinkerArgument ("--dump-dependencies")]
	[SetupLinkerArgument ("--dependencies-file", "linker-dependencies.xml")]
	public class CanDumpDependenciesToUncompressedXml
	{
		public static void Main ()
		{
		}
	}
}
