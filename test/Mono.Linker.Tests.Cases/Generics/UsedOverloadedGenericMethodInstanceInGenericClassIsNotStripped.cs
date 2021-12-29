// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Generics
{
	public class UsedOverloadedGenericMethodInstanceInGenericClassIsNotStripped
	{
		public static void Main ()
		{
			B<int>.Method (1);
		}

		class B<TBase>
		{
			public static void Method<T> (T value)
			{
			}

			[Kept]
			public static void Method (TBase value)
			{
			}
		}
	}
}