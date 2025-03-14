using System.Text;

class Program
{
    public class Virus
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name,
                     string type,
                     double weight,
                     int age)
        {
            Name = name;
            Type = type;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            if (child == null)
                throw new ArgumentNullException(nameof(child));

            if (this == child)
                throw new InvalidOperationException("Self reference attempt.");

            if (IsChild(child))
                throw new InvalidOperationException("Circular reference attempt.");

            Children.Add(child);
        }

        private bool IsChild(Virus virus)
        {
            foreach (var child in Children)
            {
                if (child == virus || child.IsChild(virus))
                {
                    return true;
                }
            }
            return false;
        }

        public Virus Clone()
        {
            Virus clone = new Virus(Name, Type, Weight, Age);
            foreach (var child in Children)
            {
                clone.AddChild(child.Clone());
            }
            return clone;
        }

        public string GetTree(int indentLevel = 0)
        {
            var builder = new StringBuilder();
            string indent = new string(' ', indentLevel * 3);

            builder.AppendLine($" {indent}│ Weight: {Weight}");
            builder.AppendLine($" {indent}│ Name: {Name}");
            builder.AppendLine($" {indent}│ Type: {Type}");
            builder.AppendLine($" {indent}│ Age: {Age}");
            if (Children.Count > 0)
                builder.AppendLine($" {indent}│ Children:");

            foreach (var child in Children)
            {
                builder.AppendLine($" {indent}└  Child Virus:");
                builder.AppendLine(child.GetTree(indentLevel + 1));
            }

            return builder.ToString();
        }
    }

    public static void Main(string[] args)
    {
        Virus Virus1Gen1 = new Virus("V1G1", "Generation 1", 1.5, 5);
        Virus Virus1Gen2 = new Virus("V1G2", "Generation 2", 2.5, 6);
        Virus Virus1Gen3 = new Virus("V1G3", "Generation 3", 3.5, 7);
        Virus Virus2Gen3 = new Virus("V2G3", "Generation 3", 4.5, 8);
        Virus Virus1Gen4 = new Virus("V1G4", "Generation 4", 5.5, 9);
        Virus Virus1Gen5 = new Virus("V1G5", "Generation 5", 6.5, 10);

        Virus1Gen1.AddChild(Virus1Gen2);
        Virus1Gen2.AddChild(Virus1Gen3);
        Virus1Gen2.AddChild(Virus2Gen3); 
        Virus1Gen3.AddChild(Virus1Gen4);
        Virus1Gen4.AddChild(Virus1Gen5);

        Console.WriteLine("== Generations ==");
        Console.WriteLine(Virus1Gen1.GetTree());

        Virus Virus1Gen1Cloned = Virus1Gen1.Clone();

        Console.WriteLine("== Cloned Generations ==");
        Console.WriteLine(Virus1Gen1Cloned.GetTree());

        Virus1Gen1Cloned.Name = "V1G1-CL";
        Virus1Gen1Cloned.Children[0].Name = "V1G2-CL";
        Virus1Gen1Cloned.Children[0].Children[0].Name = "V1G3-CL";
        Virus1Gen1Cloned.Children[0].Children[0].Children[0].Name = "V1G4-CL";
        Virus1Gen1Cloned.Children[0].Children[0].Children[0].Children[0].Name = "V1G5-CL";

        Console.WriteLine("== Modified Cloned Generations ==");
        Console.WriteLine(Virus1Gen1Cloned.GetTree());

        Console.WriteLine("== Original Generations ==");
        Console.WriteLine(Virus1Gen1.GetTree());
    }
}
