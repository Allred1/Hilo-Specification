Deck
    Card
        draw/display random card from 1-13 
        compare with player's guess
    Score
        compute points (whether they were right or wrong)
        display points
    if playing again, repeat


Player
    Guess
        guess higher or lower
    PlayAgain
        ask if play again. If no, end it. If yes, repeat. 


Objects: 
    Player: their guess, their score
    Cards: drawn

Relationship:
    Draw a card
    Ask player if higher/lower
    Draw a card
    According to player's guess, bestow/retract points, display
    Ask to play again 


Object: player
    Responsibility: hold & display their guess
    State: higher/lower card
    Behaviors: compute/display score, ask to play again
Class: player 
    guess: int
    showScore(): None
    playAgain(): None

Object: Deck
    Responsibility: retain cards 1-13, draw one at random
    State: nothing
    Behaviors: randomly draw, compare to player guess, compute and display score
Class: Deck
    deck: list
    score: int
    cardNumber(): None
    score(): None


Structure:

    deck class
    player class
main