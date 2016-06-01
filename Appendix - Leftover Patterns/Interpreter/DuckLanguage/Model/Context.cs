using System.Collections.Generic;

namespace DuckLanguage.Model
{
    public class Context
    {
        public string Input { get; set; }
        public List<List<string>> Sequences = new List<List<string>>();
    }
}