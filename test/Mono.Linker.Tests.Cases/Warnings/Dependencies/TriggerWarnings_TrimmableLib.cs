// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

[assembly: AssemblyMetadata ("IsTrimmable", "True")]

namespace Mono.Linker.Tests.Cases.Warnings.Dependencies
{
	public class TriggerWarnings_TrimmableLib
	{
		public static void Main ()
		{
			RequirePublicMethods (UnknownType ());
			RUCIntentional ();
		}

		static Type UnknownType () => null;

		static void RequirePublicMethods ([DynamicallyAccessedMembers (DynamicallyAccessedMemberTypes.PublicMethods)] Type type) { }

		[RequiresUnreferencedCode ("RUC warning left in the trimmable assembly.")]
		static void RUCIntentional () { }
	}
}
