/*	SongBrain - KeySignature.cs, Quinn Schroeder.
 *      (c) 2017-2018 All Rights Reserved.	
 */
using System;

class KeySignature
{
    private int keyNumber;      //stores key number from key menu
    private string keyLabel;    //stores the key label (key name + Major/minor)

    //KeySignature constructor
    public KeySignature()
    {
        keyNumber = 0;
        keyLabel = "";
    }

    //keyNumber property
    public int KeyNumber
    {
        get
        {
            return keyNumber;
        }
        private set
        {
            keyNumber = value;
        }
    }

    //keyLable property
    public string KeyLabel
    {
        get
        {
            return keyLabel;
        }
        private set
        {
            keyLabel = value;
        }
    }

    public void SetKeySignature()
    {
        Random randomNumber = new Random();  //create randomNumber object

        Menus.DisplayKeyMenu();

        keyNumber = InputChecker.IntegerCheck("\n  Please choose a key signature from the "
            + "display above.  ", 1, 27);

        // calculate keyNumber variable for random selections
        if (keyNumber == 25)
        {
            keyNumber = randomNumber.Next(1, 12);  //random Major key
        }
        else if (keyNumber == 26)
        {
            keyNumber = randomNumber.Next(13, 24);  //random minor key
        }
        else if (keyNumber == 27)
        {
            keyNumber = randomNumber.Next(1, 24);  //random all keys
        }

        SetKeyName(keyNumber);  //set the keyLabel value

        //append the keyType value
        if (keyNumber <= 12)
            keyLabel += " Major";
        else
            keyLabel += " minor";
    }

    private void SetKeyName(int keyNum)
    {
        switch (keyNum)
        {
            case 1:
            case 23:
                keyLabel = "C";
                break;
            case 2:
            case 22:
                keyLabel = "G";
                break;
            case 3:
            case 21:
                keyLabel = "D";
                break;
            case 4:
            case 13:
                keyLabel = "A";
                break;
            case 5:
            case 14:
                keyLabel = "E";
                break;
            case 6:
            case 15:
                keyLabel = "B";
                break;
            case 7:
            case 16:
                keyLabel = "F#";
                break;
            case 8:
            case 17:
                keyLabel = "C#";
                break;
            case 9:
            case 24:
                keyLabel = "F";
                break;
            case 10:
                keyLabel = "Bb";
                break;
            case 11:
                keyLabel = "Eb";
                break;
            case 12:
                keyLabel = "Ab";
                break;
            case 18:
                keyLabel = "G#";
                break;
            case 19:
                keyLabel = "D#";
                break;
            case 20:
                keyLabel = "A#";
                break;
        }
    }
}