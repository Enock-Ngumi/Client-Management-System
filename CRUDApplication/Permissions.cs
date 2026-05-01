using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Management_System
{
     public class Permissions
    {

        public bool CanViewUsers { get; set; }
        public bool CanAddUsers { get; set; }
        public bool CanDeleteUsers { get; set; }
        public bool CanEditUsers { get; set; }
        public bool CanViewAdmin { get; set; }
        public bool CanManageUsers { get; set; }


        public bool CanViewClients { get; set; }
        public bool CanAddClients { get; set; }
        public bool CanDeleteClients { get; set; }
        

        
    }
}
