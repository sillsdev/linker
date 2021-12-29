// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Attributes
{
	class AttributeOnUsedPropertyIsKept
	{
		public static void Main ()
		{
			var val = new A ().Field;
		}

		[KeptMember (".ctor()")]
		[KeptMember ("get_Field()")]
		class A
		{
			[Kept]
			[KeptBackingField]
			[KeptAttributeAttribute (typeof (FooAttribute))]
			[Foo]
			public int Field { get; set; }
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptBaseType (typeof (System.Attribute))]
		class FooAttribute : Attribute
		{
		}
	}
}