// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.Attributes.OnlyKeepUsed.Dependencies
{
	public class UnusedAttributeWithTypeForwarderIsRemoved_LibAttribute : Attribute
	{
		public UnusedAttributeWithTypeForwarderIsRemoved_LibAttribute (string arg)
		{
		}
	}

	public class UnusedAttributeWithTypeForwarderIsRemoved_OtherUsedClass
	{
		public static void UsedMethod ()
		{
		}
	}
}
