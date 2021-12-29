// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.TypeForwarding.Dependencies
{
#if INCLUDE_REFERENCE_IMPL
	public class AnotherLibrary<T>
	{
		public string Prop { get; set; }
	}	
#endif
}
