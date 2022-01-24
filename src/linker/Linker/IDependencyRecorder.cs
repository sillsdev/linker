// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mono.Linker
{
	/// <summary>
	/// Abstraction exposed by the linker (mostly MarkStep, but not only) - it will call this interface
	/// every time it finds a dependency between two parts of the dependency graph.
	/// </summary>
	public interface IDependencyRecorder
	{
		/// <summary>
		/// Reports a dependency detected by the linker.
		/// </summary>
		/// <param name="source">The source of the dependency (for example the caller method).</param>
		/// <param name="target">The target of the dependency (for example the callee method).</param>
		/// <param name="marked">true if the target is also marked by the MarkStep.</param>
		/// <remarks>The source and target are typically Cecil metadata objects (MethodDefinition, TypeDefinition, ...)
		/// but they can also be the linker steps or really any other object.</remarks>
		void RecordDependency (object source, object target, bool marked);

		/// <summary>
		/// Reports a dependency detected by the linker, with a well-defined reason for keeping the dependency.
		/// </summary>
		/// <param name="target">The target of the dependency (for example the callee method).</param>
		/// <param name="reason">The reason for including the target dependency (for example a direct call from another method).</param>
		/// <param name="marked">true if the target is also marked by the MarkStep as a result of this particular reason.</param>
		/// <remarks>The target is typically a Cecil metadata object (MethodDefinition, TypeDefinition, ...)
		/// but can also be the linker steps or really any other object. "marked" may be false for a target that
		/// is still marked for some other reason.</remarks>
		void RecordDependency (object target, in DependencyInfo reason, bool marked);
	}
}
