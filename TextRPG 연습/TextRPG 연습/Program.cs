﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_연습
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame maingame = new MainGame();
            maingame.FirstPlayer();
            maingame.MainProgram();
        }
    }
}
