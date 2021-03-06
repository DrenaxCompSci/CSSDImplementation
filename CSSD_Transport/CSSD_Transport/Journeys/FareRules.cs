﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Util;

namespace CSSD_Transport.Journeys
{
	public class FareRules
	{
		private const float minAmount = 5.0f; 
		private const int dayPassNum = 1;
		private const float costPerStation = 0.75f;
        private const float dayPassCost = 7.0f;


        private static FareRules aFareRule;

		FareRules() { }

        // Singleton
        public static FareRules Instance
        {
            get
            {
                if (aFareRule == null)
                {
                    aFareRule = new FareRules();
                }
                return aFareRule;
            }
        }

		///<summary>Calculates the fare for a joruney between two stations</summary>
		///<param name = "lineName" >String: the name of the RailLine</param>
		///<param name = "line" >The name of the line to travel on</param>
		///<param name = "from" >Name of starting station</param>
		///<param name = "to" >Name of destination station</param>
		///<returns>Returns the fare as a float based on the distance and cost per station</returns>
		public float calculateFare(string lineName, string from, string to)
		{
			int distance = RailMap.Instance.getDistance(lineName, from, to);
			return (distance * costPerStation);
        }

		public float calculateDiscount(int n)
		{
            //needs implementing
			return dayPassCost;
		}

		public float getMinAmount() => minAmount;

        public float getDayPassCost() => dayPassCost;

        public int getNumForDayPass() => dayPassNum;

		public FareRules getFareRules() => aFareRule;

        public float getCostPerStation() => costPerStation; // for testing
	}
}
