// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Interop.PInvoke
{
	[KeptModuleReference ("Unused")]
	class DefaultConstructorOfReturnTypeIsNotRemoved
	{
		public static void Main ()
		{
			var a = SomeMethod ();
		}

		class A
		{
			[Kept]
			public A ()
			{
			}
		}

		[Kept]
		[DllImport ("Unused")]
		private static extern A SomeMethod ();
	}
}