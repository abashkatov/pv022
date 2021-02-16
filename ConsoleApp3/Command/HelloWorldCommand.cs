using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3.Command
{
    class HelloWorldCommand : ICommand
    {
        public string GetTitle()
        {
            return "Hello World";
        }

        public void Run()
        {
            MessageBox.Show("Hello World!", "Hello World!");
        }
    }
}
