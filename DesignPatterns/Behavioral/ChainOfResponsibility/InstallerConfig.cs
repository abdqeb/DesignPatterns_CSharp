using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class InstallerConfig
    {
        public readonly string Path = @"C:\Temp\";
        //I am not sure this is the best place for this
        public StringBuilder ProgressLog = new StringBuilder();
        public readonly bool RepairMode = false;

        public InstallerConfig(string path, bool repairMode)
        {
            Path = path;
            RepairMode = repairMode;
        }
    }
}
