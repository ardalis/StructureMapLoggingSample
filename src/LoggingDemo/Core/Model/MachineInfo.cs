namespace LoggingDemo.Core.Model
{
    public class MachineInfo
    {
        public MachineInfo(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
