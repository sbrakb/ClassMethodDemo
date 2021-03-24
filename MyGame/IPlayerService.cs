using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IPlayerService
    {
        void Add(Player user);
        void Update(Player user);
        void Delete(Player user);
    }
}
