// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.TestFramework.Dependencies
{
	public class VerifyAttributesInAssemblyWorks_Base
	{
		public class ForAssertingKeptAttribute : Attribute
		{
		}

		public class ForAssertingRemoveAttribute : Attribute
		{
		}
	}
}