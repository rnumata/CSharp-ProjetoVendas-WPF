using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VendasWpf.Models
{
    public abstract class BaseModel
    {

        public BaseModel() => Criadoem = DateTime.Now;
        
        [Key]
        public int Id { get; set; }

        public DateTime Criadoem { get; set; }


    }
}
