﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelocationTests
{
    public class Implementation
    {
        Dictionary<int, int> Companies;

        public Implementation(Dictionary<int, int> initialCompanies)
        {
            Companies = initialCompanies;
        }

        public void Move(int company, int position)
        {
            Companies[company] = position;
        }

        public int Distance(int companyOne, int companyTWo)
        {
            int positionOne = Companies[companyOne];
            int positionTwo = Companies[companyTWo];
            if(positionOne > positionTwo)
            {
                return positionOne - positionTwo;
            }
            else if(positionTwo > positionOne)
            {
                return positionTwo - positionOne;
            }
            else
            {
                return 0;
            }
        }

        public static Implementation GetImplementation(string setupLineOne, string setupLineTwo, out int numRequests)
        {
            int[] lineOneValues = setupLineOne.Split(' ').Select(c => int.Parse(c)).ToArray();
            int numCompanies = lineOneValues[0];
            numRequests = lineOneValues[1];

            int[] lineTwoValues = setupLineTwo.Split(' ').Select(c => int.Parse(c)).ToArray();

            Dictionary<int, int> initial = new Dictionary<int, int>();

            foreach(int i in Enumerable.Range(1, numCompanies))
            {
                initial.Add(i, lineTwoValues[i - 1]);
            }

            return new Implementation(initial);
        }
    }
}
