// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.UnreachableBody.Dependencies
{
	public class OtherAssembly
	{
		public static void UnusedSanityCheck ()
		{
		}

		public class Foo
		{
			public void Method ()
			{
				UsedByMethod ();
			}

			void UsedByMethod ()
			{
			}
		}
	}
}