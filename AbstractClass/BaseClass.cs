﻿using System;

namespace AbstractClass
{
    public abstract class BaseClass   // Abstract class
    {
        protected int _x = 100;
        protected int _y = 150;
        public abstract void AbstractMethod();   // Abstract method

        public void NonOverriden()
        {
            Console.WriteLine("BaseClass-NonOverriden");
        }
        
      

    }
}