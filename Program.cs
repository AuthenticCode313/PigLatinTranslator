using System;

namespace PigLatinLabAO
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.WriteLine();
                userInputAndTranslate();

            }

            static void userInputAndTranslate()
                
            {

                bool runProgram = true;

                do
                {
                    Console.WriteLine("Enter an English word to translate: ");
                    string word = (Console.ReadLine().ToLower().Trim());

                    //Step 1
                    int vowelPosition = -1;
                    foreach (char letter in word)
                    {
                        vowelPosition = vowelPosition + 1;
                        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                        {
                            break;
                        }
                    }
                    //Step 2 
                    string PigLatinWord = "";
                    string BeforeLetters = "";
                    string AfterLetters = "";

                    switch (vowelPosition)
                    {
                        case 0:
                            PigLatinWord = word + "way";
                            break;
                        case 1:
                            BeforeLetters = word.Substring(0, 1);
                            AfterLetters = word.Substring(1);
                            PigLatinWord = AfterLetters + BeforeLetters + "ay";
                            break;
                        case 2:
                            BeforeLetters = word.Substring(0, 2);
                            AfterLetters = word.Substring(2);
                            PigLatinWord = AfterLetters + BeforeLetters + "ay";
                            break;
                    }

                    Console.WriteLine("Translation: " + PigLatinWord);
                    Console.WriteLine();

                    Console.WriteLine("Would you like to translate another word? y/n");

                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (input.ToLower().Trim() == "y")
                            {
                                break;
                            }
                            else if (input.ToLower().Trim() == "n")
                            {
                                runProgram = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You did not enter a vaild word");

                            }
                        }

                } while (runProgram);

            }
        }
    }
}
