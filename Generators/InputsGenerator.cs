using Generators.Analysis;
using FrooxEngine;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Generators
{
    [Generator]
    public class InputsGenerator : ISourceGenerator
    {
        private const string classTemplate =
@"using BaseX;
using FrooxEngine;
using FrooxEngine.LogiX;
using FrooxEngine.LogiX.Input;
using System;

namespace ExpressionLogix
{{
    public static class LogixInputs
    {{
{0}
    }}
}}";

        private static readonly Type syncListType = typeof(SyncList<>);

        public void Execute(GeneratorExecutionContext context)
        {
            var builder = new StringBuilder();

            foreach (var inputType in LogixData.InputTypes)
            {
                //var fields = inputType.GetFields(BindingFlags.NonPublic);

                //var operandsField = fields.FirstOrDefault(field => field.Name == "Operands" && field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == syncListType);

                //if (operandsField != null)
                //{
                //}

                var valueField = inputType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(field => field.Name.ToLower().EndsWith("value"));

                if (valueField == null)
                    continue;

                var type = valueField.FieldType.IsGenericType ? valueField.FieldType.GetGenericArguments()[0] : valueField.FieldType.BaseType.GetGenericArguments()[0];

                builder.AppendLine($"        public static IElementContent<{type.Name}> CreateInputNode(this Slot slot, {type.Name} value)");
                builder.AppendLine("        {");

                builder.AppendLine($"            var inputNode = slot.AttachComponent<{inputType.Name}>();");

                if (valueField.IsPublic)
                    builder.AppendLine($"            inputNode.{valueField.Name}.Value = value;");
                else
                    builder.AppendLine($"            inputNode.TryGetField<{type.Name}>(\"{valueField.Name}\").Value = value;");

                builder.AppendLine();
                builder.AppendLine("            return inputNode;");

                builder.AppendLine("        }");
                builder.AppendLine();
            }

            context.AddSource("LogixInputs.g.cs", string.Format(classTemplate, builder.ToString()));
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}