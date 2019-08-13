using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscambler
{
    class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Please enter the option -F for File and -M for Manual.";
        public const string OptionsOnContinuingTheProgram = "Do you want to continue the program? Y/N";

        public const string EnterScrambledWrodsViaFile = "Enter scambled words file name: ";
        public const string EnterScrambledWordsManually = "Enter words manually(separated by commas if multiple): ";
        public const string EnterScrambledWordsOptionNotRecognized = "Option is not recognised.";

        public const string MatchFound = "MATCH FOUND FOR {0}:{1}";
        public const string MatchNotFound = "NO MATCHES HACE BEED FOUND.";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was and error: ";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated: ";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordList.txt";
    }
}
