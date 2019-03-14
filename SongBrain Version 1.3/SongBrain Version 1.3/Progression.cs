/*	SongBrain - Progression.cs, Quinn Schroeder.
 *      (c) 2017-2018 All Rights Reserved.	
 */

using System;
using System.Collections.Generic;

class Progression
{
    private int ChordQuantity { get; set; }  //stores chord quantity    
    private KeySignature Key { get; set; }  //create a KeySignature object
    public List<string> ChordArray { get; set; }  //create a chord progression collection
    public List<string> ChordLabels { get; set; }  //create a chord labels collection
    private static Random randomNumber = new Random();  //create randomNumber object
    private static int random;  //stores randome number

    //progression object constructor
    public Progression()
    {
        ChordQuantity = 0;
        Key = new KeySignature();  
        ChordArray = new List<string>();
        ChordLabels = new List<string>();
    }

    //overloaded constructor used by SongBuilder class
    public Progression(int chordQuantity, KeySignature key)
    {
        this.ChordQuantity = chordQuantity;
        this.Key = key;
        ChordArray = new List<string>();
        ChordLabels = new List<string>();
    }

    public void MakeProgression()
    {
        Key.SetKeySignature();  //assign a key signature for the progression

        ChordQuantity = GetChordQuantity();  //set the chord quantity       

        LoadChords();  //load the chords for the progression
    }

    public void DisplayProgression()
    {
        Console.WriteLine($"\n\n  Your {Key.KeyLabel} chord progression is:\n");
        Console.Write("  ");

        foreach (var chord in ChordArray)
        {
            Console.Write($"{chord}   ");
        }

        Console.WriteLine();
        Console.Write("  ");
        foreach (var label in ChordLabels)
        {
            Console.Write($"{label} ");
        }

        Console.WriteLine("\n");

    }

    private int GetChordQuantity()
    {
        var chordQuantity = 0;
        var chordMin = 1; //set minimum number of chords for progression
        var chordMax = 4; //set maximum number of chords for progression

        //get chord quantity from user
        chordQuantity = InputChecker.IntegerCheck("\n  How many chords would you like in your progression?  ",
            chordMin, chordMax);

        return chordQuantity;
    }

    public void LoadChords()
    {
        //load the chord progression array
        for (int i = 0; i < ChordQuantity; i++)
        {
            if (i == 0)
            {
                ChordArray.Insert(i, FirstChord());
            }
            else if (i == 1)
            {
                ChordArray.Insert(i, SecondChord(ChordArray[0]));
            }
            else if (i == 2)
            {
                ChordArray.Insert(i, ThirdChord(ChordArray[1]));
            }
            else if (i == 3)
            {
                ChordArray.Insert(i, FourthChord(ChordArray[2]));
            }
        }

        //load the chord labels array
        for (int i = 0; i < ChordArray.Count; i++)
        {
            ChordLabels.Insert(i, TranslateChord(ChordArray[i], Key.KeyNumber));
        }
    }

    private string FirstChord()
    {
        var chord1 = "";

        random = randomNumber.Next(1, 100);  //set random value

        if (random <= 75)       //75%
            chord1 = "1";
        else if (random <= 77)  //2%
            chord1 = "2";
        else if (random <= 80)  //3%
            chord1 = "3";
        else if (random <= 86)  //6%
            chord1 = "4";
        else if (random <= 97)  //11%
            chord1 = "5";
        else                    //3%
            chord1 = "6";

        return chord1;
    }

    private string SecondChord(string chord1)
    {
        var chord2 = "";

        random = randomNumber.Next(1, 100);  //set random value

        switch (chord1)
        {
            case "1":
                if (random <= 13)       //13%
                    chord2 = "2";
                else if (random <= 24)  //11%
                    chord2 = "3";
                else if (random <= 50)  //26%
                    chord2 = "4";
                else if (random <= 83)  //33%
                    chord2 = "5";
                else
                    chord2 = "6";       //17%
                break;

            case "2":
                if (random <= 23)       //23%
                    chord2 = "3";
                else if (random <= 48)  //25%
                    chord2 = "4";
                else if (random <= 66)  //18%
                    chord2 = "5";
                else
                    chord2 = "6";       //34%
                break;

            case "3":
                if (random <= 9)        //9%
                    chord2 = "2";
                else if (random <= 54)  //45%
                    chord2 = "4";
                else if (random <= 67)  //13%
                    chord2 = "5";
                else
                    chord2 = "6";       //33%
                break;

            case "4":
                if (random <= 17)       //17%
                    chord2 = "2";
                else if (random <= 32)  //15%
                    chord2 = "3";
                else if (random <= 76)  //44%
                    chord2 = "5";
                else
                    chord2 = "6";       //22%
                break;

            case "5":
                if (random <= 17)       //17%
                    chord2 = "2";
                else if (random <= 26)  //9%
                    chord2 = "3";
                else if (random <= 58)  //32%
                    chord2 = "4";
                else
                    chord2 = "6";       //42%
                break;

            case "6":
                if (random <= 16)       //16%
                    chord2 = "2";
                else if (random <= 31)  //15%
                    chord2 = "3";
                else if (random <= 76)  //45%
                    chord2 = "4";
                else
                    chord2 = "5";       //24%
                break;
        }
        return chord2;
    }

