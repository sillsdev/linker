// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Mono.Linker.Tests.Cases.Interop.PInvoke
{
	public class UnusedPInvoke
	{
		public static void Main ()
		{
		}

		[DllImport ("Unused")]
		private static extern void SomeMethod (object a);
	}
}
