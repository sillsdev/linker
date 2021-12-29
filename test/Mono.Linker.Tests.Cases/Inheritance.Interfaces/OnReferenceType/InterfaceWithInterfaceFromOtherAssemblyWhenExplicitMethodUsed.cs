// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.Inheritance.Interfaces.Dependencies;

namespace Mono.Linker.Tests.Cases.Inheritance.Interfaces.OnReferenceType
{
	[SetupCompileBefore ("library.dll", new[] { "../Dependencies/InterfaceWithInterfaceFromOtherAssemblyWhenExplicitMethodUsed_Lib.cs" })]
	public class InterfaceWithInterfaceFromOtherAssemblyWhenExplicitMethodUsed
	{
		public static void Main ()
		{
			Helper (null);
		}

		[Kept]
		static void Helper (IBar obj)
		{
			var result = ((InterfaceWithInterfaceFromOtherAssemblyWhenExplicitMethodUsed_Lib.IFoo) obj).ExplicitMethod ();
		}

		[Kept]
		[KeptInterface (typeof (InterfaceWithInterfaceFromOtherAssemblyWhenExplicitMethodUsed_Lib.IFoo))]
		interface IBar : InterfaceWithInterfaceFromOtherAssemblyWhenExplicitMethodUsed_Lib.IFoo
		{
		}
	}
}