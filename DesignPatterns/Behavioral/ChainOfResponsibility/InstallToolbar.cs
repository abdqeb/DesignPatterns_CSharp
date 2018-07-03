namespace DesignPatterns.ChainOfResponsibility
{
    public class InstallToolbar : InstallBase, InstallerChain
    {
        public override void PerformStep(InstallerConfig config)
        {
            //Check config and Skip or Perform Install operations
            if (config.RepairMode)
                config.ProgressLog.AppendLine("Repaired Toolbar Successfully");
            else
                config.ProgressLog.AppendLine("Toolbar Installed Successfully");

            //This will stop if the next chain is not defined.
            _nextChain?.PerformStep(config);
        }
    }
}
