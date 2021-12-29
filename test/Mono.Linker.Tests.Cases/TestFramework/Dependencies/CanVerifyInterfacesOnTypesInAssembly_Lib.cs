// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.TestFramework.Dependencies
{
	public class CanVerifyInterfacesOnTypesInAssembly_Lib
	{
		public interface IFoo
		{
			void Foo ();
		}
		public interface IBar
		{
			void Bar ();
		}

		public class A : IFoo, IBar
		{
			public void Foo ()
			{
			}

			public void Bar ()
			{
			}
		}
	}
}