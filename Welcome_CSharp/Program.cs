using System;
using System.Collections.Generic;
using System.Linq;

namespace Welcome_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();
            string userChoice = "0";
            int userChoice_menu = -1;
            int userChoice_pet = -1;
            int userChoice_snail = -1;
            int petCount = 0;

            Console.WriteLine("Hello! Welcome to the PetHouse!");

            while (userChoice_menu != 0)
            {
                Console.WriteLine("\nWhat would you like to do today?");
                Console.Write("+--x--x--x--x--MENU--x--x--x--x--+" +
                              "\n\t1 - Add a Pet (max 9)" +
                              "\n\t2 - Speak" +
                              "\n\t3 - Play" +
                              "\n\t4 - Info" +
                              "\n\t0 - Quit" +
                              "\n+--x--x--x--x--x--x--x--x--x--x--+\n");

                userChoice = Console.ReadLine();
                if (userChoice.All(char.IsDigit))
                {
                    userChoice_menu = Convert.ToInt32(userChoice);
                }

                userChoice_pet = -1; // to reset variable

                switch (userChoice_menu)
                {
                    case 1: // add a pet
                        while (userChoice_pet != 0)
                        {
                            Console.WriteLine("\nWhat kind of pet would you like to add?");
                            Console.Write("+--x--x--x--x--PETS--x--x--x--x--+" +
                                  "\n\t1 - Dog" +
                                  "\n\t2 - Cat" +
                                  "\n\t3 - Snail (recommended)" +
                                  "\n\t0 - Quit" +
                                  "\n+--x--x--x--x--x--x--x--x--x--x--+\n");

                            userChoice = Console.ReadLine();
                            if (userChoice.All(char.IsDigit))
                            {
                                userChoice_pet = Convert.ToInt32(userChoice);
                            }

                            switch (userChoice_pet)
                            {
                                case 1: // add dog
                                    pets.Add(new Dog());

                                    Console.WriteLine("What would you like to name your new dog?");
                                    pets[petCount].Name = Console.ReadLine();
                                    petCount++;
                                    break;

                                case 2: // add cat
                                    pets.Add(new Cat());

                                    Console.WriteLine("What would you like to name your new cat?");
                                    pets[petCount].Name = Console.ReadLine();
                                    petCount++;
                                    break;

                                case 3: // add snail
                                    pets.Add(new Snail());

                                    Console.WriteLine("What would you like to name your new snail?");
                                    pets[petCount].Name = Console.ReadLine();
                                    petCount++;
                                    break;

                                case 0:
                                    Console.WriteLine("Maybe next time?");
                                    break;

                                default: // invalid choice
                                    Console.WriteLine("Invalid option.");
                                    break;
                            }
                        }
                        break;

                    case 2: // speak
                        while (userChoice_pet != 0)
                        {
                            Console.WriteLine("\nWhich pet do you want to speak?");
                            PetPrintMenu();

                            userChoice = Console.ReadLine();
                            if (userChoice.All(char.IsDigit))
                            {
                                userChoice_pet = Convert.ToInt32(userChoice);
                            }

                            if (userChoice_pet > 0 && userChoice_pet <= petCount)
                            {
                                pets[userChoice_pet - 1].Speak();
                            }
                            else if (userChoice_pet != 0)
                            {
                                Console.WriteLine("Invalid option.");
                            }
                        }

                        break;

                    case 3: // play
                        while (userChoice_pet != 0)
                        {
                            Console.WriteLine("\nWhich pet do you want to play with?");
                            PetPrintMenu();

                            userChoice = Console.ReadLine();
                            if (userChoice.All(char.IsDigit))
                            {
                                userChoice_pet = Convert.ToInt32(userChoice);
                            }

                            if (userChoice_pet > 0 && userChoice_pet <= petCount)
                            {
                                pets[userChoice_pet - 1].Play();
                            }
                            else if (userChoice_pet != 0)
                            {
                                Console.WriteLine("Invalid option.");
                            }
                        }

                        break;

                    case 4: // info
                        while (userChoice_pet != 0)
                        {
                            Console.WriteLine("\nWhich pet do you want info about?");
                            PetPrintMenu();

                            userChoice = Console.ReadLine();
                            if (userChoice.All(char.IsDigit))
                            {
                                userChoice_pet = Convert.ToInt32(userChoice);
                            }

                            if (userChoice_pet > 0 && userChoice_pet <= petCount)
                            {
                                pets[userChoice_pet - 1].Info();
                                
                                //TODO: fix this
                                if (pets[userChoice_pet - 1].Species == "Snail") // for handling snails
                                {
                                    userChoice_snail = -1; // to reset variable

                                    while (userChoice_snail != 0)
                                    {
                                        Console.WriteLine("\nSnail Speed Options:");
                                        Console.Write("+--x--x--x--x--QWIK--x--x--x--x--+" +
                                          "\n\t1 - Speed Up" +
                                          "\n\t2 - Speed Down" +
                                          "\n\t3 - Turbo" +
                                          "\n\t4 - Slug" +
                                          "\n\t0 - Quit" +
                                          "\n+--x--x--x--x--x--x--x--x--x--x--+\n");

                                        userChoice = Console.ReadLine();
                                        if (userChoice.All(char.IsDigit))
                                        {
                                            userChoice_snail = Convert.ToInt32(userChoice);
                                        }

                                        switch (userChoice_snail)
                                        {
                                            case 1:
                                                pets[userChoice_pet - 1].SpeedUp();
                                                break;

                                            case 2:
                                                pets[userChoice_pet - 1].SpeedDown();
                                                break;

                                            case 3:
                                                pets[userChoice_pet - 1].Turbo();
                                                break;

                                            case 4:
                                                pets[userChoice_pet - 1].Slug();
                                                break;

                                            case 0:
                                                Console.WriteLine("No speed?");
                                                break;

                                            default:
                                                Console.WriteLine("Invalid option.");
                                                break;
                                        }
                                    }
                                }
                            }
                            else if (userChoice_pet != 0)
                            {
                                Console.WriteLine("Invalid option.");
                            }
                        }

                        break;

                    case 0: // quit
                        Console.WriteLine("Thanks for participating at PetHouse!");
                        break;

                    default: // invalid choice
                        Console.WriteLine("Invalid option.");
                        break;

                }
            }

            void PetPrintMenu()
            {
                Console.WriteLine("+--x--x--x--x--PETS--x--x--x--x--+");

                if (petCount == 1)
                    Console.WriteLine($"\n\t1 - {pets[0].Name}, {pets[0].Species}");
                else if (petCount == 2)
                    Console.WriteLine($"\n\t2 - {pets[1].Name}, {pets[1].Species}");
                else if (petCount == 3)
                    Console.WriteLine($"\n\t3 - {pets[2].Name}, {pets[2].Species}");
                else if (petCount == 4)
                    Console.WriteLine($"\n\t4 - {pets[3].Name}, {pets[3].Species}");
                else if (petCount == 5)
                    Console.WriteLine($"\n\t5 - {pets[4].Name}, {pets[4].Species}");
                else if (petCount == 6)
                    Console.WriteLine($"\n\t6 - {pets[5].Name}, {pets[5].Species}");
                else if (petCount == 7)
                    Console.WriteLine($"\n\t7 - {pets[6].Name}, {pets[6].Species}");
                else if (petCount == 8)
                    Console.WriteLine($"\n\t8 - {pets[7].Name}, {pets[7].Species}");
                else if (petCount == 9)
                    Console.WriteLine($"\n\t9 - {pets[8].Name}, {pets[8].Species}");

                Console.Write("\n\t0 - Quit" +
                      "\n+--x--x--x--x--x--x--x--x--x--x--+\n");
            }
        }
    }
}
