﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " " + "Oyunu Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " " + "Oyunu Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " " + "Oyunu Güncellendi");
        }
    }
}
