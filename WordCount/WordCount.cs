﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {
        public int GetNumberofWords(string sentence)
        {
            string[] splitsentence = sentence.Split(' ');
            int count = splitsentence.Length;

            return count;
        }
    }
}