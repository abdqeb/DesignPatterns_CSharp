namespace DesignPatterns.ChainOfResponsibility
{
    public interface IInstallerChain
    {
        void SetNextStep(IInstallerChain nextChain);
        void PerformStep(InstallerConfig config);
    }
}