// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.LinkXml
{
	[SetupLinkerDescriptorFile ("UnusedInterfaceTypeOnTypeWithPreserveAllIsKept.xml")]
	public class UnusedInterfaceTypeOnTypeWithPreserveAllIsKept
	{
		public static void Main ()
		{
		}

		[Kept]
		interface IFoo
		{
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptInterface (typeof (IFoo))]
		class Bar : IFoo
		{
		}
	}
}