using ExpressionLogix.Generators.Analysis;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExpressionLogix.Generators
{
    [Generator]
    public class InputsGenerator : ISourceGenerator
    {
        private const string template =
@"using BaseX;
using FrooxEngine;
using System;

namespace ExpressionLogix
{{
    public static partial class LogixValue
    {{
{0}
    }}
}}";

        public void Execute(GeneratorExecutionContext context)
        {
            var builder = new StringBuilder();

            foreach (var inputType in LogixData.InputTypes)
            {
                var valueField = inputType.GetFields(BindingFlags.NonPublic).First(field => field.Name.ToLower().EndsWith("value"));
            }

            context.AddSource("LogixValueInputs.g.cs", string.Format(template, builder.ToString()));
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}