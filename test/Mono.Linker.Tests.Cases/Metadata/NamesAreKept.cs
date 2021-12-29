// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Metadata
{
	[SetupLinkerArgument ("--keep-metadata", "parametername")]
	[VerifyMetadataNames]
	public class NamesAreKept
	{
		public static void Main ()
		{
			var n = new N (5);
			N.Foo ("aa");
		}

		class N
		{
			[Kept]
			public N (int arg)
			{
			}

			[Kept]
			public static void Foo (string str)
			{
			}
		}
	}
}
