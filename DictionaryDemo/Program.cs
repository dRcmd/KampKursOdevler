using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kapı açık(true)-kapalı(false) listesi
            MyDictionary<string, bool> doors = new MyDictionary<string, bool>();
            
            doors.Add("door1",true);
            doors.Add("door2",false);
            doors.Add("door3", true);
            doors.Add("door4", true);
            doors.Add("door5", false);
            doors.Add("door6", true);

            

        }
    }
}
