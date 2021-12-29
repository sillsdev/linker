// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.CommandLine
{
	/// <summary>
	/// This test will use only keep used attributes, which is disabled by default, to infer that the rsp file worked
	/// </summary>
	[SetupLinkerResponseFileAttribute ("Dependencies/ResponseFilesWork.rsp")]
	public class ResponseFilesWork
	{
		public static void Main ()
		{
			new Bar ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		[Foo]
		class Bar
		{
		}

		class FooAttribute : Attribute
		{
		}
	}
}