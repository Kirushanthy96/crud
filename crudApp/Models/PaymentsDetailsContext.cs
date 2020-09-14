using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudApp.Models
{
    public class PaymentsDetailsContext:DbContext
    {
        public PaymentsDetailsContext(DbContextOptions<PaymentsDetailsContext> options) : base(options)
        {


        }

        public DbSet<PaymentDetails> PaymentDetails { get; set; }
    }
}
