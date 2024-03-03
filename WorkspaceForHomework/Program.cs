using System;
using WorkspaceForHomework;

namespace HomeworkWorkspaceNamespace
{
    public class HomeworkWorkspaceClass
    {
        public static void Main()
        {
            bool EXIT = false;

            int currentJob;
            int choice;

            Random random = new Random();
            Voluntario playerInstance;
            Animal animalInstance = new Animal(GenerateName(), GenerateFamily(), GenerateSpecie(), GenerateRandomWeight(), GenerateAffectionGrade());

            while (!EXIT) 
            {
                do
                {
                    Console.WriteLine(Messages.GameTitleMessage);
                    Console.WriteLine(Messages.ChoiceMessage);
                    choice = int.Parse(Console.ReadLine());
                } while (!IsInRange(choice, 1, 2));


                if (choice == 2)
                {
                    EXIT = true;
                }

                if (!EXIT)
                {
                    do
                    {
                        Console.WriteLine(Messages.JobChoiceMessage);
                        currentJob = int.Parse(Console.ReadLine());
                    } while (!IsInRange(currentJob, 1, 2));

                    playerInstance = new Voluntario(currentJob);

                    Console.WriteLine(Messages.NameSelectionMessage);
                    playerInstance.Name = Console.ReadLine();

                    Console.WriteLine(Messages.NewJobAlertMessage, playerInstance.Name);
                    Console.WriteLine();
                    Console.WriteLine(Messages.LayoutRescue, random.Next(1, 1000).ToString("000"), animalInstance.Family, animalInstance.AffectionGrade);
                    Console.WriteLine();
                    Console.WriteLine(Messages.JobAlertInfoMessage);
                    Console.WriteLine();
                    Console.WriteLine(Messages.LayoutPaper, animalInstance.Name, animalInstance.Family, animalInstance.Specie, animalInstance.Weight);
                    Console.WriteLine();

                    do
                    {
                        Console.WriteLine(Messages.ActionChoiceMessage, animalInstance.Specie, animalInstance.AffectionGrade);
                        choice = int.Parse(Console.ReadLine());
                    } while (!IsInRange(choice, 1, 2)) ;

                    animalInstance.CalculateAffectionGrade(choice);

                    Console.Write(Messages.TreatmentAppliedMessage, animalInstance.AffectionGrade);

                    if (animalInstance.AffectionGrade < 5)
                    {
                        Console.WriteLine(Messages.EnoughMessage, 50);
                    }
                    else
                    {
                        Console.WriteLine(Messages.NotEnoughMessage, 20);
                    }

                    Console.WriteLine(Messages.HastaLaProximaMessage);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public static bool IsInRange(int value, int min, int max)
        { 
            return (value >= min) && (value <= max);
        }

        public static string GenerateName()
        {
            string[] animalNames = { "Pepe" };
            return animalNames[new Random().Next(animalNames.Length)];
        }

        public static string GenerateSpecie()
        {
            string[] animalSpecies = { "Delfín" };
            return animalSpecies[new Random().Next(animalSpecies.Length)];
        }

        public static string GenerateFamily()
        {
            string[] families = { "Tortuga marina", "Ave marina", "Cetaci" };
            return families[new Random().Next(families.Length)];
        }

        public static int GenerateAffectionGrade()
        { 
            return new Random().Next(1,100);
        }

        public static int GenerateRandomWeight()
        {
            return new Random().Next(1, 100);
        }
    }
}