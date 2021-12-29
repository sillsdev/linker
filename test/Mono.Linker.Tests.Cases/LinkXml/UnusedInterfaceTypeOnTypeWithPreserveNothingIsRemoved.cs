// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.LinkXml
{
	[SetupLinkerDescriptorFile ("UnusedInterfaceTypeOnTypeWithPreserveNothingIsRemoved.xml")]
	public class UnusedInterfaceTypeOnTypeWithPreserveNothingIsRemoved
	{
		public static void Main ()
		{
		}

		interface IFoo
		{
		}

		[Kept]
		class Bar : IFoo
		{
		}
	}
}