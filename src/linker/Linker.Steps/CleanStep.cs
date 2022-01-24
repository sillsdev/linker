// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// © .NET Foundation and contributions

using Mono.Cecil;

namespace Mono.Linker.Steps
{

	public class CleanStep : BaseStep
	{

		protected override void ProcessAssembly (AssemblyDefinition assembly)
		{
			if (Annotations.GetAction (assembly) == AssemblyAction.Link)
				CleanAssembly (assembly);
		}

		static void CleanAssembly (AssemblyDefinition asm)
		{
			foreach (TypeDefinition type in asm.MainModule.Types)
				CleanType (type);
		}

		static void CleanType (TypeDefinition type)
		{
			if (type.HasProperties)
				CleanProperties (type);
			if (type.HasEvents)
				CleanEvents (type);

			if (type.HasNestedTypes)
				foreach (var nested in type.NestedTypes)
					CleanType (nested);
		}

		static MethodDefinition? CheckMethod (TypeDefinition type, MethodDefinition method)
		{
			if (method == null)
				return null;

			return type.Methods.Contains (method) ? method : null;
		}

		static void CleanEvents (TypeDefinition type)
		{
			var events = type.Events;

			for (int i = 0; i < events.Count; i++) {
				var evt = events[i];
				evt.AddMethod = CheckMethod (type, evt.AddMethod);
				evt.InvokeMethod = CheckMethod (type, evt.InvokeMethod);
				evt.RemoveMethod = CheckMethod (type, evt.RemoveMethod);

				if (!IsEventUsed (evt))
					events.RemoveAt (i--);
			}
		}

		static bool IsEventUsed (EventDefinition evt)
		{
			return evt.AddMethod != null || evt.InvokeMethod != null || evt.RemoveMethod != null;
		}

		static void CleanProperties (TypeDefinition type)
		{
			var properties = type.Properties;

			for (int i = 0; i < properties.Count; i++) {
				var prop = properties[i];
				prop.GetMethod = CheckMethod (type, prop.GetMethod);
				prop.SetMethod = CheckMethod (type, prop.SetMethod);

				if (!IsPropertyUsed (prop))
					properties.RemoveAt (i--);
			}
		}

		static bool IsPropertyUsed (PropertyDefinition prop)
		{
			return prop.GetMethod != null || prop.SetMethod != null;
		}
	}
}
