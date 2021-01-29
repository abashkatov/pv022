
namespace ConsoleApp3.Command
{
    class Output1Command : ICommand, IPrintable
    {
        public bool CanExecute(string cmd)
        {
            return cmd == "1";
        }

        public string Execute(ref bool IsStop)
        {
            return "1";
        }
        public override string ToString()
        {
            return "1. Вывести '1'";
        }
    }
}
