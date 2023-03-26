using System.Text.RegularExpressions;

namespace Task_2_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Regex vowelStartRegex = new Regex(@"\b[AEIOUaeiou].[a-z]+(\s)?\b");

            MatchCollection matchOne = vowelStartRegex.Matches("onderous\r\nSubterfuge\r\nNebula\r\nInscrutable\r\nThwart\r\nJubilant\r\nEuphoria\r\nOminous\r\nJuxtapose\r\nGossamer\r\nMyriad\r\nDiscordant\r\nMelancholy\r\nProclivity\r\nInfinitesimal\r\nNonchalant\r\nCapricious\r\nEthereal\r\nCatharsis\r\nClandestine\r\nTempestuous\r\nCapacious\r\nResplendent\r\nProdigal\r\nSolitude\r\nResilient\r\nQuerulous\r\nEnigma\r\nFrenetic\r\nPernicious");

            Console.WriteLine($"We've found: {matchOne.Count} matches for words that start with a vowel::");

            foreach (var good in matchOne)
            {
                Console.WriteLine(good);
            }

            // task 2
            Regex oauEndRegex = new Regex(@"\b.[a-z]+[AOUaou](\s)?\b");

            MatchCollection matchTwo = oauEndRegex.Matches("onderous\r\nSubterfuge\r\nNebula\r\nInscrutable\r\nThwart\r\nJubilant\r\nEuphoria\r\nOminous\r\nJuxtapose\r\nGossamer\r\nMyriad\r\nDiscordant\r\nMelancholy\r\nProclivity\r\nInfinitesimal\r\nNonchalant\r\nCapricious\r\nEthereal\r\nCatharsis\r\nClandestine\r\nTempestuous\r\nCapacious\r\nResplendent\r\nProdigal\r\nSolitude\r\nResilient\r\nQuerulous\r\nEnigma\r\nFrenetic\r\nPernicious");


            Console.WriteLine($"\nWe've found: {matchTwo.Count} matches for words that end with 'a' or 'o' or 'u'::");

            foreach (var good in matchTwo)
            {
                Console.WriteLine(good);
            }

            // task 3
            Regex upperCaseRegex = new Regex(@"\b[A-Z].[a-z]+(\s)?\b");

            MatchCollection matchThree = upperCaseRegex.Matches("onderous\r\nSubterfuge\r\nNebula\r\nInscrutable\r\nThwart\r\nJubilant\r\nEuphoria\r\nOminous\r\nJuxtapose\r\nGossamer\r\nMyriad\r\nDiscordant\r\nMelancholy\r\nProclivity\r\nInfinitesimal\r\nNonchalant\r\nCapricious\r\nEthereal\r\nCatharsis\r\nClandestine\r\nTempestuous\r\nCapacious\r\nResplendent\r\nProdigal\r\nSolitude\r\nResilient\r\nQuerulous\r\nEnigma\r\nFrenetic\r\nPernicious");


            Console.WriteLine($"\nWe've found: {matchThree.Count} matches for words that start with upper case::");

            foreach (var good in matchThree)
            {
                Console.WriteLine(good);
            }

            // task 4
            Regex pointEndRegex = new Regex(@"[A-Za-z]+\.(\s)?");

            MatchCollection matchFour = pointEndRegex.Matches("onderous.\r\nSubterfuge\r\nNebula.\r\nInscrutable\r\nThwart\r\nJubilant\r\nEuphoria\r\nOminous\r\nJuxtapose\r\nGossamer\r\nMyriad\r\nDiscordant\r\nMelancholy\r\nProclivity\r\nInfinitesimal\r\nNonchalant\r\nCapricious.\r\nEthereal\r\nCatharsis\r\nClandestine\r\nTempestuous\r\nCapacious\r\nResplendent\r\nProdigal\r\nSolitude\r\nResilient\r\nQuerulous\r\nEnigma\r\nFrenetic\r\nPernicious");

            Console.WriteLine($"\nWe've found: {matchFour.Count} matches for words that end with '.'::");

            foreach (var good in matchFour)
            {
                Console.WriteLine(good);
            }

            // task 5
            Regex commaEndThreeVowelsMinRegex = new Regex(@"(?:.*?[AEIOUaeiou]){3,}.*\,");

            MatchCollection matchFive = commaEndThreeVowelsMinRegex.Matches("onderous,\r\nSubterfuge\r\nNebula,\r\nInscrutable,\r\nThwart\r\nJubilant\r\nEuphoria\r\nOminous\r\nJuxtapose\r\nGossamer\r\nMyriad\r\nDiscordant\r\nMelancholy\r\nProclivity\r\nInfinitesimal\r\nNonchalant\r\nCapricious.\r\nEthereal\r\nCatharsis\r\nClandestine\r\nTempestuous\r\nCapacious\r\nResplendent\r\nProdigal\r\nSolitude\r\nResilient\r\nQuerulous\r\nEnigma\r\nFrenetic\r\nPernicious");

            Console.WriteLine($"\nWe've found: {matchFive.Count} matches for words that end with ',' and have at least 3 vowels::");

            foreach (var good in matchFive)
            {
                Console.WriteLine(good);
            }
        }
    }
}