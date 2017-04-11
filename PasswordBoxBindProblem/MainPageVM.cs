using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class MainPageVM: ReactiveObject
    {
        private string password;

        public string Password
        {
            get
            { return password; }

            set
            { this.RaiseAndSetIfChanged(ref password, value); }
        }
        public MainPageVM()
        {
            Password = string.Empty;
        }
    }
}
