using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Exercise
{
    public class CodeBuilder
    {
        private class Field
        {
            public readonly string Name;
            public readonly string TypeName;

            public Field(string name, string typeName)
            {
                Name = name;
                TypeName = typeName;
            }

            public string LineOfCode => $"  public {TypeName} {Name};";
        }

        private string className = "";
        private List<Field> fields = new List<Field>();

        public CodeBuilder(string className)
        {
            this.className = className;
        }

        public CodeBuilder AddField(string name, string typeName)
        {
            fields.Add(new Field(name, typeName));
            return this;
        }

        public string Build()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"public class {className}");
            sb.AppendLine("{");

            foreach (var field in fields)
            {
                sb.AppendLine(field.LineOfCode);
            }

            sb.AppendLine("}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Build();
        }
    }
}