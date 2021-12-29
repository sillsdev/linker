// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.LinkXml
{
	public class UsedNonRequiredExportedTypeIsKept_Used1
	{
		public int field;

		public void Method ()
		{
		}

		public int Property { get; set; }
	}

	public class UsedNonRequiredExportedTypeIsKept_Used2
	{
		public int field;

		public void Method ()
		{
		}

		public int Property { get; set; }
	}

	public class UsedNonRequiredExportedTypeIsKept_Used3
	{
		public int field;

		public void Method ()
		{
		}

		public int Property { get; set; }
	}
}