using System;

namespace CSharpFoundational
{
    internal class MicrosoftContosoPet
    {
        public static void Main()
        {
            int maxPets = 8;
            string[,] ourAnimals = new string[maxPets,6];
            string? readResult;
            string menuSelection = "";
            
            string animalID = "";
            string animalAge = "";
            string animalSpecies = "";
            string animalNickname = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            
            for(int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    break;
                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "loki";
                    break;
                case 2:          
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                    break;
                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;
                default:
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;

                }
                
                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }
                
            do
            {
                    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                    Console.WriteLine("1. List all of our current pet information");
                    Console.WriteLine("2. Add a new animal friend to the ourAnimals array");
                    Console.WriteLine("3. Ensure animal ages and physical descriptions are complete");
                    Console.WriteLine("4. Ensure animal nicknames and personality descriptions are complete");
                    Console.WriteLine("5. Edit an animal's age");
                    Console.WriteLine("6. Edit an animal's personality description");
                    Console.WriteLine("7. Display all cats with a specified characteristic");
                    Console.WriteLine("8. Display all dogs with a specified characteristic");

                    Console.WriteLine("Enter your selection number (or type Exit to exit the program):");
                    menuSelection = Console.ReadLine();
                    
                    switch(menuSelection)
                    {
                        case "1":
                            for(int i = 0; i < maxPets; i++)
                            {
                                for(int j = 0; j < 6; j++)
                                {
                                    if(ourAnimals[i,0] != "ID #: ")
                                    {
                                        Console.WriteLine(ourAnimals[i,j]);
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;
                        case "2":
                            int petCount = 0;
                            string anotherPet = "y";
                            
                            for(int i = 0; i < maxPets; i++)
                            {
                                if(ourAnimals[i,0] != "ID #: ")
                                    petCount++;
                            }
                            if(petCount < maxPets)
                            {
                                Console.WriteLine($"We currently have {petCount} pets and we can add {maxPets - petCount} more.\n");
                                // while(petCount < maxPets && anotherPet != "n")
                                // {
                                    do
                                    {
                                    Console.WriteLine("Do you want to add another pet?(y/n)");
                                    anotherPet = Console.ReadLine();
                                    Console.WriteLine("Do you want to add dog or cat ?");
                                    string species = Console.ReadLine();
                                    ourAnimals[petCount,1] = species;
                                    int dogCount = 0;
                                    int catCount = 0;
                                    if(species == "dog")
                                    {
                                        for(int i = 0; i < petCount;i++)
                                        {
                                        if(ourAnimals[i,0] == "dog")
                                        {
                                            dogCount++;
                                        }
                                        }
                                        ourAnimals[petCount,0] = "d" + (++dogCount);
                                    }
                                    else if(species == "cat")
                                    {
                                        for(int i = 0; i < petCount;i++)
                                        {
                                        if(ourAnimals[i,0] == "cat")
                                        {
                                            catCount++;
                                        }
                                        }
                                        ourAnimals[petCount,0] = "d" + (++catCount);
                                    }
                                    Console.WriteLine("Enter age: ");
                                    string age = Console.ReadLine();
                                    ourAnimals[petCount,2] = age;
                                    Console.WriteLine("Enter nickName: ");
                                    string nickName = Console.ReadLine();
                                    ourAnimals[petCount,3] = nickName;
                                    Console.WriteLine("Enter physical description: ");
                                    string phyDesc = Console.ReadLine();
                                    ourAnimals[petCount,4] = phyDesc;
                                    Console.WriteLine("Enter Personality Description: ");
                                    string persoDesc = Console.ReadLine();
                                    ourAnimals[petCount,5] = persoDesc;
                                     petCount++;
                                    }while(petCount < maxPets && anotherPet != "n");
                                    
                                    
                                    
                                    
                                   
                                    
                                }
                            
                            if(petCount >= maxPets)
                            {
                                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                            }
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "8":
                            break;
                        default:
                            break;
                    }
                    
            }while(menuSelection.Trim().ToLower() != "exit");
        }
    }
}