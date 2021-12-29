// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

#if RootLibraryInternalsWithIVT
[assembly: InternalsVisibleToAttribute ("somename")]

[assembly: KeptAttributeAttribute (typeof (InternalsVisibleToAttribute))]
#endif

namespace Mono.Linker.Tests.Cases.Libraries
{
	[Kept]
	[KeptMember (".ctor()")]
	[SetupLinkerLinkPublicAndFamily]
	[Define ("RootLibraryInternalsWithIVT")]
	public class RootLibraryInternalsWithIVT
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

		[Kept]
		internal void UnunsedInternalMethod ()
		{
		}

		private void UnusedPrivateMethod ()
		{
		}
	}

#if RootLibraryInternalsWithIVT
	[Kept]
	internal interface InternalIface
	{
		[Kept]
		void Foo ();
	}
#endif
}
