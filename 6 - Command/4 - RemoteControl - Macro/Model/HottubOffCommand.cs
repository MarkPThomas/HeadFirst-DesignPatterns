namespace RemoteControlAPI.Model
{
    internal class HottubOffCommand : ICommand
    {
        Hottub _hottub;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void execute()
        {
            _hottub.JetsOff();
        }

        public void undo()
        {
            _hottub.JetsOn();
        }
    }
}