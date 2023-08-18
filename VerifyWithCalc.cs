using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Input;
using FlaUI.UIA2;
using FlaUI.UIA3;
using System.Runtime.Intrinsics.X86;
using System.Windows.Automation;
using System.Windows.Controls;
using Windows.ApplicationModel.Appointments;
using Windows.Graphics;
using Windows.Media.Devices;
using PropertyCondition = FlaUI.Core.Conditions.PropertyCondition;

namespace CalculatorCheck
{
    public class Tests
    {
        SimpleCalc calc = new SimpleCalc();

        //[Test]
        //public void TestSimpleCalcWithWindowsCalculator_OnePlusOne()
        //{
        //    var app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    var automation = new UIA3Automation();
        //    var window = app.GetMainWindow(automation);
        //    ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

        //    window.FindFirstDescendant(cf => cf.ByName("One")).AsButton().Invoke();           
        //    window.FindFirstDescendant(cf => cf.ByName("Plus")).AsButton().Invoke();            
        //    window.FindFirstDescendant(cf => cf.ByName("One")).AsButton().Invoke();         
        //    window.FindFirstDescendant(cf => cf.ByName("Equals")).AsButton().Invoke();
            
        //    var element = window.FindFirstDescendant(cf.ByAutomationId("CalculatorResults")); 
        //    Thread.Sleep(1000);           
        //    var result = element.Name;
        //    var expectedResult = "Display is 2";


        //    var resultFromSimpleCalc = $"Display is {calc.SumResult(1, 1)}";


        //    Assert.That(expectedResult, Is.EqualTo(result));
        //    Assert.That(result, Is.EqualTo(resultFromSimpleCalc));
        //    Thread.Sleep(1000);
        //    app.Close();
       
        //}

        //[Test]
        //public void TestSimpleCalcWithWindowsCalculator_TwoPlusTwo()
        //{

        //    Thread.Sleep(2000);
        //    var app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    var automation = new UIA3Automation();
        //    var window = app.GetMainWindow(automation);
        //    ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            
            
        //    window.FindFirstDescendant(cf => cf.ByName("Two")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Plus")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Two")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Equals")).AsButton().Invoke();

        //    var element = window.FindFirstDescendant(cf.ByAutomationId("CalculatorResults"));
        //    Thread.Sleep(1000);
        //    var result = element.Name;
        //    var expectedResult = "Display is 4";


        //    var resultFromSimpleCalc = $"Display is {calc.SumResult(2, 2)}";


        //    Assert.That(expectedResult, Is.EqualTo(result));
        //    Assert.That(result, Is.EqualTo(resultFromSimpleCalc));
        //    Thread.Sleep(1000);
        //    app.Close();

        //}

        //[Test]
        //public void TestSimpleCalcWithWindowsCalculator_TwoMinusFive()
        //{

        //    Thread.Sleep(2000);
        //    var app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    var automation = new UIA3Automation();
        //    var window = app.GetMainWindow(automation);
        //    ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());


        //    window.FindFirstDescendant(cf => cf.ByName("Two")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Minus")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Five")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Equals")).AsButton().Invoke();

        //    var element = window.FindFirstDescendant(cf.ByAutomationId("CalculatorResults"));
        //    Thread.Sleep(1000);
        //    var result = element.Name;
        //    var expectedResult = "Display is -3";


        //    var resultFromSimpleCalc = $"Display is {calc.SumResult(2, -5)}";


        //    Assert.That(expectedResult, Is.EqualTo(result));
        //    Assert.That(result, Is.EqualTo(resultFromSimpleCalc));
        //    Thread.Sleep(1000);
        //    app.Close();

        //}

        //[Test]
        //public void TestSimpleCalcWithWindowsCalculator_ZeroPlusZero()
        //{

        //    Thread.Sleep(2000);
        //    var app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    var automation = new UIA3Automation();
        //    var window = app.GetMainWindow(automation);
        //    ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());


        //    window.FindFirstDescendant(cf => cf.ByName("Zero")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Plus")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Zero")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Equals")).AsButton().Invoke();

        //    var element = window.FindFirstDescendant(cf.ByAutomationId("CalculatorResults"));
        //    Thread.Sleep(1000);
        //    var result = element.Name;
        //    var expectedResult = "Display is 0";


        //    var resultFromSimpleCalc = $"Display is {calc.SumResult(0, 0)}";


        //    Assert.That(expectedResult, Is.EqualTo(result));
        //    Assert.That(result, Is.EqualTo(resultFromSimpleCalc));
        //    Thread.Sleep(1000);
        //    app.Close();

        //}

        //[Test]
        //public void TestSimpleCalcWithWindowsCalculator_ZeroPlusMinusNine()
        //{

        //    Thread.Sleep(2000);
        //    var app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
        //    var automation = new UIA3Automation();
        //    var window = app.GetMainWindow(automation);
        //    ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());


        //    window.FindFirstDescendant(cf => cf.ByName("Zero")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Plus")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Minus")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Nine")).AsButton().Invoke();
        //    window.FindFirstDescendant(cf => cf.ByName("Equals")).AsButton().Invoke();

        //    var element = window.FindFirstDescendant(cf.ByAutomationId("CalculatorResults"));
        //    Thread.Sleep(1000);
        //    var result = element.Name;
        //    var expectedResult = "Display is -9";


        //    var resultFromSimpleCalc = $"Display is {calc.SumResult(0, -9)}";


        //    Assert.That(expectedResult, Is.EqualTo(result));
        //    Assert.That(result, Is.EqualTo(resultFromSimpleCalc));
        //    Thread.Sleep(1000);
        //    app.Close();

        //}

        [TestCase(2,2)]       
        [TestCase(100, 100)]
        [TestCase(-5, -10)]
        [TestCase(0, 0)]
        [TestCase(0, -1)]
        [TestCase(3, -20)]
        [TestCase(5.3, 7.2)]
        [TestCase(-20.2, -30.6)]    
        public void TestWithDynamicInput(double num1, double num2)
        {
            Thread.Sleep(2000);
            var app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            window.FindFirstDescendant(cf.ByControlType(FlaUI.Core.Definitions.ControlType.Text));
            
            Keyboard.Type(num1.ToString());
            Keyboard.Press(FlaUI.Core.WindowsAPI.VirtualKeyShort.ADD);
            Keyboard.Type(num2.ToString());
            Keyboard.Press(FlaUI.Core.WindowsAPI.VirtualKeyShort.RETURN);

            var element = window.FindFirstDescendant(cf.ByAutomationId("CalculatorResults"));
            Thread.Sleep(1000);

            var result = element.Name;
            var expectedSum = num1 + num2;
            var expectedResult = $"Display is {expectedSum}";


            var resultFromSimpleCalc = $"Display is {calc.SumResult(num1, num2)}";


            Assert.That(expectedResult, Is.EqualTo(result));
            Assert.That(result, Is.EqualTo(resultFromSimpleCalc));
            Thread.Sleep(1000);


            app.Close();
        }




    }
}