using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class ProgramManagerClass
    {
        public List<FitnessProgram> FitnessProgramList { get; set; } = new List<FitnessProgram>();

        public void CreateFitnessProgram()
        {
            Console.Write("Enter program ID: ");
            int FitnessProgramId = int.Parse(Console.ReadLine());
            Console.Write("Enter program Title: ");
            string programTitle = Console.ReadLine();
            Console.Write("Enter program duration (in months): ");
            string programDuration = Console.ReadLine();
            decimal programPrice = ValidateFitnessProgramPrice();

            FitnessProgram program = new FitnessProgram(FitnessProgramId, programTitle, programDuration, programPrice);

            FitnessProgramList.Add(program);
        }

        public void ReadFitnessPrograms()
        {
            if (FitnessProgramList.Count > 0)
            {
                foreach (var item in FitnessProgramList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No FitnessPrograms available.");
            }
        }

        public void UpdateFitnessProgram()
        {
            Console.Write("Enter program ID to update: ");
            int programId = int.Parse(Console.ReadLine());
            var findProgram = FitnessProgramList.Where(f => f.FitnessProgramId == programId).FirstOrDefault();
            if (findProgram != null)
            {
                FitnessProgramList.Remove(findProgram);

                Console.Write("Enter program Title: ");
                string programTitle = Console.ReadLine();
                Console.Write("Enter program duration (in months): ");
                string programDuration = Console.ReadLine();
                decimal programPrice = ValidateFitnessProgramPrice();

                FitnessProgram program = new FitnessProgram(programId, programTitle, programDuration, programPrice);

                FitnessProgramList.Add(program);
                Console.WriteLine("Bike Updated Successfully");
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
        }

        public void DeleteFitnessProgram()
        {
            Console.WriteLine("Enter the bike ID to be delete");
            int programId = int.Parse(Console.ReadLine());
            var findProgram = FitnessProgramList.Where(f => f.FitnessProgramId == programId).FirstOrDefault();
            if (findProgram != null)
            {
                this.FitnessProgramList.Remove(findProgram);

                Console.WriteLine("Successfully program Deleted");
            }
            else
            {
                Console.WriteLine("Invalid program Id");
            }
        }


        public decimal ValidateFitnessProgramPrice()
        {
            decimal init = 0;

            while (true)
            {
                Console.Write("Enter the program Price");
                var programPrice = decimal.Parse(Console.ReadLine());
                if (programPrice > 0)
                {
                    init = programPrice;
                    break;
                }
                Console.WriteLine("Invalid price");
            }
            return init;
        }
    }
}
