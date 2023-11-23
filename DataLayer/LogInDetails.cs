using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LogInDetails
    {
        private string id;
        private string pwd;
        private bool admin;
        public LogInDetails(string id, string pwd)
        {
            this.id = id;
            this.pwd = pwd;
            admin = false;

        }
        public void MakeAdmin() { admin = true; }
        public string GetID() { return id; }
        public string GetPwd() { return pwd; }
        public bool IsAdmin() { return admin; }
    }
}
