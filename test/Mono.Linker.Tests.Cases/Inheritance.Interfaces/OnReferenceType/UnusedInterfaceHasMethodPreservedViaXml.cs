// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType
{
	[SetupLinkerDescriptorFile ("UnusedInterfaceHasMethodPreservedViaXml.xml")]
	public class UnusedInterfaceHasMethodPreservedViaXml
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

		interface IBar
		{
			void Bar ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptInterface (typeof (IFoo))]
		class A : IBar, IFoo
		{
			[Kept]
			public void Foo ()
			{
			}

			[Kept]
			public void Bar ()
			{
			}
		}
	}
}