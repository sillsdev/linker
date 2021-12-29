// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.LinkAttributes.Dependencies;

[assembly: TestRemove]
[assembly: TestDontRemove]

namespace Mono.Linker.Tests.Cases.LinkAttributes.Dependencies
{
	public class ReferencedAssemblyWithAttributes
	{
	}
}
