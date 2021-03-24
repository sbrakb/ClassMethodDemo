using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    interface IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public int BirthDate { get; set; }
        public long IdentityNumber { get; set; }
    }
}
