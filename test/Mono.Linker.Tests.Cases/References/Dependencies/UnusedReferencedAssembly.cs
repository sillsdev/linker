// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.References.Dependencies
{
	public class UnusedReferencedAssembly
	{
		public UnusedReferencedAssembly ()
		{
			var _ = new UnusedReferencedFromCopyAssembly ();
			var _2 = Type.GetType ("Mono.Linker.Tests.Cases.References.Dependencies.UnusedDynamicallyReferencedFromCopyAssembly, unuseddynamiclibraryfromcopy");
		}
	}
}