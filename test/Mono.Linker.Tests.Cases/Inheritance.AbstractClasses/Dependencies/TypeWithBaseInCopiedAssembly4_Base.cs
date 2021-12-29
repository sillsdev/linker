// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker.Tests.Cases.Inheritance.AbstractClasses.Dependencies
{
	public class TypeWithBaseInCopiedAssembly4_Base
	{
		public abstract class Base
		{
			public abstract void Method ();
		}

		public class Base2 : Base
		{
			public override void Method ()
			{
			}
		}
	}
}