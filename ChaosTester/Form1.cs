namespace ChaosTester
{
    /*
     * #1. ARRANGEMENT or Object Identification

    We identify objects (buttons, dropdowns etc.) either by their ids, names or by their Window Titles etc.

    In case of web application, we identify by user ID, or By XPath or By CSS or By Class Name etc.
    If nothing works, we then identify objects by using mouse coordinates (But it is not a reliable 
    method of object identification)

    Take this example of Selenium WebDriver (with C#) in which we identify objects using the id. 
    (Web application)

    IWebElement txtServer = _webDriver.FindElement(By.Id("tfsServerURL"));
    Another example from MS Coded UI (desktop application)

    WinButton btnAdd = new WinButton(calWindow);
    btnAdd.SearchProperties[WinButton.PropertyNames.Name] = "Add";
    After identification, we arrange or store these objects into UIMaps or Object Repository to reuse 
    them in our scripts. That is why this step is called ARRANGEMENT.
     */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * 
         * #2. ACTION on the Identified Object

        When the objects are identified, we perform some kind of actions on it either by mouse 
        or by keyboard.
        For example, either we click, or we double-click, or we mouse hover over it or sometimes we 
        drag-drop. Sometimes we write on text boxes. So any kind of action we perform on these objects 
        are covered in this second step.

        Example 1: (Selenium WebDriver with C#)

        txtServer.Clear();
        txtServer.SendKeys(“Some sample text”);
        Example 2: (MS Coded UI with C#)

        Mouse.Click(buttonAdd);
         */

        /*
         * #3. ASSERTION

        The assertion is basically checking the object with some expected result. For example, if we press 2+3 on the calculator, the screen should show 5. In this case, our expected result is 5. This concept is already explained in our first tutorial.

        Here we give an example of assertion:

        Assert.AreEqual("5", txtResult.DisplayText);
        Nearly every script written in test automation contains these three things: 
        Arrangement, Action and Assertion.

        Now take a look at a complete script which contains all these steps. The script will open a calculator, press 1 + 6 and then check whether screen shows 7 or not.

        test script for automation framework

        Example A:

        [TestMethod]
        [TestMethod]
        public void TestCalculator()
        {
 
            var app = ApplicationUnderTest.Launch("C:\\Windows\\System32\\calc.exe");
        //Object identification part (ARRANGEMENT)
 
        //----*Calculator Window----
        WinWindow calWindow = new WinWindow(app);
        calWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
        calWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";
 
        //----*Button1 ----
        WinButton btn1 = new WinButton(calWindow);
        btn1.SearchProperties[WinButton.PropertyNames.Name] = "1";
 
        //----*Button Add ----
        WinButton btnAdd = new WinButton(calWindow);
        btnAdd.SearchProperties[WinButton.PropertyNames.Name] = "Add";
 
        //----*Button 6 ----
        WinButton btn6 = new WinButton(calWindow);
        btn6.SearchProperties[WinButton.PropertyNames.Name] = "6";
 
        //----*Button Equals ----
        WinButton btnEquals = new WinButton(calWindow);
        btnEquals.SearchProperties[WinButton.PropertyNames.Name] = "Equals";
 
        //----*Text Box Results----
        WinText txtResult = new WinText(calWindow);
        txtResult.SearchProperties[WinText.PropertyNames.Name] = "Result";
 
        //(ACTIONS Part)
        // Click '1' button
        Mouse.Click(btn1);
 
        // Click 'Add' button
        Mouse.Click(btnAdd);
 
        // Click '6' button
        Mouse.Click(btn6);
 
        // Click 'Equals' button
        Mouse.Click(btnEquals);
 
        //evaluate the results (ASSERTIONS)
        Assert.AreEqual("7", txtResult.DisplayText, “Screen is not displaying 7);

        //close the application
        app.Close();
 
        }
         */
    }
}