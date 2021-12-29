// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using Mono.Linker.Tests.Cases.Attributes.OnlyKeepUsed.Dependencies;

[assembly: TypeForwardedTo (typeof (UnusedAttributeWithTypeForwarderIsRemoved_LibAttribute))]
[assembly: TypeForwardedTo (typeof (UnusedAttributeWithTypeForwarderIsRemoved_OtherUsedClass))]
