﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.Attributes.OnlyKeepUsed.Dependencies
{
	public class AttributeDefinedAndUsedInOtherAssemblyIsKept_Lib
	{
		public static void UseTheAttributeType ()
		{
			var str = typeof (FooAttribute).ToString ();
		}

		public class FooAttribute : Attribute
		{
		}
	}
}
