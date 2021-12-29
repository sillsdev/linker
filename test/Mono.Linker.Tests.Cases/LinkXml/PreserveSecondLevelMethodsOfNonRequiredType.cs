// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.LinkXml
{
	[SetupLinkerDescriptorFile ("PreserveSecondLevelMethodsOfNonRequiredType.xml")]
	class PreserveSecondLevelMethodsOfNonRequiredType
	{
		public static void Main ()
		{
			new Unused ();
		}

		[Kept]
		class Unused
		{
			[Kept]
			public Unused ()
			{
			}

			[Kept]
			private void PreservedMethod ()
			{
				new SecondLevel (2);
			}
		}

		[Kept]
		class SecondLevel
		{
			[Kept]
			public SecondLevel (int arg)
			{
			}
		}
	}
}