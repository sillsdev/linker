// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Metadata
{
	public class NamesAreRemoved
	{
		public static void Main ()
		{
			var n = new N (5);
			N.Foo (null, 1);
		}

		class N
		{
			[Kept]
			public N ([RemovedNameValueAttribute] int arg)
			{
			}

			[Kept]
			public static void Foo ([RemovedNameValueAttribute] string str, [RemovedNameValueAttribute] long _)
			{
			}
		}
	}
}
