using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBank.Models
{
    public class Check
    {
        public Guid CheckId { get; set; } = Guid.NewGuid();
        public decimal Amount { get; set; } = 0;
        public Guid RecipientAccountId { get; set; } = Guid.Empty;
        public DateTime IssuedDate { get; set; } = DateTime.Now;
        public bool IsCleared { get; set; } = false;
        public bool IsWritten { get; set; } = false;
    }
}