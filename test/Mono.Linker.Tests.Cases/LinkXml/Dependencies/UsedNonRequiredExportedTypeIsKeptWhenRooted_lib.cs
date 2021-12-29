// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.LinkXml
{
	public class UsedNonRequiredExportedTypeIsKeptWhenRooted_Used
	{
		public int field;

		public void Method ()
		{
		}
	}

	public class OtherType
	{
		public int field;

		public void Method ()
		{
		}

		public int Property { get; set; }
	}
}