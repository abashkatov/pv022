using System.Windows.Forms;

namespace ConsoleApp3.Command
{
    class HelloWorldCommand : AbstractCommand
    {
        public override string GetTitle()
        {
            return "Hello World";
        }

        public override void Run()
        {
            MessageBox.Show("Hello World!", "Hello World!");
        }
    }
}
