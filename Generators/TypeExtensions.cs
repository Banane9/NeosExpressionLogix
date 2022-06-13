using System;
using System.Collections.Generic;
using System.Text;

namespace Generators
{
    internal static class TypeExtensions
    {
        public static void AppendTypeName(this StringBuilder builder, Type type)
        {
            if (!type.IsGenericType)
            {
                builder.Append(type.Name);
                return;
            }

            builder.Append(type.Name.Substring(0, type.Name.IndexOf('`')));
            builder.Append('<');

            var appendComma = false;
            foreach (var arg in type.GetGenericArguments())
            {
                if (appendComma)
                    builder.Append(", ");

                builder.AppendTypeName(arg);
                appendComma = true;
            }

            builder.Append('>');
        }

        public static string GetTypeName(this Type type)
        {
            if (!type.IsGenericType)
                return type.Name;

            var name = type.Name.Substring(0, type.Name.IndexOf('`')) + '<';

            var appendComma = false;
            foreach (var arg in type.GetGenericArguments())
            {
                if (appendComma)
                    name += ", ";

                name += arg.GetTypeName();

                appendComma = true;
            }

            return name + '>';
        }
    }
}