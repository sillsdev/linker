// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.LinkXml.Dependencies.EmbeddedLinkXmlPreservesAdditionalAssemblyWithOverriddenMethod
{
	public class Library2 : Base
	{
		public override void VirtualMethodFromBase ()
		{
		}
	}
}