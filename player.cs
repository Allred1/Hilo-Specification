// Player
//     Guess
//         guess higher or lower
//     PlayAgain
//         ask if play again. If no, end it. If yes, repeat. 


class Player {
    // properties of the object
    int guess;
    bool playAgain;


    // constructor
    public Player(int guess, bool playAgain) {
        guess = 0;
        playAgain = false;
    }

    // a method to prompt the user for a guess and return that guess
    static int getGuess() {
        Console.Write("Higher or lower? [h/l]: ");
        int guess = int.Parse(Console.ReadLine());
        return guess;
    }

}
