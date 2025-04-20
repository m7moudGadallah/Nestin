﻿using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.BookingGuests
{
    public class CreateBookingGuestDto
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int GuestTypeId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int GuestCount { get; set; }
    }
}
