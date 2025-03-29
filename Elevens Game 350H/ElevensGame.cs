using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
public class ElevensGame
{
    private Deck deck;
    private Board board;
    private int loss_count;
    private int win_count;

    // constructor to initialize wins and losses
    public ElevensGame()
    {
        win_count = 0;
        loss_count = 0;
    }
    public void selectedCard() {
        Card selectedCard = board.Select(position);
    }

}

