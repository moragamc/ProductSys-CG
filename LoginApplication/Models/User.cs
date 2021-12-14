using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginApplication.Models
{
    class User
    {
        int id { get; set; }
        string userName { get; set; }
        string password { get; set; }
        
        string role { get; set; }
    }
}
