namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class InstallBase : IInstallerChain
    {
        protected IInstallerChain _nextChain;

        public abstract void PerformStep(InstallerConfig config);

        public void SetNextStep(IInstallerChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}
