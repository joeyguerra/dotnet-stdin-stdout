namespace DotnetStdinStdout {
    public class JsonCollection
    {
        // Adding an Href to the collection. because I need to know how to load items in case of normalized collections. it's also on the heterogeneous collection gist https://gist.github.com/lmarburger/7169444
        public string Href { get; set; }
        public string Version { get; set; } = "0.1";
        public Item[] Items { get; set; }
        public Item Template { get; set; }
        public Item Errors { get; set; }
        public class Item
        {
            public string Href { get; set; }
            public Datum[] Data { get; set; }
        }

        public class Datum
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public string Prompt { get; set; }
            public string Required { get; set; }
            public string Type { get; set; }
            public Datum() { }
            public Datum(string name, string value) => (Name, Value) = (name, value);
            public Datum(string name, string value, string prompt) => (Name, Value, Prompt) = (name, value, prompt);
            public Datum(string name, string value, string prompt, string type) => (Name, Value, Prompt, Type) = (name, value, prompt, type); // expression bodied constructor: c# 8 constructing with tuple
        }
    }
}