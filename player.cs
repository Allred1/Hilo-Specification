

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

    // method calculating score
    // takes guess parameter (true/false for correct/incorrect)
    // returns score
    public int computeScore(int score, bool answer) {
        string endMessage = "Game over!";

        while (score > 0) {

            if (answer == true) {
                score += 100;
                break;
            }
            else if (answer == false) {
                score -= 75;
                break;
            }
        }
        if (score <= 0) {
            Console.WriteLine(endMessage);
        }
        return score;
    }
}


// compute score
// player starts w/ 300 points
// earns 100 points if guess is correct
// loses 75 points if guess is incorrect
// if reaches 0 points the game is over
// if more than 0 points, player can decide to keep playing. If they don't, the game ends. 