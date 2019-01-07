using NUnit.Framework;

namespace L11.ExceptionHandlingExample
{
    public class TestToDrive{

        [Test]
        public void RunTheReport() {
            ReportSystemUI ui = new ReportSystemUI();
            ui.WriteTheReport();
        }
    }
    
}
