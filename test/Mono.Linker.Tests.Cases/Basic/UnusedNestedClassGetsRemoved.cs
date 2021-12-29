// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


namespace Mono.Linker.Tests.Cases.Basic
{
	public class UnusedNestedClassGetsRemoved
	{
		public static void Main ()
		{
		}

		class Unused
		{
		}
	}
}