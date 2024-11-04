using LoyaltyProgram;


class Program
{
    static void Main()
    {
        // Create an instance of the LoyaltyProgram class
        var loyaltyProgram = new LoyaltyProgram.LoyaltyProgram
        {
            // Define the method for calculating points based on the transaction type
            CalculatePoints = (amount, type) =>
            {
                // Determine points based on action type using a switch expression

                return type switch
                {
                    "purchase" => (int)(amount / 10), // 1 point for every 10 currency units spent
                    "referral" => 50,                  // 50 points for a referral
                    "review" => 20,                    // 20 points for a review
                    "chance" => 100,
                    _ => 0
                };
            },
            // Define the method for notifying the user
            NotifyUser = (message, points) =>
            {
                // Print the notification message and current points to the console
                Console.WriteLine($"{message} You have {points} points.");
            }
        };
        // Simulate transactions to demonstrate loyalty points processing
        loyaltyProgram.ProcessTransaction(150, "purchase"); // Transaction of 150 currency units
        loyaltyProgram.ProcessTransaction(100, "referral");  // Referral action
        loyaltyProgram.ProcessTransaction(30, "review");     // Review action
        loyaltyProgram.ProcessTransaction(1000, "chance");



    }
}