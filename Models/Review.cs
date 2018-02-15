using System.ComponentModel.DataAnnotations;
using System;

namespace restauranter.Models
{
    public class Review
    {
        public int id{get;set;}
        public string ReviewerName{get;set;}
        public string RestaurantName{get;set;}
        public string ReviewContext{get;set;}
        public string Date{get;set;}
        public int Stars{get;set;}

    }
}