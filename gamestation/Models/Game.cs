using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestation.Models
{
    public class Game
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsCheckedOut { get; set; }
    }
}