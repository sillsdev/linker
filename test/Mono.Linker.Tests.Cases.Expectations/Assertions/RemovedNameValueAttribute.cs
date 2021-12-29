﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.Expectations.Assertions
{
	/// <summary>
	/// Verifies that name of the member is removed
	/// </summary>
	[AttributeUsage (AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	public class RemovedNameValueAttribute : BaseExpectedLinkedBehaviorAttribute
	{
	}
}
