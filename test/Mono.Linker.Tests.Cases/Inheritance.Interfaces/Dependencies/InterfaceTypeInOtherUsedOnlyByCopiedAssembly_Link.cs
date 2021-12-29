// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.Dependencies
{
	public class InterfaceTypeInOtherUsedOnlyByCopiedAssembly_Link
	{
		public interface IFoo
		{
			void Method ();
		}
	}
}