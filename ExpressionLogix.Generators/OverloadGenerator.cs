using ExpressionLogix.Generators.Analysis;
using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExpressionLogix.Generators
{
    [Generator]
    public class OverloadGenerator : ISourceGenerator
    {
        private static readonly string template =
@"using BaseX;
using FrooxEngine;
using System;

namespace ExpressionLogix
{{
    public static class {0}Overloads
    {{
{1}
    }}
}}";

        public void Execute(GeneratorExecutionContext context)
        {
            foreach (var overloadedNode in LogixData.OverloadedNodes)
            {
                var builder = new StringBuilder();
                var function = overloadedNode.Key.Replace(" ", "").Replace("_", "");

                foreach (var overload in overloadedNode.Value.Where(t => !t.ContainsGenericParameters))
                {
                    builder.AppendLine($@"        public static {overload.GetLogixNodeOutputs().Select(output => output.OutputType.Name).FirstOrDefault() ?? "void"} {function}(this {string.Join(", ", overload.GetLogixNodeInputs().Select(input => $"{input.InputType} {input.Name}"))})");
                    builder.AppendLine(@"        {");

                    builder.AppendLine(@"        }");
                    builder.AppendLine();
                }

                var source = string.Format(template, function, builder.ToString());
                context.AddSource($"{function}Overloads.g.cs", source);
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
#if DEBUG
            if (!Debugger.IsAttached)
            {
                //Debugger.Launch();
            }
            Debug.WriteLine("Initalize code generator");
#endif
        }
    }
}