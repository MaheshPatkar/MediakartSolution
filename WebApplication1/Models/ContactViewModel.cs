

using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;



namespace SampleSolution.Models

{

    public class ContactViewModel

    {



        [Display(Name = "First name")]

        public string FirstName { get; set; }



        [Display(Name = "Last name")]

        public string LastName { get; set; }



        [Display(Name = "Your message")]

        public string YourMessage { get; set; }



        [Display(Name = "Your email")]

        public string YourEmail { get; set; }



        [Display(Name = "Phone number")]

        public string PhoneNumber { get; set; }



        [Display(Name = "Contact Purpose")]

        public string ContactPurpose { get; set; }



    }

}