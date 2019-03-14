/*	SongBrain - SongBrainApp.cs, Quinn Schroeder.
 *      (c) 2017-2018 All Rights Reserved.	
 */

using System;
using System.Threading;

class SongBrainApp
{
    static void Main()
    {
        var input = "";
        
        //set the window size
        Console.SetWindowSize(165,35);

        //display version number and Main Menu
        Console.WriteLine("\n\n\t   SongBrain (version 1.3.052718)\n");
        Menus.DisplayMainMenu();

        //start while loop that controls termination of program
        while (input != "exit")
        {
            Console.Write("\n  Enter your selection here:    ");

            //get input from the user and convert it to lower case
            input = Console.ReadLine().ToLower();
            Console.WriteLine();
            
            switch (input)
            {
                case "prog":

                    Progression prog = new Progression();  //create a Progression object

                    prog.MakeProgression();  //Create the chord progression
                    prog.DisplayProgression();  //display the chord progression
                    Console.WriteLine("\n  **Type \"MENU\" to display program options.**");
                    break;

                case "song":

                    SongBuilder song = new SongBuilder();  //create a SongBuilder object

                    song.MakeSong();
                    song.DisplaySong();
                    Console.WriteLine("\n  **Type \"MENU\" to display program options.**");
                    break;

                case "menu":
                    Menus.DisplayMainMenu();
                    break;

                case "info":
                    var info = "  SongBrain by Quinn Schroeder.\n"
                             + "  Version 1.3.0 (c) 2018 All Rights Reserved.\n";

                    Console.Write(info);
                    Console.WriteLine("\n  **Type \"MENU\" to display program options.**");
                    break;

                case "exit":
                    var endMessage = "  * * * * * * * * * * * * * * * * * * *\n"
                                   + "  *   Thank you for using SongBrain.  *\n"
                                   + "  *         See you next time!        *\n"
                                   + "  * * * * * * * * * * * * * * * * * * *\n";

                    Console.WriteLine(endMessage);

                    // pause the program for 3 seconds before closing

                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("  ***ERROR: Please enter a correct value from the Main Menu.\n");
                    break;
            }
        }
    }


}
        /*       
        while (!choice.equalsIgnoreCase("Exit"))
        {

            choice = InputValidator.getString(sc, "  Type Selection Here ->  ");
            System.out.println();

            if (choice.equalsIgnoreCase("Prog"))
            {
                while (!choice.equalsIgnoreCase("N"))
                {
                    *
                    *
                    * 
                    //ask the user to choose a key signature
                    key = KeySignature.getKeySignature();
                    
                    keyName = KeySignature.keyName(key);

                    if (key <= 12)
                        keyType = " Major";
                    else
                        keyType = " minor";
                    
                    pg.run(chordAmount); // call the generator program

                    //print the chord progression array
                    System.out.println();
                    System.out.println("  Your " + pg.keyName + pg.keyType
                            + " chord progression is:\n"); 
                    
                    System.out.print("  ");
                    for (int i = 0; i < pg.chordArray.size(); i++)
                    {
                        System.out.print(pg.chordArray.get(i) + "   ");
                    }
                    System.out.println();
                    
                    System.out.print("  ");
                    for (int i = 0; i < pg.chordArray.size(); i++)
                    {
                        System.out.print(
                                KeySignature.translateChord(pg.chordArray.get(i),
                                       pg.key) + " ");
                    }
                    System.out.println("\n");             

                    //ask the user if they would like to generate another progression
                    choice = InputValidator.getString(sc,
                            "  Would you like to generate another progression?"
                          + " (\"Y\" or \"N\") ->  ", "Y", "N");
                    System.out.println();
                }
            }
            
            else if (choice.equalsIgnoreCase("Song"))
                while (!choice.equalsIgnoreCase("N"))
                {
                    //create a SongBuilder object
                    SongBuilder sb = new SongBuilder();
                    
                    sb.run();

                    System.out.println("\n");
                    
                    //ask the user if they would like to create another song
                    choice = InputValidator.getString(sc,
                            "  Would you like to create another song?"
                          + " (\"Y\" or \"N\") ->  ", "Y", "N");
                    System.out.println();
                }
            
            else if (choice.equalsIgnoreCase("Menu"))
                Menu.displayMenu(); // display the Menu
            
            else if (choice.equalsIgnoreCase("Info"))
                Info.getInfo(); // list program information
            
            else if (choice.equalsIgnoreCase("Exit"))
            {
                String endMessage;
                endMessage =  "  * * * * * * * * * * * * * * * * * * *\n"
                            + "  *   Thank you for using SongBrain.  *\n"
                            + "  *         See you next time!        *\n"
                            + "  * * * * * * * * * * * * * * * * * * *\n";
                
                System.out.println(endMessage);
                // pause the program for 3 seconds before closing
                try        
                {
                    Thread.sleep(3000);
                } 
                catch(InterruptedException ex) 
                {
                    Thread.currentThread().interrupt();
                }
            }
            else
                System.out.println(
                        "  *** Error! Your selection was not valid. ***\n\n");
        }
         */