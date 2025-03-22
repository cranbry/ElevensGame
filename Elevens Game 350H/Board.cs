using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

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

    // checking if selected cards add up to 11
    public bool checkSum()
    {
        if (selectedCards.Count < 2)
        {
            return false;
        } 
        int sum = 0;

        foreach (int position in selectedCards) {
            // checking if not null for when cards are deleted
            if (position >= 0 && position < cards.Length && cards[position] != null){
                sum += cards[position].GetValue();
            }
        }

        return sum == 11;
    }

}
