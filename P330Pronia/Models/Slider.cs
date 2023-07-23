using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;

namespace P330Pronia.Models
{
    public class Slider



        
    {
        public int id { get; set; }
        [System.ComponentModel.DataAnnotations.Required, MaxLength(100)]
        public string subtitle { get; set; }

        public string title { get; set; }
        public string description { get; set; }

        public string image { get; set; }
    }
}
