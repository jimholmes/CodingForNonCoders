using NUnit.Framework;

namespace L10.ExceptionHandlingExample
{
    public class TestToDrive{

        [Test]
        public void RunTheReport() {
            ReportSystemUI ui = new ReportSystemUI();
            ui.WriteTheReport();
        }
    }
    
}
