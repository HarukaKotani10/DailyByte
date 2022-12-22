using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte
{
    public class UncommonWords
    {
        //This question is asked by Amazon. 
        //Given two strings representing sentences, 
        //return the words that are not common to both strings 
        //(i.e. the words that only appear in one of the sentences). 
        //You may assume that each sentence is a sequence of words (without punctuation) correctly separated using space characters.
        //
        //Ex: given the following strings...
        //
        //sentence1 = "the quick", sentence2 = "brown fox", return ["the", "quick", "brown", "fox"]
        //sentence1 = "the tortoise beat the haire", sentence2 = "the tortoise lost to the haire", return ["beat", "to", "lost"]
        //sentence1 = "copper coffee pot", sentence2 = "hot coffee pot", return ["copper", "hot"]

        public static string [] GetUncommonWords(string sentence1, string sentence2)
        {
            string combine = sentence1 + " " + sentence2;
            string[] result = combine.Split(' ');
            var list = new List<string>();

            foreach(string i in result)
                if (result.Count(r => r.Equals(i)) == 1)
                    list.Add(i);

            return list.ToArray();
        }

        public static string[] GetUncommonWordsOneLine(string sentence1, string sentence2)
        {
            return sentence1.Split().Union(sentence2.Split()).Except(sentence1.Split().Intersect(sentence2.Split())).ToArray();
        }

        public static string[] GetUncommonWordsConcat(string sentence1, string sentence2)
        {
            return sentence1.Split(' ').Except(sentence2.Split(' ')).Concat(sentence2.Split(' ').Except(sentence1.Split(' '))).ToArray();
        }
    }
}
