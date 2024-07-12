﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02C_
{
    internal class Car
    {
           #region Properties
    public int Id { get; set; }
    public string Model { get; set; }
    public double Speed { get; set; }
        #endregion

        public Car(int id, string model, int Sseed)
        {
            Id = id;
            Model = model;
            Speed = Sseed;
        }
        public override string ToString()
        {
            return $"CarId : {Id}\nModel : {Model}\nSpeed : {Speed}";
        }
    }
}
