using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AppendTextBox(string value)
        {
            //if this is called from a different thread, an invoke will be required to access the form's control
            //for the rich text box.
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            OutputTextBox.AppendText("\n" + value);
        }

        private async void AsyncAppend1()
        {
            AppendTextBox("Async Append point A");
            //used instead of Thread.Sleep for async tasks
            await Task.Delay(2000);

            AppendTextBox("Async Append point B");
            await Task.Delay(2000);

            AppendTextBox("Async Append point C");
        }

        private async Task<int> AsyncReturn1()
        {
            AppendTextBox("Async Return point A");
            await Task.Delay(2000);

            AppendTextBox("Async Return point B");
            await Task.Delay(2000);

            AppendTextBox("Async Return point C");

            return 15;
        }

        private async Task<string> AsyncReturnString(string inputString)
        {
            AppendTextBox("Async Input Return point A");
            await Task.Delay(2000);

            AppendTextBox("Async Input Return point B");
            await Task.Delay(2000);

            AppendTextBox("Async Input Return point C");

            StringBuilder strb = new StringBuilder();
            strb.Append("string used: ");
            strb.Append(inputString);
            strb.Append(" was ");
            strb.AppendFormat("  {0,12:N0} ", inputString.Length.ToString());
            strb.Append(" characters long.");

            return strb.ToString();
        }

        private TestType NonAsyncMethod(int inputInt, string inputString)
        {
            AppendTextBox("Task point A");
            Thread.Sleep(1000);
            AppendTextBox("Task point B");
            Thread.Sleep(1000);
            AppendTextBox("Task point C");
            return new TestType() { IntegerValue = inputInt + 5, StringValue = inputString + "_modified" };
        }

        #region button handlers

        private void TestButton1_Click(object sender, EventArgs e)
        {
            AppendTextBox("Appended Value");
        }

        private void TestButton2_Click(object sender, EventArgs e)
        {
            AppendTextBox("Starting Async Append Test");
            //fires this thread and forgets it since the outcome is not important to this method
            AsyncAppend1();
            AppendTextBox("Exiting Async Append Test");
        }

        //because this method includes 'await' it must be labeled async as well
        private async void TestButton3_Click(object sender, EventArgs e)
        {
            AppendTextBox("Starting Async Return Test");
            var returnValue = await AsyncReturn1();
            AppendTextBox("Exiting Async Return Test");
            AppendTextBox("Result: " + returnValue);
        }
        
        private async void TestButton4_Click(object sender, EventArgs e)
        {
            AppendTextBox("Starting Async Input Return Test");
            string inputText = InputStringTextBox.Text;
            string returnString = await AsyncReturnString(inputText);
            AppendTextBox("Exiting Async Input Return Test");
            AppendTextBox("Result: " + returnString);
        }
        
        private async void TestButtonTask_Click(object sender, EventArgs e)
        {
            AppendTextBox("Starting Task Test");
            TestType t = await(Task.Run(() => NonAsyncMethod(InputStringTextBox.Text.Length, InputStringTextBox.Text)));
            AppendTextBox("Exiting Task Test");
            AppendTextBox("Result: " + t.ToString());
        }

        #endregion

    }
}
