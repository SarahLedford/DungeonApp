﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlienAppLibrary;


namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Alien: Containment";
            bool exitGame = false;

            Console.WriteLine("Welcome to my game, and thank you for playing!\nAlien: Containment is created to be a unique experience every time you play. You never know when you're going to meet an enemy, or who it will be.\nYour goal is to survive long enough to initiate the security protocols to recapture the xenomorph or to kill it once and for all. The choice will be yours.\nEnjoy!\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("You start awake, trying to catch your breath, which seems just out of reach.\n" +
                "Alarms are blaring, lights strobing all around you. You only take a moment to ground yourself and remember where you are,\nand to realize what must have happened.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("It's out.");
            Console.ReadKey();
            Console.Clear();

            #region Logo
            Console.WriteLine(@"
              *    .  *       .             * *    .  *       .             *
                                     * *   .        *       .       .       
             *   .        *       .       .       *
               .     *
                       .     .  *        *             .  *           *                     
                   .                .        .
            .  *           *                     *
                                         .                   .   *        
              ___  _ *          .   *                                                  
             / _ \| (_)                                                                           
            / /_\ \ |_  ___ _ __    *    .  *       .             *                         
            |  _  | | |/ _ \ '_ \  ()                      *                                  
            | | | | | |  __/ | | |    *   .        *       .       .       *
            \_| |_/_|_|\___|_| |_| ().     *                                                              
                       .     .  *        *           .     .  *        *
            .  *           *                     *.  *           *                                        
             _____   *   .   * _        _                            _   
            /  __ \  .     *  | |      (_) *   .     *     .       *| |  
            | /  \/ ___  _ __ | |_ __ _ _ _ __  _ __ ___   ___ _ __ | |_ 
            | |    / _ \| '_ \| __/ _` | | '_ \| '_ ` _ \ / _ \ '_ \| __|
            | \__/\ (_) | | | | || (_| | | | | | | | | | |  __/ | | | |_ 
             \____/\___/|_| |_|\__\__,_|_|_| |_|_| |_| |_|\___|_| |_|\__|
              *    .  *       .             *          *          .   *
                                     *
             *   .        *       .       .       * .  *           *                     
               .     *
                       .     .  *        *        .                .        .
                   .                .        .
            .  *           *                     *
                                         .              *          .   *
                     *          .   *
            ");
            #endregion

            do
            {
                Room start = new Room("Women's CryoSleep Quarters", "There are cryosleep chambers all around you. They were supposed to be holding your crewmembers, but they aren't there. There's blood on one of the chambers. You throw on a pair of sweats and a shirt that you had set out for yourself before you went to sleep. Your gun is there also.\nTime to see what it can do.", true);
                Room storage = new Room("Storage Room", "The storage room is a dead end, but you didn't come here to hide. You look around for anything that might help you a little bit more than this measly handgun they issued you. Everyone knew they were just for show, that they wouldn't do anything substantial against the creature, despite what the Company said. You didn't want to take any chances.\n" +
                    "Your eyes scan the room as you quickly shuffle through the content scattered on the shelves when something catches your eye -- a flamethrower in the corner.\n" +
                    "You don't know why it's there or if it even works, but it has to be better than the handgun, right?", false);//TODO storage description
                Room common = new Room("Common Area", "So many fond memories. You find it surprisingly difficult not to reminisce even amidst all of the madness unfolding around you. This room is where some of your fondest memories have come from -- laughing like fools, fighting like even bigger fools. The entire crew is the only family you have. You push the thoughts down and press forward.\nIt feels like every sound is amplified by a thousand. Every noise you make, you are hyper-aware of. You hope it's just the adrenaline pumping through you, but you can't help but feel like you're being watched.", false);
                Room bathroom = new Room("Bathrooms", "There is more blood streaking the floor, leading from the shower. You wonder if someone was taking a shower when they got attacked, or if it was their only place to hide. If it was, you suppose it wasn't good enough.", false);
                Room mensQuarters = new Room("Men's Quarters Hall", "You have to see if anyone might still be alive. The Company doesn't want to deal with any pregnancy complications on these long missions, so they make sure only men can get into the men's quarters and vice versa. You try as hard as you can to manually open the doors, but something's blocking it from the inside.", false);
                Room messHall = new Room("Mess Hall", "There has clearly been a struggle here. Empty trays clutter the floor and the salt and pepper are still rolling from their fall. Whoever was here isn't far.", false);
                Room kitchen = new Room("Kitchen", "The top half of one of the ship's androids is slouched in the corner, white liquid slithering its way across the floor. It's still twitching every now and then, but it's clear that there's nothing left of it. Whatever did that, you don't want to be around to meet it, though you already know what did it.\nYou search the room for any knives or other helpful tools that you could take with you as an extra precaution. You curse to yourself as you come up empty-handed, cursing the androids that usually make the meals. There's no way of telling where they kept them, but you were sure you had seen some knives here before. Where would they have taken them?", false);
                Room observationRoom = new Room("Observation Room", "You enter the room with extreme caution. It's dark, lit intermittently only by the strobing emergency lights. Your hand flies up to your mouth as you try to suppress a scream, throwing up, maybe both.\nYou aren't alone here. Your crewmates lie slumped, bloodied, and lifeless all around you. The creature brought them all back here. It didn't try to incubate them, but instead killed them and left them here to rot. It seemed symbolic, as if it was telling them to observe the last act they would ever see it do.\nThe studies were over.", false);
                Room containment = new Room("Containment Room", "You shiver as you enter. You shouldn't be here. No one should have been there. There are eggs all around. You won't survive if you didn't pick up the flamethrower in the other room", false);//TODO finish containment room description properly
                Room cargoBay = new Room("Cargo Bay", "Here is where you will face the xenomorph and either capture it for study or kill it", false);//TODO finish Cargo Bay description
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(start);
                Console.ReadKey();
                do
                {

                    #region Starting Room
                    while (start.IsCurrentRoom == true)
                    {

                        Console.Clear();
                        Console.WriteLine("The women's quarters exit into a hallway.\n" +
                            "1. Check storage room for supplies\n" +
                            "2. Enter common area\n" +
                            "3. Enter bathroom\n" +
                            "4. Go back\n" +
                            "5. Map\n" +
                            "6. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                storage.IsCurrentRoom = true;
                                start.IsCurrentRoom = false;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                common.IsCurrentRoom = true;
                                start.IsCurrentRoom = false;
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                bathroom.IsCurrentRoom = true;
                                start.IsCurrentRoom = false;
                                break;
                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                Console.WriteLine("You can't go back. If this thing doesn't get taken care of, you're as good as dead.");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.startingPoint);
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D6:
                            case ConsoleKey.NumPad6:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:

                                        start.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end start

                    #endregion

                    #region storage room
                    while (storage.IsCurrentRoom == true)
                    {

                        Console.Clear();
                        Console.WriteLine($"{storage}\n" +
                            $"1. Take flamethrower\n" +
                            $"2. Keep looking\n" +
                            $"3. Go back to women's quarters\n" +
                            $"4. Map\n" +
                            $"5. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Console.WriteLine("You took the flamethrower");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Console.WriteLine("You keep looking");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                storage.IsCurrentRoom = false;
                                start.IsCurrentRoom = true;
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.storageRoom);
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        storage.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end storage 
                    #endregion

                    #region Common Room
                    while (common.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{common}\n" +
                            $"1. Enter mess hall\n" +
                            $"2. Enter men's quarters\n" +
                            $"3. Go back to women's quarters\n" +
                            $"4. Map\n" +
                            $"5. Exit");

                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Console.WriteLine("You try to exit the the common area, but the door that leads that way is jammed.");
                                Console.ReadKey();
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Console.WriteLine("You try to exit the the common area, but the door that leads that way is jammed.");
                                Console.ReadKey();
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                common.IsCurrentRoom = false;
                                start.IsCurrentRoom = true;
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.commonArea);
                                Console.ReadKey();
                                break;

                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:

                                        common.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end Common Area 
                    #endregion

                    #region Bathroom
                    while (bathroom.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{bathroom}\n" +
                            $"1. Enter men's quarters\n" +
                            $"2. Enter common area\n" +
                            $"3. Enter mess hall\n" +
                            $"4. Go back to women's quarters\n" +
                            $"5. Map\n" +
                            $"6. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                bathroom.IsCurrentRoom = false;
                                mensQuarters.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Console.WriteLine("You try to open the common area door, but something is jamming the mechanism. You try to force it, but it's no use.");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                bathroom.IsCurrentRoom = false;
                                messHall.IsCurrentRoom = true;
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                bathroom.IsCurrentRoom = false;
                                start.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.bathroom);
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D6:
                            case ConsoleKey.NumPad6:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        bathroom.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end bathroom 
                    #endregion

                    #region Mens Quarters
                    while (mensQuarters.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{mensQuarters}\n" +
                            $"1. Enter common area\n" +
                            $"2. Enter mess hall\n" +
                            $"3. Go back to bathroom\n" +
                            $"4. Map\n" +
                            $"5. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Console.WriteLine("You try to open the common area door, but something is jamming the mechanism. You try to force it, but it's no use.");
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                mensQuarters.IsCurrentRoom = false;
                                messHall.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                mensQuarters.IsCurrentRoom = false;
                                bathroom.IsCurrentRoom = true;
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.mensQuartersHall);
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        mensQuarters.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end Mens Quarters 
                    #endregion

                    #region Mess Hall
                    while (messHall.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{messHall}\n" +
                            $"1. Enter observation room\n" +
                            $"2. Enter kitchen\n" +
                            $"3. Go back to mens quarters\n" +
                            $"4. Go back to bathroom\n" +
                            $"5. Map\n" +
                            $"6. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                messHall.IsCurrentRoom = false;
                                observationRoom.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                messHall.IsCurrentRoom = false;
                                kitchen.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                messHall.IsCurrentRoom = false;
                                mensQuarters.IsCurrentRoom = true;
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                messHall.IsCurrentRoom = false;
                                bathroom.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.messHall);
                                Console.ReadKey();
                                break;

                            case ConsoleKey.D6:
                            case ConsoleKey.NumPad6:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        messHall.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }//end exit switch
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end Mess Hall 
                    #endregion

                    #region Kitchen
                    while (kitchen.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{kitchen}\n" +
                            $"1. Enter cargo bay\n" +
                            $"2. Go back to mess hall\n" +
                            $"3. Map\n" +
                            $"4. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                kitchen.IsCurrentRoom = false;
                                cargoBay.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                kitchen.IsCurrentRoom = false;
                                messHall.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.kitchen);
                                Console.ReadKey();
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        kitchen.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end Kitchen 
                    #endregion

                    #region Observation Room
                    while (observationRoom.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{observationRoom}\n" +
                            $"1. Enter containment room\n" +
                            $"2. Go back to mess hall\n" +
                            $"3. Map\n" +
                            $"4. Exit");//TODO add healing!!
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                observationRoom.IsCurrentRoom = false;
                                containment.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                observationRoom.IsCurrentRoom = false;
                                messHall.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.observationRoom);
                                Console.ReadKey();
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        observationRoom.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }//end Observation Room 
                    #endregion

                    #region Containment
                    while (containment.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{containment}\n" +
                            $"1. Go back to observation room\n" +
                            $"2. Map\n" +
                            $"3. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                containment.IsCurrentRoom = false;
                                observationRoom.IsCurrentRoom = true;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                PlayerMaps.Map(MapRoom.containmentRoom);
                                Console.ReadKey();
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        containment.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }
                    #endregion

                    #region Cargo Bay
                    while (cargoBay.IsCurrentRoom == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{cargoBay}\n" +
                            $"1. Kill\n" +
                            $"2. Capture\n" +
                            $"3. Exit");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Console.WriteLine("You kill the alien");
                                Console.ReadKey();
                                break;//TODO add functionality to kill alien
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Console.WriteLine("You captured the alien");
                                Console.ReadKey();
                                break;//TODO add functionality to capture the alien
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                Console.WriteLine("If you exit, all progress will be lost. Are you sure?\n1. Yes\n2. No");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.NumPad1:
                                    case ConsoleKey.D1:
                                        cargoBay.IsCurrentRoom = false;
                                        exitGame = true;
                                        break;

                                    case ConsoleKey.NumPad2:
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                                break;

                            default:
                                Console.Clear();
                                break;
                        }//end switch
                    }
                    #endregion 
                } while (start.IsCurrentRoom == true || storage.IsCurrentRoom == true || common.IsCurrentRoom == true || bathroom.IsCurrentRoom == true || mensQuarters.IsCurrentRoom == true || messHall.IsCurrentRoom == true || kitchen.IsCurrentRoom == true || observationRoom.IsCurrentRoom == true || containment.IsCurrentRoom == true || cargoBay.IsCurrentRoom == true);//end while rooms true
            } while (exitGame != true);
            Console.Clear();
            Console.WriteLine("You are now exiting the game. Thank you for playing!");
        }//end Main()
    }//end class
}//end namespace
