namespace RemoteControlAPI.Model
{
    internal class TVOffCommand : ICommand
    {
        TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void execute()
        {
            _tv.Off();
        }

        public void undo()
        {
            _tv.On();
        }
    }
}