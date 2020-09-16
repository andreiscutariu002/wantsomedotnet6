using _01AdoNetSimpleProject.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _05GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = new List<int>();
            List<string> listOfStrings = new List<string>(); 
            List<Publisher> listOfPublishers = new List<Publisher>();

            listOfPublishers.Add(new Publisher());

            //listOfPublishers.Add(10);

            ArrayList list = new ArrayList();

            list.Add(19);
            list.Add("data");
            list.Add(new Publisher());

            var data = list[1];
        }
    }
}
