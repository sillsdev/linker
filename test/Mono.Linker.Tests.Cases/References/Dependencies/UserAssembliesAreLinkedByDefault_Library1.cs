// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Mono.Linker.Tests.Cases.References.Dependencies
{
	public class UserAssembliesAreLinkedByDefault_Library1
	{
		public void UsedMethod ()
		{
			Console.WriteLine ("Used");
		}

		public void UnusedMethod ()
		{
			Console.WriteLine ("NotUsed");
		}
	}
}
