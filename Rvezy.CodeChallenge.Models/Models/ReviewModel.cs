using System;
using System.ComponentModel.DataAnnotations;

namespace Rvezy.CodeChallenge.Models
{
    public class ReviewModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int ListingId { get; set; }
        public DateTime Date { get; set; }
        public int ReviewerId { get; set; }
        public string ReviewerName { get; set; }
        public string Comments { get; set; }

        public ListingModel Listing { get; set; }
    }
}
