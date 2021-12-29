﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Libraries
{
	[SetupLinkerLinkPublicAndFamily]
	[SetupCompileAsLibrary]
	[Kept]
	[KeptMember (".ctor()")]
	public class CanLinkPublicApisOfLibrary
	{
		[Kept]
		public static void Main ()
		{
		}

		[Kept]
		public void UnusedPublicMethod ()
		{
		}

		[Kept]
		protected void UnusedProtectedMethod ()
		{
		}

		[Kept]
		protected internal void UnusedProtectedInternalMethod ()
		{
		}

		internal void UnunsedInternalMethod ()
		{
		}

		private void UnusedPrivateMethod ()
		{
		}
	}
}