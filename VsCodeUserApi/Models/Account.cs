using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VsCodeUserApi.Models
{
    public class Account
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
