// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Generics
{
	public class UsedOverloadedGenericMethodInGenericClassIsNotStripped
	{
		public static void Main ()
		{
			B<int>.Method (true);
		}

		class B<TBase>
		{
			[Kept]
			public static void Method<T> (T value)
			{
			}

			public static void Method (TBase value)
			{
			}
		}
	}
}