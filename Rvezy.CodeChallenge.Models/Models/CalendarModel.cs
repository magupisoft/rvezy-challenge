using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rvezy.CodeChallenge.Models
{
    public class CalendarModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int _id;
        public int Id { 
            get { 
                if (_id == default) { 
                    return 1; 
                }
                return _id;
            }
            set
            {
                _id = value;
            }
        }


        public int ListingId { get; set; }
        public DateTime Date { get; set; }
        public string Available { get; set; }
        public string Price { get; set; }

        public ListingModel Listing { get; set; }
    }
}
