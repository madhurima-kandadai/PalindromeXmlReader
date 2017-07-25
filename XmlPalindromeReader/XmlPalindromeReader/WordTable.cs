namespace XmlPalindromeReader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Palindrome")]
    public partial class WordTable
    {
        public int Id { get; set; }

        [Required]
        public string Word { get; set; }

        public bool IsPalindrome { get; set; }

        public DateTime DateTimeStamp { get; set; }
    }
}
