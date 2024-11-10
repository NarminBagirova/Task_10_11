﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Speed {  get; set; }
        public string CarCode {  get; set; }

        public Car(int id, string name, int speed, int creationOrder) 
        {
            Id = id;    
            Name = name;
            Speed = speed;
            CarCode=name.Substring(0,2).ToUpper()+(1000+creationOrder).ToString();
        }
    }


}
