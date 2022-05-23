using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using whatsapp_WEBAPI;

namespace whatsapp_WEBAPI.Data
{
    public class whatsapp_WEBAPIContext : DbContext
    {
        public whatsapp_WEBAPIContext (DbContextOptions<whatsapp_WEBAPIContext> options)
            : base(options)
        {
        }

        public DbSet<whatsapp_WEBAPI.Message>? Message { get; set; }

        public DbSet<whatsapp_WEBAPI.User>? User { get; set; }

        public DbSet<whatsapp_WEBAPI.Contact>? Contact { get; set; }
    }
}
