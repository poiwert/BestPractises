﻿using System;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born.");
        }

        public Actor(string actorName):this()
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }


        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        private string theDate;

        public string TheDate
        {
            get { return theDate; }
            set { theDate = value; }
        }


        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation() {
            jobTitle = "Actor";
            return jobTitle;
        }

        /// <summary>
        /// Books actor and not date specified
        /// </summary>
        public string BookActor()
        {
            string details = " Booking can change if" +
                " actor starts trouble.";
            return "Actor " + ActorName + " is booked. " + details;
        }


        /// <summary>
        /// Books actor on specific date.
        /// </summary>
        /// <param name="theDate"></param>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if" +
                " actor starts trouble.";
            return "Actor " + ActorName + " is booked on "
                + theDate + ". " + details;
        }
    }
}
