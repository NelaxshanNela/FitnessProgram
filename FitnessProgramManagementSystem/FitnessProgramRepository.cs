using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramRepository
    {
        static string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=FitnessProgramManagement;";

        ProgramManagerClass ProgramManagerClass = new ProgramManagerClass();
        public void CreateFitnessProgram()
        {
            Console.Write("Enter program Title: ");
            string programTitle = Console.ReadLine();
            Console.Write("Enter program duration (in months): ");
            string programDuration = Console.ReadLine();
            decimal programPrice = ProgramManagerClass.ValidateFitnessProgramPrice();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "insert into FitnessPrograms(Title,Duration,Price) values(@Title,@Duration,@Price);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", programTitle);
                    command.Parameters.AddWithValue("@Duration", programDuration);
                    command.Parameters.AddWithValue("@Price", programPrice);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Program added successfully");
                }
            }
        }

        public void UpdateFitnessProgram()
        {

        }

        public void DeleteFitnessProgram()
        {

        }

        public void ReadSingleFitnessPrograms()
        {

        }

        public void ReadAllFitnessPrograms()
        {

        }
    }
}
