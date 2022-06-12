using FrooxEngine.LogiX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExpressionLogix.Generators
{
    internal static class LogixNodeHelpers
    {
        private static readonly MethodInfo getLogixNodeInputs = typeof(LogixNode).GetProperty("Inputs", BindingFlags.NonPublic | BindingFlags.Instance).GetGetMethod(true);
        private static readonly MethodInfo getLogixNodeOutputs = typeof(LogixNode).GetProperty("Outputs", BindingFlags.NonPublic | BindingFlags.Instance).GetGetMethod(true);
        private static readonly Dictionary<Type, IInputElement[]> logixNodeInputs = new();
        private static readonly Dictionary<Type, object> logixNodeInstances = new();
        private static readonly Dictionary<Type, IOutputElement[]> logixNodeOutputs = new();

        public static object GetInstance(this Type type)
        {
            if (!logixNodeInstances.TryGetValue(type, out var instance))
            {
                instance = Activator.CreateInstance(type);
                type.GetMethod("InitializeSyncMembers", BindingFlags.NonPublic | BindingFlags.Instance)?.Invoke(instance, Array.Empty<object>());
                logixNodeInstances.Add(type, instance);
            }

            return instance;
        }

        public static IEnumerable<IInputElement> GetLogixNodeInputs(this Type nodeType)
        {
            if (!logixNodeInputs.TryGetValue(nodeType, out var inputs))
            {
                inputs = ((IEnumerable<IInputElement>)getLogixNodeInputs.Invoke(nodeType.GetInstance(), Array.Empty<object>())).ToArray();
                logixNodeInputs.Add(nodeType, inputs);
            }

            return inputs;
        }

        public static IEnumerable<IOutputElement> GetLogixNodeOutputs(this Type nodeType)
        {
            if (!logixNodeOutputs.TryGetValue(nodeType, out var outputs))
            {
                outputs = ((IEnumerable<IOutputElement>)getLogixNodeOutputs.Invoke(nodeType.GetInstance(), Array.Empty<object>())).ToArray();
                logixNodeOutputs.Add(nodeType, outputs);
            }

            return outputs;
        }
    }
}