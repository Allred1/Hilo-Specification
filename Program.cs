

<<<<<<< Updated upstream
=======
<<<<<<< HEAD

=======
>>>>>>> b6722fb9ebc02c082cbdc808cc71fa9f36c62a2f
>>>>>>> Stashed changes
class Hilo {

    static void Main(string[] args)
    {
        Player player = new Player();

        while (player.getPlayAgain())
        {
<<<<<<< Updated upstream
            

        }
    }




=======
<<<<<<< HEAD
            player.getGuess();
            
=======
            

>>>>>>> b6722fb9ebc02c082cbdc808cc71fa9f36c62a2f
        }
    }




<<<<<<< HEAD

    // method calculating score
    // takes guess parameter (true/false for correct/incorrect)
    // returns score
    static int computeScore(guess) 
    {
        int score = 300;
        bool guess = true;

        while (score !<= 0) {

            if (guess == true) {
            score += 100;
            }
            else if (guess == false) {
                score -= 75;
            }
            return score;
        }
    }

}



    // scoring:
    // starts with 300
    // if correctly guessed then +100
    // if incorrectly guessed then -75
    // if reaches 0 game is over
    // if more than 0, player can decide to keep playing
=======
>>>>>>> Stashed changes
    // method calculating score
    // takes guess parameter (true/false for correct/incorrect)
    // returns score
    // static int computeScore(guess) 
    // {
    //     int score = 300;
    //     bool guess = true;

    //     while (score !<= 0) {

    //         if (guess == true) {
    //         score += 100;
    //         }
    //         else if (guess == false) {
    //             score -= 75;
    //         }
    //         return score;
    //     }
    // }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> b6722fb9ebc02c082cbdc808cc71fa9f36c62a2f
>>>>>>> Stashed changes
