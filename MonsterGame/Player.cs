﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Player : Stats
    {
        static Random rnd = new Random();
        public static string Name { get; set; }
        public static int Hp { get; set; }
        public static int DmgLowest { get; set; }
        public static Room CurrentRoom { get; set; }
        public static int RunAway { get; set; }

        public static int Attack()
        {
            return rnd.Next(DmgLowest, DmgLowest + 10);
        }

        public static void ResetHealth()
        {
            Console.WriteLine("Health regenerated");
            Player.Hp = 100;
        }

        public static void EndLife()
        {
            Dialogue.EndingDialogue();
            Environment.Exit(0);
        }
    }
}
