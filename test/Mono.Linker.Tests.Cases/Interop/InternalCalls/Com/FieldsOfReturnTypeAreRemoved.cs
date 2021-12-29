﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Interop.InternalCalls.Com
{
	class FieldsOfReturnTypeAreRemoved
	{
		public static void Main ()
		{
			var a = SomeMethod ();
		}

		[Kept]
		[KeptAttributeAttribute (typeof (GuidAttribute))]
		[ComImport]
		[Guid ("D7BB1889-3AB7-4681-A115-60CA9158FECA")]
		class A
		{
			private int field;
		}

		[Kept]
		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern A SomeMethod ();
	}
}
