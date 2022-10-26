
class Hilo {


    static void Main(string[] args) {
        Player player = new Player();
        Cards cards = new Cards();
        int score = 300;

        while (player.getPlayAgain()) {   
            // Display current card
            int currentCard = cards.getCard();
            Console.WriteLine($"The card is: {currentCard}");
            // get player's guess "h/l"
            string guess = player.getGuess();
            // get the next card
            int nextCard = cards.getCard();
            Console.WriteLine($"Next card was: {nextCard}");
            // taking user's guess, compare currentCard with nextCard
            bool answer = cards.compare(currentCard, nextCard, guess);
            score = player.computeScore(score, answer);
            Console.WriteLine($"Your score is: {score}");            
        }
    }
}


// scoring:
// starts with 300
// if correctly guessed then +100
// if incorrectly guessed then -75
// if reaches 0 game is over
// if more than 0, player can decide to keep playing