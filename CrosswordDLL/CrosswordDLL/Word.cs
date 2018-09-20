using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrosswordDLL
{
    public class Word
    {
        public Word(string clue, string name, string category)
        {
            Clue = clue;
            Name = name;
            Category = category;
        }
        public string Clue { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
