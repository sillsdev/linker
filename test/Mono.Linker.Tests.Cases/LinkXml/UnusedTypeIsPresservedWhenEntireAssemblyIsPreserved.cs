// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.LinkXml
{

	[KeptMember (".ctor()")]
	[SetupLinkerDescriptorFile ("UnusedTypeIsPresservedWhenEntireAssemblyIsPreserved.xml")]
	class UnusedTypeIsPresservedWhenEntireAssemblyIsPreserved
	{
		public static void Main ()
		{
		}

		[Kept]
		[KeptMember (".ctor()")]
		class Unused
		{
			[Kept]
			void Foo ()
			{
			}
		}
	}
}
