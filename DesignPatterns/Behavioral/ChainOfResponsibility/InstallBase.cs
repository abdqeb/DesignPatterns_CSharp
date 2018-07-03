namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class InstallBase : InstallerChain
    {
        protected InstallerChain _nextChain;

        public abstract void PerformStep(InstallerConfig config);

        public void SetNextStep(InstallerChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}
