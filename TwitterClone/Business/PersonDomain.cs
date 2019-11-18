using System;
using System.Collections.Generic;
using TwitterClone.Models;
using TwitterClone.ModelsApp_Code;

namespace TwitterClone.Business
{
    public class PersonDomain
    {
        private TwitterDbContext context = new TwitterDbContext();

        public void SetUserId()
        {

        }
        public string GetUserId()
        {
            return string.Empty;
        }
        public void SetFullName()
        {

        }
        public string GetFullName()
        {
            return string.Empty;
        }
        public string GetEmail()
        {
            return string.Empty;
        }
        public void SetEmail(string email)
        {

        }
        public void SetJoined(DateTime JoinedDate)
        {

        }

        public DateTime GetJoined()
        {
            return DateTime.Now;
        }
        public void SetActive(Boolean value)
        {

        }
        public bool GetActive()
        {
            return false;
        }
        public void SetFollowing()
        {
        }
        public List<Person> GetFollowing()
        {
            return new List<Person>();
        }
        public List<Person> GetFollowers()
        {
            return new List<Person>();
        }
        public void SetFollowers(List<Person> person)
        {

        }
        public void SetTweets(List<TWEET> tweets)
        {

        }
        public List<TWEET> GetTweets(List<TWEET> tweets)
        {
            return new List<TWEET>();
        }
    }
}