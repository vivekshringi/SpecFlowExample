using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example {


    public class Calculator {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }

 

        public int Add() {
            return FirstNumber + SecondNumber;
        }
        public int deduct() {
            return FirstNumber - SecondNumber;
        }

        public int power() {
            int a = FirstNumber;
            for(int i = 1; i < SecondNumber; i++)
            {
                a = a * FirstNumber;
            }
            return a;
        }

        public int mul() {
            return FirstNumber * SecondNumber;
        }

        public int div() {
            return FirstNumber / SecondNumber;
        }

        public int mod()
        {
            return FirstNumber % SecondNumber;
        }


        public int random()
        {
            Random r = new Random();
            return r.Next(FirstNumber, SecondNumber);
        }

    }

}