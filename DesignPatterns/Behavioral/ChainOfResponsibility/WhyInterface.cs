namespace DesignPatterns.ChainOfResponsibility
{
    public class WhyInterface : InstallerChain
    {
        protected InstallerChain _nextChain;

        public void PerformStep(InstallerConfig config)
        {
            //do something here that is different
            config.ProgressLog.AppendLine("Interfaces allow mutiple inheritance!");

            _nextChain?.PerformStep(config);
        }

        //Note this is duplicated with isntall base, but sometimes we dont have a choice
        public void SetNextStep(InstallerChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}
