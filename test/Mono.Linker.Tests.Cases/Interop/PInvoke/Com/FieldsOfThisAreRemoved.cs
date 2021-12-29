// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Interop.PInvoke.Com
{
	class FieldsOfThisAreRemoved
	{
		public static void Main ()
		{
			new A ().SomeMethod ();
		}

		[Kept]
		[KeptMember (".ctor()")]
		[KeptAttributeAttribute (typeof (GuidAttribute))]
		[ComImport]
		[Guid ("D7BB1889-3AB7-4681-A115-60CA9158FECA")]
		class A
		{
			private int field;

			[Kept]
			[MethodImpl (MethodImplOptions.InternalCall)]
			public extern void SomeMethod ();
		}
	}
}
