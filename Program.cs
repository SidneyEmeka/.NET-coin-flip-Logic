Random flipNum = new Random(); //initialize the Random method
int numLuck = flipNum.Next(1, 13); // initialize the random number generator between 1 and 12
string fate = numLuck > 6 ? "HEAD" : "TAIL"; // Using Tenary operator determine if its a head or tail from the lucky number generated
Console.Write($"Your Luck gave you {numLuck}, Press 'Enter' key to know Your Fate..."); //Output the Lucky Number
Console.ReadLine();
Console.WriteLine($"Your fate is {fate}"); // Output the fate