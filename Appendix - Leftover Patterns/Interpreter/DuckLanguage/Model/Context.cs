using System;
using System.Collections.Generic;

namespace DuckLanguage.Model
{
    public class Context : ICloneable
    {
        public char OpenTag { get; private set; }
        public char CloseTag { get; private set; }
        public string Demarcator { get; private set; }

        public string Input { get; set; }
        public List<Context> Sequences = new List<Context>();

        private string _output;
        public string Output
        {
            get { return CreateOutput(); }
            set { _output = value; }
        }


        public Context(string demarcator, char openTag, char closeTag = ' ')
        {
            Demarcator = demarcator;
            OpenTag = openTag;
            CloseTag = closeTag;
        }

        
        public object Clone()
        {
            Context clone = new Context(Demarcator, OpenTag, CloseTag);
            clone.Input = Input;
            clone.Output = Output;
            //clone.Sequences = new List<Context>(Sequences);
            return clone;
        }

        private string CreateOutput()
        {
            string totalOutput = _output;
            foreach (Context context in Sequences)
            {
                totalOutput += context.Output;
            }
            return totalOutput;
        }
    }
}