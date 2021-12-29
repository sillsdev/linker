// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Attributes.StructLayout
{
	[StructLayout (LayoutKind.Auto)]
	[KeptMember (".ctor()")]
	class AutoClassData
	{
		public int never_used;
		[Kept]
		public int used;
	}

	public class AutoClass
	{
		public static void Main ()
		{
			var c = new AutoClassData ();
			c.used = 1;
		}
	}
}
