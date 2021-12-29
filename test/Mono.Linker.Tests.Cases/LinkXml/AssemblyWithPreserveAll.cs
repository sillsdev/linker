// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.LinkXml
{
	[KeptMember (".ctor()")]
	[SetupLinkerDescriptorFile ("AssemblyWithPreserveAll.xml")]
	public class AssemblyWithPreserveAll
	{
		public static void Main ()
		{
		}

		[Kept]
		[KeptMember (".ctor()")]
		class UnusedType
		{
			[Kept]
			public int UnusedField;

			[Kept]
			[KeptBackingField]
			public int UnusedProperty { [Kept] get; [Kept] set; }

			[Kept]
			public void UnusedMethod ()
			{
			}

			[Kept]
			[KeptMember (".ctor()")]
			class UnusedNestedType
			{
			}
		}
	}
}