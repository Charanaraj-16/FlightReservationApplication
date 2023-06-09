//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FLightBookingSystem.DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime BookingDate { get; set; }
        [Required(ErrorMessage = "From City is required")]
        public string FromCIty { get; set; }
        [Required(ErrorMessage = "To City is required")]
        public string ToCity { get; set; }
        [Required(ErrorMessage = "To Price is required")]
        public decimal Price { get; set; }
        public int FlightID { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public int TotalSeat { get; set; }
    
        public virtual Flight Flight { get; set; }
        public virtual Customer Customer { get; set; }
       
    }
}
