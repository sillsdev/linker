// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Attributes.Debugger
{
#if NETCOREAPP
	[SetupLinkAttributesFile ("DebuggerAttributesRemoved.xml")]
#else
	[SetupLinkerTrimMode ("link")]
	[SetupLinkerKeepDebugMembers ("false")]

	// Can be removed once this bug is fixed https://bugzilla.xamarin.com/show_bug.cgi?id=58168
	[SkipPeVerify (SkipPeVerifyForToolchian.Pedump)]
#endif
	public class DebuggerDisplayAttributeOnTypeThatIsNotUsed
	{
		public static void Main ()
		{
		}

		[DebuggerDisplay ("{Property}")]
		class Foo
		{
			public int Property { get; set; }
		}
	}
}