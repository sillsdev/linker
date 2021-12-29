// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Attributes
{
	class AttributeOnUsedFieldIsKept
	{
		public static void Main ()
		{
			var val = new A ().field;
		}

		[KeptMember (".ctor()")]
		class A
		{
			[Kept]
			[KeptAttributeAttribute (typeof (FooAttribute))]
			[Foo]
			public int field;
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptBaseType (typeof (System.Attribute))]
		class FooAttribute : Attribute
		{
		}
	}
}