// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.UnreachableBody
{
	[SetupLinkerArgument ("--enable-opt", "unreachablebodies")]
	public class OverrideOfAbstractIsStubbedWithUnusedInterface
	{
		public static void Main ()
		{
			Base b = HelperToMarkFooAndRequireBase ();
			b.Method ();
		}

		[Kept]
		static Foo HelperToMarkFooAndRequireBase ()
		{
			return null;
		}

		[Kept]
		abstract class Base
		{
			[Kept]
			public abstract void Method ();
		}

		[Kept]
		[KeptBaseType (typeof (Base))]
		class Foo : Base, IBar
		{
			[Kept]
			[ExpectBodyModified]
			public override void Method ()
			{
				UsedByOverride ();
			}

			void UsedByOverride ()
			{
			}
		}

		interface IBar
		{
			void Method ();
		}
	}
}