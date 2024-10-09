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
            Console.Write("Enter program price: ");
            int programPrice = int.Parse(Console.ReadLine());

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
                Console.Write("Enter program price: ");
                int programPrice = int.Parse(Console.ReadLine());

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
            Console.WriteLine("delete works");
        }


        public decimal ValidateBikeRentalPrice()
        {
            decimal init = 0;

            while (true)
            {
                Console.WriteLine("Enter the Rental Price");
                var RentalPrice = decimal.Parse(Console.ReadLine());
                if (RentalPrice > 0)
                {
                    init = RentalPrice;
                    break;
                }
                Console.WriteLine("Invalid");
            }
            return init;
        }
    }
}
