﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson3
{
    internal class Boy
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public string Koko { get; set; }
        public bool boolen { get; set; }
        //ctor
        public Boy(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public Boy(int age, string name,string koko)
         :this(age,name)
        {
            Koko = koko;

        }

        public Boy(int age, string name)
        {
            Name = name;
            Age = age;

        }










}
}
