using FrooxEngine;
using FrooxEngine.LogiX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExpressionLogix.Generators.Analysis
{
    internal static class LogixData
    {
        public static readonly Assembly FrooxEngine = typeof(LogixNode).Assembly;

        public static readonly Type[] InputTypes = FrooxEngine.GetTypes()
            .Where(type => !type.IsAbstract && type.Namespace == "FrooxEngine.LogiX.Input" && type.Name.EndsWith("Input"))
            .ToArray();

        public static readonly Dictionary<string, Type[]> OverloadedNodes = groupOverloads();

        private static Dictionary<string, Type[]> groupOverloads()
        {
            return FrooxEngine.GetTypes()
                .Select(type => new { Type = type, Overload = type.GetCustomAttribute<NodeOverload>() })
                .Where(type => type.Overload != null)
                .GroupBy(type => type.Overload.FunctionName)
                .ToDictionary(group => group.Key, group => group.Select(type => type.Type).ToArray());
        }
    }
}