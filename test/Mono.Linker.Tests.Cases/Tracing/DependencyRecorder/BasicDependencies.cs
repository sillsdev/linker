// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Tracing.DependencyRecorder
{
	[DependencyRecorded ("System.Void Mono.Linker.Tests.Cases.Tracing.DependencyRecorder.BasicDependencies::Main()", "Mono.Linker.Tests.Cases.Tracing.DependencyRecorder.UsedType")]
	[DependencyRecorded ("System.Void Mono.Linker.Tests.Cases.Tracing.DependencyRecorder.BasicDependencies::Main()", "System.Void Mono.Linker.Tests.Cases.Tracing.DependencyRecorder.UsedType::.ctor()")]
	[DependencyRecorded ("System.Void Mono.Linker.Tests.Cases.Tracing.DependencyRecorder.BasicDependencies::Main()", "System.Void Mono.Linker.Tests.Cases.Tracing.DependencyRecorder.UsedType::UsedMethod()")]
	public class BasicDependencies
	{
		public static void Main ()
		{
			UsedType ut = new UsedType ();
			ut.UsedMethod ();
		}
	}

	[Kept]
	class UsedType
	{
		[Kept]
		public UsedType ()
		{
		}

		[Kept]
		public void UsedMethod ()
		{
		}
	}
}
