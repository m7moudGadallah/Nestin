﻿namespace Nestin.Core.Dtos.Reviews
{
    public class Reviewr
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
    }
    public class ReviewDto
    {
        public string BookingId { get; set; }
        public string Comment { get; set; }
        public decimal Cleanliness { get; set; }
        public decimal Accuracy { get; set; }
        public decimal CheckIn { get; set; }
        public decimal Communication { get; set; }
        public decimal Location { get; set; }
        public decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Reviewr Reviewr { get; set; }
        public decimal Avg => (Cleanliness + Accuracy + CheckIn + Communication + Location + Value) / 6;
    }
}
