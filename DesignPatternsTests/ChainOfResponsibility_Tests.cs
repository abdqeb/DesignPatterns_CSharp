using NUnit.Framework;
using DesignPatterns.ChainOfResponsibility;
using System.Text;

namespace DesignPatternsTests
{
    [TestFixture]
    public class ChainOfResponsibility_Tests
    {
        [Test]
        public void Using_ChainOfResponsibility_CoreThenWhy()
        {
            InstallerChain core = new InstallCoreSoftware();
            InstallerChain toolbar = new InstallToolbar();
            InstallerChain whyinterface = new WhyInterface();

            core.SetNextStep(whyinterface);
            whyinterface.SetNextStep(toolbar);

            InstallerConfig config = new InstallerConfig(@"C:\Temp", false);
            core.PerformStep(config);

            StringBuilder result = new StringBuilder();
            result.AppendLine("Core Software Installed Successfully");
            result.AppendLine("Interfaces allow mutiple inheritance!");
            result.AppendLine("Toolbar Installed Successfully");

            Assert.IsTrue(config.ProgressLog.ToString() == result.ToString());
        }

        [Test]
        public void Using_ChainOfResponsibility_CoreThenTool()
        {
            InstallerChain core = new InstallCoreSoftware();
            InstallerChain toolbar = new InstallToolbar();
            InstallerChain whyinterface = new WhyInterface();

            core.SetNextStep(toolbar);
            toolbar.SetNextStep(whyinterface);

            InstallerConfig config = new InstallerConfig(@"C:\Temp", false);
            core.PerformStep(config);

            StringBuilder result = new StringBuilder();
            result.AppendLine("Core Software Installed Successfully");
            result.AppendLine("Toolbar Installed Successfully");
            result.AppendLine("Interfaces allow mutiple inheritance!");
            Assert.IsTrue(config.ProgressLog.ToString() == result.ToString());
        }
    }
}