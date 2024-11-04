using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyProgram
{
    // Define a class for the loyalty program
    public class LoyaltyProgram
    {
        // Delegate for calculating points based on transaction amount and action type
        public Func<decimal,string,int> CalculatePoints { get; set; }
        // Delegate for notifying the user with a message and their points
        public Action<string,int> NotifyUser { get; set; }
        // Method to process a transaction
        public void ProcessTransaction(decimal transactionAmount,string actionType)
        {
            // Calculate the points earned from the transaction
            int points = CalculatePoints(transactionAmount,actionType);
            Console.WriteLine($"Transaction processed. {points} points awarded.");

            // Notify the user if points exceed the reward threshold
            if (points >= 100)
            {
                NotifyUser("Congratulations! You have earned a reward!",points);
                Console.WriteLine("🎉 You have won a special prize! 🎉"); // Print winning message to console
            }
        }
    }
}
