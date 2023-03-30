using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FLightBookingSystem.Models
{
    public class BookingModel
    {
        public int BookingID;
        [Required(ErrorMessage = "The date is required")]
        [Display(Name = "Select Date:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime SelectedDate;

        public SelectList BookingIDs { get; set; }
    }
    public class CancelationModel
    {
        public int BookingID;
        public int Payment;
    }
}