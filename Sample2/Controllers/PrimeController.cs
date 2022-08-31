﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace Sample2.Controllers
{
    public class PrimeController : Controller
    {
        [HttpGet]
        public int GetNext(int prevNumber)
        {
            return Calculation(prevNumber);
        }

        private int Calculation(int number)
        {
            while (true)
            {
                bool isPrime = true;
                //increment the number by 1 each time
                number = number + 1;

                int squaredNumber = (int)Math.Sqrt(number);

                //start at 2 and increment by 1 until it gets to the squared number
                for (int i = 2; i <= squaredNumber; i++)
                {
                    //how do I check all i's?
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    return number;
            }
        }
    }
}
