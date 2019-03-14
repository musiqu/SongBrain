/*	SongBrain - SongBuilder.cs, Quinn Schroeder.
 *      (c) 2017-2018 All Rights Reserved.	
 */

using System;
using System.Collections.Generic;

class SongBuilder
{
    private int ChordAmount { get; } //stores the chordAmount
    private int Template { get; set; } //stores the template id
    private string[] templateArray;  //stores the song's template
    private KeySignature key = new KeySignature();
    private List<string> progressionArray = new List<string>();
    private List<string> labelArray = new List<string>();

    public SongBuilder()
    {
        ChordAmount = 4;  //each progression in the song will have 4 chords
    }

    public void MakeSong()
    {
        key.SetKeySignature();  //assign a key signature for the song

        Console.WriteLine();
        Menus.displayTemplateMenu(); //display the song template menu

        Template = InputChecker.IntegerCheck("\n  Please choose a song template from the "
            + "display above.  ", 1, 7);

        LoadTemplate();
    }

    public void DisplaySong()
    {
        int progCounter;

        Console.WriteLine($"\n\n  Your {key.KeyLabel} song is:\n");
        Console.Write("  ");
        TemplateDescription();  //displays the song parts
        Console.WriteLine();
        Console.Write("  ");

        //displays the chord progressions
        progCounter = 0; 
   
        foreach (var progression in progressionArray)
        {
            if (progCounter != 0 && progCounter % ChordAmount == 0)
                Console.Write("-   ");

            Console.Write($"{progression}   ");
            progCounter++;
        }
        Console.WriteLine();

        progCounter = 0;

        Console.Write("  ");
        foreach (var label in labelArray)
        {
            if (progCounter != 0 && progCounter % ChordAmount == 0)
                Console.Write("-   ");

            Console.Write($"{label} ");
            progCounter++;
        }
        Console.WriteLine("\n");
    }

    private void LoadTemplate()
    {
        string[] template1 = { "V", "C", "V2", "C2", "B", "C2", };
        string[] template2 = { "V", "P", "C", "V2", "P2", "C2", "B", "C2" };
        string[] template3 = { "V", "V2", "C", "B", "C2" };
        string[] template4 = { "C", "V", "C2", "V2", "C2", "B", "C2" };
        string[] template5 = { "V", "C", "V2", "C2", "V2", "C2" };
        string[] template6 = { "V", "V2", "C", "V2", "C2" };
        string[] template7 = { "V", "V2", "C", "V2" };

        //create the progression objects
        Progression verseChords = new Progression(ChordAmount, key);
        Progression preChorusChords = new Progression(ChordAmount, key);
        Progression chorusChords = new Progression(ChordAmount, key);
        Progression bridgeChords = new Progression(ChordAmount, key);

        if (Template == 1)
            templateArray = template1;
        else if (Template == 2)
            templateArray = template2;
        else if (Template == 3)
            templateArray = template3;
        else if (Template == 4)
            templateArray = template4;
        else if (Template == 5)
            templateArray = template5;
        else if (Template == 6)
            templateArray = template6;
        else
            templateArray = template7;

        // load the songArray    
        foreach (string part in templateArray)
        {
            switch (part)
            {
                case "V":
                    verseChords.LoadChords();  //create Verse progression
                    foreach (string chord in verseChords.ChordArray)
                    {
                        progressionArray.Add(chord);
                    }

                    foreach(string label in verseChords.ChordLabels)
                    {
                        labelArray.Add(label);
                    }
                    break;

                case "V2":
                    foreach (string chord in verseChords.ChordArray)
                    {
                        progressionArray.Add(chord);
                    }

                    foreach (string label in verseChords.ChordLabels)
                    {
                        labelArray.Add(label);
                    }
                    break;

                case "P":
                    preChorusChords.LoadChords();  //create Pre-Chorus progression
                    foreach (string chord in preChorusChords.ChordArray)
                    {
                        progressionArray.Add(chord);
                    }

                    foreach (string label in preChorusChords.ChordLabels)
                    {
                        labelArray.Add(label);
                    }
                    break;

                case "P2":
                    foreach (string chord in preChorusChords.ChordArray)
                    {
                        progressionArray.Add(chord);
                    }

                    foreach (string label in preChorusChords.ChordLabels)
                    {
                        labelArray.Add(label);
                    }
                    break;

                case "C":
                    chorusChords.LoadChords();  //create Chorus progression
                    foreach (string chord in chorusChords.ChordArray)
                    {
                        progressionArray.Add(chord);
                    }

                    foreach (string label in chorusChords.ChordLabels)
                    {
                        labelArray.Add(label);
                    }
                    break;

                case "C2":
                    foreach (string chord in chorusChords.ChordArray)
                    {
                        progressionArray.Add(chord);
                    }

                    foreach (string label in chorusChords.ChordLabels)
                    {
                        labelArray.Add(label);
                    }
                    break;

                case "B":
                    bridgeChords.LoadChords();  //create Bridge progression
                    foreach (string chord in bridgeChords.ChordArray)
                    {
                        progressionArray.Add(chord);
                    }

                    foreach (string label in bridgeChords.ChordLabels)
                    {
                        labelArray.Add(label);
                    }
                    break;
            }
        }
    }

    private void TemplateDescription()
    {
        var verseCount = 1;
        var preChorusCount = 1;
        var chorusCount = 1;

        foreach (string part in templateArray)
        {
            switch (part)
            {
                case "V":
                    Console.Write("Verse 1             ");
                    verseCount++;
                    break;

                case "V2":
                    Console.Write("Verse " + verseCount + "             ");
                    verseCount++;
                    break;

                case "P":
                    Console.Write("Pre-Chorus 1        ");
                    preChorusCount++;
                    break;

                case "P2":
                    Console.Write("Pre-Chorus " + preChorusCount + "        ");
                    verseCount++;
                    break;

                case "C":
                    Console.Write("Chorus 1            ");
                    chorusCount++;
                    break;

                case "C2":
                    Console.Write("Chorus " + chorusCount + "            ");
                    chorusCount++;
                    break;

                case "B":
                    Console.Write("Bridge              ");
                    break;
            }
        }
    }
}