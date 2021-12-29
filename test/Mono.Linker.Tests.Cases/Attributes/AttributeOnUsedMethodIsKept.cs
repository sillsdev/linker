// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Attributes
{
	class AttributeOnUsedMethodIsKept
	{
		public static void Main ()
		{
			new A ().Method ();
		}

		[KeptMember (".ctor()")]
		class A
		{
			[Foo]
			[Kept]
			[KeptAttributeAttribute (typeof (FooAttribute))]
			public void Method ()
			{
			}
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptBaseType (typeof (System.Attribute))]
		class FooAttribute : Attribute
		{
		}
	}
}