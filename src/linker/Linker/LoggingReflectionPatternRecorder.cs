// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// © .NET Foundation and contributions

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Mono.Linker
{
	class LoggingReflectionPatternRecorder : IReflectionPatternRecorder
	{
		private readonly LinkContext _context;

		public LoggingReflectionPatternRecorder (LinkContext context)
		{
			_context = context;
		}

		public void RecognizedReflectionAccessPattern (ICustomAttributeProvider? source, Instruction? sourceInstruction, IMetadataTokenProvider accessedItem)
		{
			// Do nothing - there's no logging for successfully recognized patterns
		}

		public void UnrecognizedReflectionAccessPattern (in MessageOrigin origin, ICustomAttributeProvider? source, Instruction? sourceInstruction, IMetadataTokenProvider accessedItem, string message, int messageCode)
		{
			_context.LogWarning (message, messageCode, origin, MessageSubCategory.TrimAnalysis);
		}
	}
}
