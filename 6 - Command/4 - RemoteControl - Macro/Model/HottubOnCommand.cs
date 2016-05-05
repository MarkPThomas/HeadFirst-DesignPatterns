namespace RemoteControlAPI.Model
{
    internal class HottubOnCommand : ICommand
    {
        Hottub _hottub;

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void execute()
        {
            _hottub.JetsOn();
        }

        public void undo()
        {
            _hottub.JetsOff();
        }
    }
}