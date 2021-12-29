// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Inheritance.VirtualMethods
{
	public class UnusedVirtualMethodRemoved
	{
		public static void Main ()
		{
			var tmp = new B ();
		}

		[KeptMember (".ctor()")]
		class Base
		{
			public virtual void Call ()
			{
			}
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptBaseType (typeof (Base))]
		class B : Base
		{
			public override void Call ()
			{
			}
		}
	}
}