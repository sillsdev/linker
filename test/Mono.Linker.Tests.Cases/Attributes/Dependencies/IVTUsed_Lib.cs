// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

#if IVT
[assembly: InternalsVisibleTo ("test")]
#endif

namespace Mono.Linker.Tests.Cases.Attributes.Dependencies
{
	public class External
	{
		internal static void InternalMethod ()
		{
		}

		internal static void UnusedMethod ()
		{
		}

		public static void PublicMethod ()
		{
		}
	}
}
