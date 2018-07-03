namespace DesignPatterns.ChainOfResponsibility
{
    public interface InstallerChain
    {
        void SetNextStep(InstallerChain nextChain);
        void PerformStep(InstallerConfig config);
    }
}