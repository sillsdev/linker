// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnValueType
{
	[SetupLinkerDescriptorFile ("UnusedExplicitInterfaceHasMethodPreservedViaXml.xml")]
	public class UnusedExplicitInterfaceHasMethodPreservedViaXml
	{
		public static void Main ()
		{
			IFoo i = new A ();
			i.Foo ();
		}

		[Kept]
		interface IFoo
		{
			[Kept]
			void Foo ();
		}

		[Kept]
		interface IBar
		{
			[Kept]
			void Bar ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptInterface (typeof (IFoo))]
		[KeptInterface (typeof (IBar))]
		struct A : IBar, IFoo
		{
			[Kept]
			void IFoo.Foo ()
			{
			}

			[Kept]
			void IBar.Bar ()
			{
			}
		}
	}
}