using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoConcurrency.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public double Balance { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual Account Account{ get; set; }
    }
}