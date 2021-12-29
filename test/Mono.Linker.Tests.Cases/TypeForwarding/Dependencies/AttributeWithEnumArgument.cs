// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.TypeForwarding.Dependencies;

#if INCLUDE_FORWARDER
[assembly: TypeForwardedTo (typeof (UsedToReferenceForwarderAssembly))]
#endif

namespace Mono.Linker.Tests.Cases.TypeForwarding.Dependencies
{
	public class AttributeWithEnumArgumentAttribute : Attribute
	{
		public AttributeWithEnumArgumentAttribute (MyEnum arg)
		{
		}
	}

	[AttributeWithEnumArgument (MyEnum.A)]
	public class AttributedType
	{
	}
}