// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.VirtualMethods
{
	class UnusedTypeWithOverrideOfVirtualMethodIsRemoved
	{
		public static void Main ()
		{
			new Base ().Call ();
		}

		[KeptMember (".ctor()")]
		class Base
		{
			[Kept]
			public virtual void Call ()
			{
			}
		}

		class B : Base
		{
			public override void Call ()
			{
			}
		}
	}
}