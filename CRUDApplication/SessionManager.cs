using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Management_System
{
    public static class SessionManager
    {
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static bool IsAdmin => Role?.Equals("Admin", System.StringComparison.OrdinalIgnoreCase) == true;
    }
}