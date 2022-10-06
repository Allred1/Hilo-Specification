

// create Player class
class Player
{
    // method that gets a user's guess
    public string getGuess() {
        Console.Write("Higher or lower? [h/l]: ");
        string guess = Console.ReadLine();
        return guess;
    }


    // method that asks the user if they want to play again.
    // returns true until they say no.
    public bool getPlayAgain() {
        bool startAgain = true;

        Console.Write("Play again? [y/n]: ");
        string answer = Console.ReadLine();

        if (answer == "y") 
        {
            startAgain = true;
        }
        else if (answer == "n") 
        {
            startAgain = false;
        }

        return startAgain;
    }

}