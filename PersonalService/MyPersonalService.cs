﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalService
{
    public class MyPersonalService : IMyPersonalService
    {
        public void RunMyTask()
        {
            Console.WriteLine($"This task is run from MyPersonalService: {DateTime.Now.ToString("DD MMM yyy HH:mm:ss")}!!!");
        }
        public void RunMyTask2()
        {
            Console.WriteLine($"This task is run from MyPersonalService RunMyTask2: {DateTime.Now.ToString("DD MMM yyy HH:mm:ss")}!!!");
        }
    }
}
