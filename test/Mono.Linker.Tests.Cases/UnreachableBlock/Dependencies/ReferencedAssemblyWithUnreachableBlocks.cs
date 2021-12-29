// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.UnreachableBlock.Dependencies
{
	public class AssemblyWithUnreachableBlocks
	{
		public AssemblyWithUnreachableBlocks ()
		{
			TestProperty ();
		}

		static void TestProperty ()
		{
			if (PropBool)
				NeverReached ();
		}

		static void NeverReached () { }

		static bool PropBool {
			get => false;
		}
	}
}