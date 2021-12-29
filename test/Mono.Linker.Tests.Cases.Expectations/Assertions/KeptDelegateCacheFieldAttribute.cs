// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.Expectations.Assertions
{
	[AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = true)]
	public class KeptDelegateCacheFieldAttribute : KeptAttribute
	{
		public KeptDelegateCacheFieldAttribute (string uniquePartOfName)
		{
			if (string.IsNullOrEmpty (uniquePartOfName))
				throw new ArgumentNullException (nameof (uniquePartOfName));
		}
	}
}
