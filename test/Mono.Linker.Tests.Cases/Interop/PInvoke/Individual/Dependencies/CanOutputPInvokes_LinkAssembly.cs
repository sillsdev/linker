// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace Mono.Linker.Tests.Cases.Interop.PInvoke.Individual.Dependencies
{
	public class CanOutputPInvokes_LinkAssembly
	{
		[DllImport ("lib_linkassembly")]
		private static extern CanOutputPInvokes_LinkAssembly UnreachableWhenLinked ();
	}
}