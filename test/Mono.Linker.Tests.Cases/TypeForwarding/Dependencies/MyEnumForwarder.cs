// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.TypeForwarding.Dependencies;

[assembly: TypeForwardedTo (typeof (MyEnum))]

namespace Mono.Linker.Tests.Cases.TypeForwarding.Dependencies
{
    public class UsedToReferenceForwarderAssembly
    {
    }
}