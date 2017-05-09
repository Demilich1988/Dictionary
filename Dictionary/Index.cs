using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Index
    {
        //Creates Lists for words and definitions to do in deictionary
        private List<string> words;
        private List<string> def;

        /// <summary>
        /// Creates new instance of the index class with no values in the lists
        /// </summary>
        public Index()
        {
            words = new List<string>();
            def = new List<string>();
        }

        /// <summary>
        /// Index that looks for word and description in dictionary if no values it uses user input to add it
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string this[string word]
        {
            get
            {
                string result = LookupWord(word);
                if (result == null) { throw new KeyNotFoundException(word); }
                return result;
            }
            set
            {
                AddDefinition(word, value);
            }
        }

        /// <summary>
        /// Method to find word in dictionary
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string LookupWord(string word)
        {
            for (int index = 0; index < words.Count; index++)
            {
                if(words[index] == word)
                {
                    return def[index];
                }
            }
            return null;
        }

        /// <summary>
        /// Method to add defintion and words to the dictionary index
        /// </summary>
        /// <param name="word"></param>
        /// <param name="definition"></param>
        public void AddDefinition(string word, string definition)
        {
            for (int index = 0; index< words.Count; index++)
            {
                if (words[index]== word)
                {
                    def[index] = definition;
                    return;
                }

            }
            words.Add(word);
            def.Add(definition);
        }
    }
}
