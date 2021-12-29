// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.References.Dependencies
{
	public class WithLinked_Attrs
	{
		public enum FooEnum
		{
			One,
			Two,
			Three
		}
		public class MethodAttribute : Attribute
		{
		}

		public class MethodWithEnumValueAttribute : Attribute
		{
			public MethodWithEnumValueAttribute (FooEnum value, Type t)
			{
			}
		}

		public class FieldAttribute : Attribute
		{
		}

		public class EventAttribute : Attribute
		{
		}

		public class PropertyAttribute : Attribute
		{
		}

		public class TypeAttribute : Attribute
		{
		}

		public class ParameterAttribute : Attribute
		{
		}
	}
}