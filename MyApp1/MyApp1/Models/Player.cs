using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp1.Models
{
    public class Player:PersonModel
    {
        public string Summary
        {
            get { return String.Format("{0} {1}", Firstname, Lastname); }
        }
    }
}
