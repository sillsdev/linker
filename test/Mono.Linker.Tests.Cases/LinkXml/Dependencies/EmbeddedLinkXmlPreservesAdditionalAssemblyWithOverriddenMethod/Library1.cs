// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.LinkXml.Dependencies.EmbeddedLinkXmlPreservesAdditionalAssemblyWithOverriddenMethod
{
	public class Library1 : Base
	{
		public override void VirtualMethodFromBase ()
		{
		}
	}

	/// <summary>
	/// This is here to confirm that derived types in the same assembly as the embedded resource are correctly taken into
	/// consideration
	/// </summary>
	public class Library1Secondary : Base
	{
		public override void VirtualMethodFromBase ()
		{
		}
	}
}