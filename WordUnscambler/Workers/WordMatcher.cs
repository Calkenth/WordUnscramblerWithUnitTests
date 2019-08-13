using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscambler.Data;

namespace WordUnscambler.Workers
{
    public class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambleWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWord>();

            foreach(var scrambleWord in scrambleWords)
            {
                foreach(var word in wordList)
                {
                    if(scrambleWord.Equals(word,StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambleWord, word));
                    }
                    else
                    {
                        var scrambledWordArray = scrambleWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);
                        var sortedScrambledWord = new string(scrambledWordArray);
                        var sortedWord = new string(wordArray);

                        if(sortedScrambledWord.Equals(sortedWord,StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambleWord, word));
                        }
                    }
                }
            }

            return matchedWords;
        }

        private MatchedWord BuildMatchedWord(string scrambleWord, string word)
        {
            MatchedWord matchedWord = new MatchedWord
            {
                ScrambleWord = scrambleWord,
                Word = word
            };
            return matchedWord;
        }
    }
}
