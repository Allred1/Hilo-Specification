using System;
using System.Collections.Generic;
class Cards{
    static int Main(string[] args){
        var random = new Random();
        var cards = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13};
        int index = random.Next(cards.Count);
        Console.WriteLine(cards[index]);
        return index;
    }

    public bool removeCardFromDeck(index){
        if (index)
    }
}


// compute score
// player starts w/ 300 points
// earns 100 points if guess is correct
// loses 75 points if guess is incorrect
// if reaches 0 points the game is over
// if more than 0 points, player can decide to keep playing. If they don't, the game ends. 