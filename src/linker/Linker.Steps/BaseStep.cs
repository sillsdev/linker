// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// © .NET Foundation and contributions

using System;
using System.Diagnostics;
using Mono.Cecil;

namespace Mono.Linker.Steps
{

	public abstract class BaseStep : IStep
	{

		private LinkContext? _context;

		public LinkContext Context {
			get {
				Debug.Assert (_context != null);
				return _context;
			}
		}

		public AnnotationStore Annotations {
			get { return Context.Annotations; }
		}

		public Tracer Tracer {
			get { return Context.Tracer; }
		}

		public MarkingHelpers MarkingHelpers => Context.MarkingHelpers;

		public void Process (LinkContext context)
		{
			_context = context;

			if (!ConditionToProcess ())
				return;

			Process ();

			foreach (AssemblyDefinition assembly in context.GetAssemblies ()) {
				try {
					ProcessAssembly (assembly);
				} catch (Exception e) {
					throw new InternalErrorException ($"Step '{GetType ().Name}' failed when processing assembly '{assembly.FullName}'.", e);
				}
			}

			EndProcess ();
		}

		protected virtual bool ConditionToProcess ()
		{
			return true;
		}

		protected virtual void Process ()
		{
		}

		protected virtual void EndProcess ()
		{
		}

		protected virtual void ProcessAssembly (AssemblyDefinition assembly)
		{
		}
	}
}
