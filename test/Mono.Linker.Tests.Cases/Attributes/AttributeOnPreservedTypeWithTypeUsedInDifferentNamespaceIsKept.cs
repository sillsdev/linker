// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace NamespaceForAttributeOnPreservedTypeWithTypeUsedInDifferentNamespaceIsKept
{
	[Kept]
	class A
	{
		public A ()
		{
		}
	}
}

namespace Mono.Linker.Tests.Cases.Attributes
{
	[Foo (typeof (NamespaceForAttributeOnPreservedTypeWithTypeUsedInDifferentNamespaceIsKept.A))]
	[KeptAttributeAttribute (typeof (FooAttribute))]
	class AttributeOnPreservedTypeWithTypeUsedInDifferentNamespaceIsKept
	{
		public static void Main ()
		{
		}

		[KeptBaseType (typeof (System.Attribute))]
		class FooAttribute : Attribute
		{
			[Kept]
			public FooAttribute (Type val)
			{
			}
		}

		// This A is not used and should be removed
		class A
		{
		}
	}
}