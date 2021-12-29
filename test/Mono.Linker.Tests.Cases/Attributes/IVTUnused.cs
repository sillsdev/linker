// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

#if IVT
[assembly: InternalsVisibleTo ("missing")]
[assembly: InternalsVisibleTo ("test-with-key, PublicKey=00240000")]

#endif

namespace Mono.Linker.Tests.Cases.Attributes
{
	[Define ("IVT")]
	class IVTUnused
	{
		static void Main ()
		{
		}
	}
}
