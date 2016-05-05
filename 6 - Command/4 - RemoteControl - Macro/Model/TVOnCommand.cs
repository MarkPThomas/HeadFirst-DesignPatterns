namespace RemoteControlAPI.Model
{
    internal class TVOnCommand : ICommand
    {
        TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void execute()
        {
            _tv.On();
        }

        public void undo()
        {
            _tv.Off();
        }
    }
}