// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.Inheritance.AbstractClasses.Dependencies;

namespace Mono.Linker.Tests.Cases.Inheritance.AbstractClasses.NotKeptCtor
{
	[SetupLinkerAction ("copy", "base")]
	[SetupCompileBefore ("base.dll", new[] { typeof (TypeWithBaseInCopiedAssembly_Base) })]
	[KeptMemberInAssembly ("base.dll", typeof (TypeWithBaseInCopiedAssembly_Base.Base), "Method()")]
	public class NeverInstantiatedTypeWithBaseInCopiedAssembly
	{
		public static void Main ()
		{
			Helper (null);
		}

		[Kept]
		static void Helper (Foo arg)
		{
		}

		[Kept]
		[KeptBaseType (typeof (TypeWithBaseInCopiedAssembly_Base.Base))]
		class Foo : TypeWithBaseInCopiedAssembly_Base.Base
		{
			[Kept]
			public override void Method ()
			{
			}
		}
	}
}