    private string ThirdChord(string chord2)
    {
        var chord3 = "";

        random = randomNumber.Next(1, 100);  //set random value

        switch (chord2)
        {
            case "2":
                if (random <= 17)       //17%
                    chord3 = "1";
                else if (random <= 36)  //19%
                    chord3 = "3";
                else if (random <= 57)  //21%
                    chord3 = "4";
                else if (random <= 71)  //14%
                    chord3 = "5";
                else
                    chord3 = "6";       //29%
                break;

            case "3":
                if (random <= 10)       //10%
                    chord3 = "1";
                else if (random <= 17)  //7%
                    chord3 = "2";
                else if (random <= 58)  //41%
                    chord3 = "4";
                else if (random <= 69)  //11%
                    chord3 = "5";
                else
                    chord3 = "6";       //31%
                break;

            case "4":
                if (random <= 38)       //38%
                    chord3 = "1";
                else if (random <= 46)  //8%
                    chord3 = "2";
                else if (random <= 52)  //6%
                    chord3 = "3";
                else if (random <= 85)  //33%
                    chord3 = "5";
                else
                    chord3 = "6";       //15%
                break;

            case "5":
                if (random <= 17)       //17%
                    chord3 = "1";
                else if (random <= 30)  //13%
                    chord3 = "2";
                else if (random <= 35)  //5%
                    chord3 = "3";
                else if (random <= 63)  //28%
                    chord3 = "4";
                else
                    chord3 = "6";       //37%
                break;

            case "6":
                if (random <= 14)       //14%
                    chord3 = "1";
                else if (random <= 26)  //12%
                    chord3 = "2";
                else if (random <= 37)  //11%
                    chord3 = "3";
                else if (random <= 74)  //37%
                    chord3 = "4";
                else
                    chord3 = "5";       //26%
                break;
        }
        return chord3;
    }

    private string FourthChord(string chord3)
    {
        var chord4 = "";

        random = randomNumber.Next(1, 100);  //set random value

        switch (chord3)
        {
            case "1":
                if (random <= 15)       //15%
                    chord4 = "2";
                else if (random <= 35)  //20%
                    chord4 = "3";
                else if (random <= 61)  //26%
                    chord4 = "4";
                else if (random <= 83)  //22%
                    chord4 = "5";
                else
                    chord4 = "6";       //17%
                break;

            case "2":
                if (random <= 13)       //13%
                    chord4 = "1";
                else if (random <= 22)  //9%
                    chord4 = "3";
                else if (random <= 48)  //26%
                    chord4 = "4";
                else if (random <= 81)  //33%
                    chord4 = "5";
                else
                    chord4 = "6";       //19%
                break;

            case "3":
                if (random <= 10)       //10%
                    chord4 = "1";
                else if (random <= 20)  //10%
                    chord4 = "2";
                else if (random <= 64)  //44%
                    chord4 = "4";
                else if (random <= 77)  //13%
                    chord4 = "5";
                else
                    chord4 = "6";       //23%
                break;

            case "4":
                if (random <= 37)       //37%
                    chord4 = "1";
                else if (random <= 43)  //6%
                    chord4 = "2";
                else if (random <= 48)  //5%
                    chord4 = "3";
                else if (random <= 83)  //35%
                    chord4 = "5";
                else
                    chord4 = "6";       //17%
                break;

            case "5":
                if (random <= 32)       //32%
                    chord4 = "1";
                else if (random <= 39)  //7%
                    chord4 = "2";
                else if (random <= 44)  //5%
                    chord4 = "3";
                else if (random <= 79)  //35%
                    chord4 = "4";
                else
                    chord4 = "6";       //21%
                break;

            case "6":
                if (random <= 14)       //14%
                    chord4 = "1";
                else if (random <= 21)  //7%
                    chord4 = "2";
                else if (random <= 28)  //7%
                    chord4 = "3";
                else if (random <= 70)  //42%
                    chord4 = "4";
                else
                    chord4 = "5";       //30%
                break;
        }
        return chord4;
    }

