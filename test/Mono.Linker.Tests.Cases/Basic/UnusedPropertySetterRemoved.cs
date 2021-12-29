// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Basic
{
	class UnusedPropertySetterRemoved
	{
		public static void Main ()
		{
			var val = new UnusedPropertySetterRemoved.B ().PartiallyUsed;
		}

		[KeptMember (".ctor()")]
		class B
		{
			[Kept] // FIXME: Should be removed
			[KeptBackingField]
			public int PartiallyUsed { [Kept] get; set; }
		}
	}
}