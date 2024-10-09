namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgram fitnessProgram = new FitnessProgram(1000, "vss", "2", 2000);
            //Console.WriteLine(fitnessProgram.ToString());

            ProgramManagerClass programManagerClass = new ProgramManagerClass();

            FitnessProgramRepository repository = new FitnessProgramRepository();

            while (true)
            {
                Console.WriteLine("Fitness Program Management System:");
                Console.WriteLine("1. Add a Fitness Program");
                Console.WriteLine("2. View All Fitness Programs");
                Console.WriteLine("3. Update a Fitness Program");
                Console.WriteLine("4. Delete a Fitness Program");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        repository.CreateFitnessProgram();
                        break;
                    case "2":
                        programManagerClass.ReadFitnessPrograms();
                        break;
                    case "3":
                        programManagerClass.UpdateFitnessProgram();
                        break;
                    case "4":
                        programManagerClass.DeleteFitnessProgram();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
