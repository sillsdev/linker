// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace Mono.Linker.Tests.Cases.Attributes.Dependencies
{
	[DynamicInterfaceCastableImplementation]
	public interface IReferencedAssemblyImpl : IReferencedAssembly
	{
		void Foo () { }
	}
}