    public string TranslateChord(string chordNum, int key)
    {
        var chordNumber = chordNum;
        var keySig = key;
        var chord = "";

        switch (keySig)
        {
            case 1:
                if (chordNumber == "1")
                    chord = "C  ";
                else if (chordNumber == "2")
                    chord = "Dm ";
                else if (chordNumber == "3")
                    chord = "Em ";
                else if (chordNumber == "4")
                    chord = "F  ";
                else if (chordNumber == "5")
                    chord = "G  ";
                else if (chordNumber == "6")
                    chord = "Am ";
                break;
            case 2:
                if (chordNumber == "1")
                    chord = "G  ";
                else if (chordNumber == "2")
                    chord = "Am ";
                else if (chordNumber == "3")
                    chord = "Bm ";
                else if (chordNumber == "4")
                    chord = "C  ";
                else if (chordNumber == "5")
                    chord = "D  ";
                else if (chordNumber == "6")
                    chord = "Em ";
                break;
            case 3:
                if (chordNumber == "1")
                    chord = "D  ";
                else if (chordNumber == "2")
                    chord = "Em ";
                else if (chordNumber == "3")
                    chord = "F#m";
                else if (chordNumber == "4")
                    chord = "G  ";
                else if (chordNumber == "5")
                    chord = "A  ";
                else if (chordNumber == "6")
                    chord = "Bm ";
                break;
            case 4:
                if (chordNumber == "1")
                    chord = "A  ";
                else if (chordNumber == "2")
                    chord = "Bm ";
                else if (chordNumber == "3")
                    chord = "C#m";
                else if (chordNumber == "4")
                    chord = "D  ";
                else if (chordNumber == "5")
                    chord = "E  ";
                else if (chordNumber == "6")
                    chord = "F#m";
                break;
            case 5:
                if (chordNumber == "1")
                    chord = "E  ";
                else if (chordNumber == "2")
                    chord = "F#m";
                else if (chordNumber == "3")
                    chord = "G#m";
                else if (chordNumber == "4")
                    chord = "A  ";
                else if (chordNumber == "5")
                    chord = "B  ";
                else if (chordNumber == "6")
                    chord = "C#m";
                break;
            case 6:
                if (chordNumber == "1")
                    chord = "B  ";
                else if (chordNumber == "2")
                    chord = "C#m";
                else if (chordNumber == "3")
                    chord = "D#m";
                else if (chordNumber == "4")
                    chord = "E  ";
                else if (chordNumber == "5")
                    chord = "F# ";
                else if (chordNumber == "6")
                    chord = "G#m";
                break;
            case 7:
                if (chordNumber == "1")
                    chord = "F# ";
                else if (chordNumber == "2")
                    chord = "G#m";
                else if (chordNumber == "3")
                    chord = "A#m";
                else if (chordNumber == "4")
                    chord = "B  ";
                else if (chordNumber == "5")
                    chord = "C# ";
                else if (chordNumber == "6")
                    chord = "D#m";
                break;
            case 8:
                if (chordNumber == "1")
                    chord = "C# ";
                else if (chordNumber == "2")
                    chord = "D#m";
                else if (chordNumber == "3")
                    chord = "E#m";
                else if (chordNumber == "4")
                    chord = "F# ";
                else if (chordNumber == "5")
                    chord = "G# ";
                else if (chordNumber == "6")
                    chord = "A#m";
                break;
            case 9:
                if (chordNumber == "1")
                    chord = "F  ";
                else if (chordNumber == "2")
                    chord = "Gm ";
                else if (chordNumber == "3")
                    chord = "Am ";
                else if (chordNumber == "4")
                    chord = "Bb ";
                else if (chordNumber == "5")
                    chord = "C  ";
                else if (chordNumber == "6")
                    chord = "Dm ";
                break;
            case 10:
                if (chordNumber == "1")
                    chord = "Bb ";
                else if (chordNumber == "2")
                    chord = "Cm ";
                else if (chordNumber == "3")
                    chord = "Dm ";
                else if (chordNumber == "4")
                    chord = "Eb ";
                else if (chordNumber == "5")
                    chord = "F  ";
                else if (chordNumber == "6")
                    chord = "Gm ";
                break;
            case 11:
                if (chordNumber == "1")
                    chord = "Eb ";
                else if (chordNumber == "2")
                    chord = "Fm ";
                else if (chordNumber == "3")
                    chord = "Gm ";
                else if (chordNumber == "4")
                    chord = "Ab ";
                else if (chordNumber == "5")
                    chord = "Bb ";
                else if (chordNumber == "6")
                    chord = "Cm ";
                break;
            case 12:
                if (chordNumber == "1")
                    chord = "Ab ";
                else if (chordNumber == "2")
                    chord = "Bbm";
                else if (chordNumber == "3")
                    chord = "Cm ";
                else if (chordNumber == "4")
                    chord = "Db ";
                else if (chordNumber == "5")
                    chord = "Eb ";
                else if (chordNumber == "6")
                    chord = "Fm ";
                break;
            case 13:
                if (chordNumber == "1")
                    chord = "Am ";
                else if (chordNumber == "2")
                    chord = "B  ";
                else if (chordNumber == "3")
                    chord = "D  ";
                else if (chordNumber == "4")
                    chord = "Dm ";
                else if (chordNumber == "5")
                    chord = "Em ";
                else if (chordNumber == "6")
                    chord = "F  ";
                break;
            case 14:
                if (chordNumber == "1")
                    chord = "Em ";
                else if (chordNumber == "2")
                    chord = "F# ";
                else if (chordNumber == "3")
                    chord = "G  ";
                else if (chordNumber == "4")
                    chord = "Am ";
                else if (chordNumber == "5")
                    chord = "Bm ";
                else if (chordNumber == "6")
                    chord = "C  ";
                break;
            case 15:
                if (chordNumber == "1")
                    chord = "Bm ";
                else if (chordNumber == "2")
                    chord = "C# ";
                else if (chordNumber == "3")
                    chord = "D  ";
                else if (chordNumber == "4")
                    chord = "Em ";
                else if (chordNumber == "5")
                    chord = "F#m";
                else if (chordNumber == "6")
                    chord = "G  ";
                break;
            case 16:
                if (chordNumber == "1")
                    chord = "F#m";
                else if (chordNumber == "2")
                    chord = "G# ";
                else if (chordNumber == "3")
                    chord = "A  ";
                else if (chordNumber == "4")
                    chord = "Bm ";
                else if (chordNumber == "5")
                    chord = "C#m";
                else if (chordNumber == "6")
                    chord = "D  ";
                break;
            case 17:
                if (chordNumber == "1")
                    chord = "C#m";
                else if (chordNumber == "2")
                    chord = "D# ";
                else if (chordNumber == "3")
                    chord = "E  ";
                else if (chordNumber == "4")
                    chord = "F#m";
                else if (chordNumber == "5")
                    chord = "G#m";
                else if (chordNumber == "6")
                    chord = "A  ";
                break;
            case 18:
                if (chordNumber == "1")
                    chord = "G#m";
                else if (chordNumber == "2")
                    chord = "A# ";
                else if (chordNumber == "3")
                    chord = "B  ";
                else if (chordNumber == "4")
                    chord = "C#m";
                else if (chordNumber == "5")
                    chord = "D#m";
                else if (chordNumber == "6")
                    chord = "E  ";
                break;
            case 19:
                if (chordNumber == "1")
                    chord = "D#m";
                else if (chordNumber == "2")
                    chord = "E# ";
                else if (chordNumber == "3")
                    chord = "F# ";
                else if (chordNumber == "4")
                    chord = "G#m";
                else if (chordNumber == "5")
                    chord = "A#m";
                else if (chordNumber == "6")
                    chord = "B  ";
                break;
            case 20:
                if (chordNumber == "1")
                    chord = "A#m";
                else if (chordNumber == "2")
                    chord = "B# ";
                else if (chordNumber == "3")
                    chord = "C# ";
                else if (chordNumber == "4")
                    chord = "D#m";
                else if (chordNumber == "5")
                    chord = "E#m";
                else if (chordNumber == "6")
                    chord = "F# ";
                break;
            case 21:
                if (chordNumber == "1")
                    chord = "Dm ";
                else if (chordNumber == "2")
                    chord = "E  ";
                else if (chordNumber == "3")
                    chord = "F  ";
                else if (chordNumber == "4")
                    chord = "Gm ";
                else if (chordNumber == "5")
                    chord = "Am ";
                else if (chordNumber == "6")
                    chord = "Bb ";
                break;
            case 22:
                if (chordNumber == "1")
                    chord = "Gm ";
                else if (chordNumber == "2")
                    chord = "A  ";
                else if (chordNumber == "3")
                    chord = "Bb ";
                else if (chordNumber == "4")
                    chord = "Cm ";
                else if (chordNumber == "5")
                    chord = "Em ";
                else if (chordNumber == "6")
                    chord = "Db ";
                break;
            case 23:
                if (chordNumber == "1")
                    chord = "Cm ";
                else if (chordNumber == "2")
                    chord = "D  ";
                else if (chordNumber == "3")
                    chord = "Eb ";
                else if (chordNumber == "4")
                    chord = "Fm ";
                else if (chordNumber == "5")
                    chord = "Gm ";
                else if (chordNumber == "6")
                    chord = "Ab ";
                break;
            case 24:
                if (chordNumber == "1")
                    chord = "Fm ";
                else if (chordNumber == "2")
                    chord = "G  ";
                else if (chordNumber == "3")
                    chord = "Ab ";
                else if (chordNumber == "4")
                    chord = "Bbm ";
                else if (chordNumber == "5")
                    chord = "Cm ";
                else if (chordNumber == "6")
                    chord = "Db ";
                break;
        }
        return chord;
    }
} 