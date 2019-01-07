using NUnit.Framework;

namespace L14.Spike
{
    public class TestToDrive{

        [Test]
        public void RunTheReport() {
            ReportSystemUI ui = new ReportSystemUI();
            ui.WriteTheReport();
        }
    }
    
}
