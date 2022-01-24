// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.CompilerServices
{
	[AttributeUsage (AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Field, AllowMultiple = true)]
	public sealed class PreserveDependencyAttribute : Attribute
	{
		public PreserveDependencyAttribute (string memberSignature)
		{
		}

		public PreserveDependencyAttribute (string memberSignature, string typeName)
		{
		}

		public PreserveDependencyAttribute (string memberSignature, string typeName, string assembly)
		{
		}

		public string Condition { get; set; }
	}
}