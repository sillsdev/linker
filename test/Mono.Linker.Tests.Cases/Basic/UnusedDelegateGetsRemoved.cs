// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.Basic
{
	class UnusedDelegateGetsRemoved
	{
		static void Main ()
		{
		}

		public delegate void Foo ();
	}
}
