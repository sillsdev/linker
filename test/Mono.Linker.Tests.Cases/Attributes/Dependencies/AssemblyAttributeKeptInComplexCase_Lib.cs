// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.Attributes.Dependencies
{
	public class AssemblyAttributeKeptInComplexCase_Lib
	{
		public class OtherAssemblyAttribute : Attribute
		{
		}

		public static void MethodThatWillBeUsed ()
		{
		}
	}
}
