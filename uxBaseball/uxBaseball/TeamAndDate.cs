﻿/*TeamAndDate.cs
* Author: Sagar Mehta
*Instances of this class will contain a team abbreviation and a date (stored as a DateTime). 
*These instances will be used as keys in a dictionary.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uxBaseball
{
    struct TeamAndDate
    {
        /// <summary>
        /// stores all the information related with date
        /// </summary>
        private DateTime date;
        /// <summary>
        /// Stores team's abbreviation
        /// </summary>
        private string abbr;
        /// <summary>
        /// stores the hashcode
        /// </summary>
        private int hashCode;
        
        /// <summary>
        /// Structure will initialize the team and date information using hashcode
        /// </summary>
        /// <param name="s"></param>
        /// <param name="time"></param>
        public TeamAndDate(string s, string time)
        {
            int year = Convert.ToInt32(time.Substring(0, 4));
            int month = Convert.ToInt32(time.Substring(4, 2));
            int day = Convert.ToInt32(time.Substring(6, 2));
            date = new DateTime(year, month, day);
            abbr = s;
            unchecked { 
            hashCode = Convert.ToInt32(abbr[0]);
            hashCode *= 39;
            hashCode += Convert.ToInt32(abbr[1]);
            hashCode *= 39;
            hashCode += Convert.ToInt32(abbr[2]);
            hashCode *= 39;
            hashCode += date.Year;
            hashCode *= 39;
            hashCode += date.Month;
            hashCode *= 39;
            hashCode += date.Day;
            hashCode *= 39;
            }
            //throw new Exception();
        }
        /// <summary>
        /// Overrides the getHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return hashCode;
        }
        /// <summary>
        /// Checks for the two onjects are same or not
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(TeamAndDate x, TeamAndDate y)
        {
            if (x.date == y.date && x.abbr == y.abbr) return true;
            else return false;
        }
        public static bool operator !=(TeamAndDate x, TeamAndDate y)
        {
            return!(x==y);
        }
    }
}
