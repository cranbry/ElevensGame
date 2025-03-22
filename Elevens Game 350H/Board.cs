using System;
using System.Collections.Generic;

public class Board
{

    // array of cards
    private Card[] cards;

    // list of selected cards
    private List<int> selectedCards;

    // constructor
    public Board()
    {
        cards = new Card[9]; // array of 9 cards for the board.
        selectedCards = new List<int>(); // to add each selected card to.
    }

    // replacing card at specific position
    public void replaceSelectedCard(int position, Card newCard)
    {
        // error checking
        if (position >= 0 && position < cards.Length)
        {
            cards[position] = newCard;
        }
    }


}
