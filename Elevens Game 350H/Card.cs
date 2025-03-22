using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    //Fields, example: Rank rank;
    private Rank rank;
    private Suit suit;
    private bool faceUp;
    private int value;

    //Card Constructor
    public Card(Suit suit, Rank rank)
    {
        this.suit = suit;
        this.rank = rank;
        this.faceUp = false; // making cards start face down by default
        this.value = CalculateValue(rank);
    }

    //Define properties for all above fields
    //code example: public Suit Suit { get { return suit; } }
    public Suit Suit
    {
        get
        {
            return suit;
        }
    }
    public Rank Rank
    {
        get
        {
            return rank;
        }
    }
    public bool FaceUp
    {
        get
        {
            return faceUp;
        }
    }

    public void FlipOver()
    {
        // if face down then face up
        if (faceUp == false)
        {
            faceUp = true;
        }
        // if face up then down
        else
        {
            faceUp = false;
        }
    }

    private int CalculateValue(Rank rank)
    {
        // ace = 1 ... JQK = 10.
        switch (rank)
        {
            case global::Rank.Ace:
                return 1;
            case global::Rank.Two:
                return 2;
            case global::Rank.Three:
                return 3;
            case global::Rank.Four:
                return 4;
            case global::Rank.Five:
                return 5;
            case global::Rank.Six:
                return 6;
            case global::Rank.Seven:
                return 7;
            case global::Rank.Eight:
                return 8;
            case global::Rank.Nine:
                return 9;
            case global::Rank.Ten:
            case global::Rank.Jack:
            case global::Rank.Queen:
            case global::Rank.King:
                return 10;
            default:
                return 0;
        }
    }
    // to get card value:

    public int GetValue()
    {
        return value;
    }

}
