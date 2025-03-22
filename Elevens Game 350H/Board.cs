using System;
using System.Collections.Generic;

public class Board {
    
    // array of cards
    private Card[] cards;

    // list of selected cards
    private List<int> selectedCards;

    // constructor
    public Board() {
        cards = new Card[9]; // array of 9 cards for the board.
        selectedCards = new List<int>(); // to add each selected card to.
    }


}
