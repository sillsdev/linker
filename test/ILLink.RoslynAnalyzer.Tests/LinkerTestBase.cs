// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ILLink.RoslynAnalyzer.Tests
{
	public abstract class LinkerTestBase : TestCaseUtils
	{
		protected abstract string TestSuiteName { get; }

		private static readonly (string, string)[] MSBuildProperties = UseMSBuildProperties (
			MSBuildPropertyOptionNames.EnableTrimAnalyzer,
			MSBuildPropertyOptionNames.EnableSingleFileAnalyzer,
			MSBuildPropertyOptionNames.EnableAOTAnalyzer);

		protected Task RunTest ([CallerMemberName] string testName = "")
		{
			return RunTestFile (TestSuiteName, testName, MSBuildProperties);
		}
	}
}