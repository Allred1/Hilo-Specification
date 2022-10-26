using System;
using System.Collections.Generic;

class Cards{
    Random random = new Random();
    Player player = new Player();


    List<int> deck = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13};

    public int getCard() {
        int index = random.Next(deck.Count);
        int currentCard = deck[index];
        return currentCard;
    }

    public bool compare(int currentCard, int nextCard, string guess) {
        bool truth = false;
        // if user guessed "h"
        if (guess == "h") {
            if (nextCard > currentCard) {
                truth =  true;
            } else {
                truth = false;
            }
        }
        // if user guessed "l"
        if (guess == "l") {
            if (nextCard < currentCard) {
                truth =  true;
            } else {
                truth = false;
            }
        }
        return truth;
    }


    // public bool removeCardFromDeck(index){
    //     if (index)
    // }
}

