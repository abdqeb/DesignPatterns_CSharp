namespace DesignPatterns.ChainOfResponsibility
{
    public class InstallCoreSoftware : InstallBase, IInstallerChain
    {
        public override void PerformStep(InstallerConfig config)
        {
            //Check config and Skip or Perform Install operations
            if (config.RepairMode)
                config.ProgressLog.AppendLine("Repaired Core Software Successfully");
            else
                config.ProgressLog.AppendLine("Core Software Installed Successfully");

            //This will stop if the next chain is not defined.
            _nextChain?.PerformStep(config);
        }
    }
}
