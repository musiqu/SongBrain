/*	SongBrain - Menus.cs, Quinn Schroeder.
 *      (c) 2017-2018 All Rights Reserved.	
 */

using System;

class Menus
{
    public static void DisplayMainMenu()
    {
        var mainMenu = "  * * * * * * * * * * * MENU * * * * * * * * * * *\n"
                     + "  *                                              *\n"
                     + "  * Please make a selection from the list below. *\n"
                     + "  *                                              *\n"
                     + "  * Type            ...For this to occur         *\n"
                     + "  * ----      ---------------------------------- *\n"
                     + "  *                                              *\n"
                     + "  * PROG  ->  Create a New Chord Progression     *\n"
                     + "  * SONG  ->  Create Progressions for a Song     *\n"
                     + "  * MENU  ->  Display This Menu                  *\n"
                     + "  * INFO  ->  Display Program Information        *\n"
                     + "  * EXIT  ->  Exit SongBrain                     *\n"
                     + "  *                                              *\n"
                     + "  * * * * * * * * * * * *^^* * * * * * * * * * * *\n";

        Console.Write(mainMenu);
    }

    public static void DisplayKeyMenu()
    {
        var keyMenu = "  * * * * * * * * * * * *  Key Signature  * * * * * * * * * * * *\n"
                    + "  *                                                             *\n"
                    + "  *      * Major Key *                     * Minor Key *        *\n"
                    + "  *  1 - C   5 - E    9 - F    |   13 - Am   17 - C#m  21 - Dm  *\n"
                    + "  *  2 - G   6 - B   10 - Bb   |   14 - Em   18 - G#m  22 - Gm  *\n"
                    + "  *  3 - D   7 - F#  11 - Eb   |   15 - Bm   19 - D#m  23 - Cm  *\n"
                    + "  *  4 - A   8 - C#  12 - Ab   |   16 - F#m  20 - A#m  24 - Fm  *\n"
                    + "  *                                                             *\n"
                    + "  *  25 - Random Major Key                                      *\n"
                    + "  *  26 - Random minor Key                                      *\n"
                    + "  *  27 - Random Key (Major or minor)                           *\n"
                    + "  *                                                             *\n"
                    + "  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n";

        Console.Write(keyMenu);
    }

    public static void displayTemplateMenu()
    {
        var templateMenu = 
            "  * * * * * * * * * * * * * * Song Templates * * * * * * * * * * * * * *\n"
          + "  *                                                                    *\n"
          + "  * 1 - Verse_Chorus_Verse_Chorus_Bridge_Chorus                        *\n"
          + "  * 2 - Verse_Pre-Chorus_Chorus_Verse_Pre-Chorus_Chorus_Bridge_Chorus  *\n"
          + "  * 3 - Verse_Verse_Chorus_Bridge_Chorus                               *\n"
          + "  * 4 - Chorus_Verse_Chorus_Verse_Chorus_Bridge_Chorus                 *\n"
          + "  * 5 - Verse_Chorus_Verse_Chorus_Verse_Chorus                         *\n"
          + "  * 6 - Verse_Verse_Chorus_Verse_Chorus                                *\n"
          + "  * 7 - Verse_Verse_Chorus_Verse                                       *\n"
          + "  *                                                                    *\n"
          + "  * * * * * * * * * * * * * * * *^^^^* * * * * * * * * * * * * * * * * *\n";

        Console.Write(templateMenu);
    }
}