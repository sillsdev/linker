// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.DataFlow
{
	public class DynamicDependencyDataflow
	{
		public static void Main ()
		{
			DynamicDependencyFrom ();
		}

		[Kept]
		[KeptAttributeAttribute (typeof (DynamicallyAccessedMembersAttribute))]
		[DynamicallyAccessedMembers (DynamicallyAccessedMemberTypes.PublicMethods)]
		static Type TypeWithPublicMethods;

		[Kept]
		[UnrecognizedReflectionAccessPattern (typeof (Type), "GetField", new Type[] { typeof (string) }, messageCode: "IL2080")]
		[DynamicDependency ("DynamicDependencyTo")]
		static void DynamicDependencyFrom ()
		{
			_ = TypeWithPublicMethods.GetField ("f");
		}

		[Kept]
		[UnrecognizedReflectionAccessPattern (typeof (Type), "GetProperty", new Type[] { typeof (string) }, messageCode: "IL2080")]
		static void DynamicDependencyTo ()
		{
			_ = TypeWithPublicMethods.GetProperty ("p");
		}
	}
}
