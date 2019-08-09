namespace AsyncOperations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.TestButton1 = new System.Windows.Forms.Button();
            this.TestButton2 = new System.Windows.Forms.Button();
            this.TestButton3 = new System.Windows.Forms.Button();
            this.TestButton4 = new System.Windows.Forms.Button();
            this.InputStringTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestButtonTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(283, 12);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(265, 328);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.Text = "";
            // 
            // TestButton1
            // 
            this.TestButton1.Location = new System.Drawing.Point(12, 62);
            this.TestButton1.Name = "TestButton1";
            this.TestButton1.Size = new System.Drawing.Size(207, 25);
            this.TestButton1.TabIndex = 1;
            this.TestButton1.Text = "Test1";
            this.TestButton1.UseVisualStyleBackColor = true;
            this.TestButton1.Click += new System.EventHandler(this.TestButton1_Click);
            // 
            // TestButton2
            // 
            this.TestButton2.Location = new System.Drawing.Point(12, 93);
            this.TestButton2.Name = "TestButton2";
            this.TestButton2.Size = new System.Drawing.Size(207, 23);
            this.TestButton2.TabIndex = 2;
            this.TestButton2.Text = "Test 2 Async Append";
            this.TestButton2.UseVisualStyleBackColor = true;
            this.TestButton2.Click += new System.EventHandler(this.TestButton2_Click);
            // 
            // TestButton3
            // 
            this.TestButton3.Location = new System.Drawing.Point(12, 122);
            this.TestButton3.Name = "TestButton3";
            this.TestButton3.Size = new System.Drawing.Size(207, 23);
            this.TestButton3.TabIndex = 3;
            this.TestButton3.Text = "Test 3 Async Return";
            this.TestButton3.UseVisualStyleBackColor = true;
            this.TestButton3.Click += new System.EventHandler(this.TestButton3_Click);
            // 
            // TestButton4
            // 
            this.TestButton4.Location = new System.Drawing.Point(12, 197);
            this.TestButton4.Name = "TestButton4";
            this.TestButton4.Size = new System.Drawing.Size(207, 23);
            this.TestButton4.TabIndex = 4;
            this.TestButton4.Text = "Test 4 Async Input Return";
            this.TestButton4.UseVisualStyleBackColor = true;
            this.TestButton4.Click += new System.EventHandler(this.TestButton4_Click);
            // 
            // InputStringTextBox
            // 
            this.InputStringTextBox.Location = new System.Drawing.Point(79, 171);
            this.InputStringTextBox.Name = "InputStringTextBox";
            this.InputStringTextBox.Size = new System.Drawing.Size(140, 20);
            this.InputStringTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input String";
            // 
            // TestButtonTask
            // 
            this.TestButtonTask.Location = new System.Drawing.Point(12, 289);
            this.TestButtonTask.Name = "TestButtonTask";
            this.TestButtonTask.Size = new System.Drawing.Size(207, 23);
            this.TestButtonTask.TabIndex = 7;
            this.TestButtonTask.Text = "Test 5 Task Fire Return";
            this.TestButtonTask.UseVisualStyleBackColor = true;
            this.TestButtonTask.Click += new System.EventHandler(this.TestButtonTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 352);
            this.Controls.Add(this.TestButtonTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputStringTextBox);
            this.Controls.Add(this.TestButton4);
            this.Controls.Add(this.TestButton3);
            this.Controls.Add(this.TestButton2);
            this.Controls.Add(this.TestButton1);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Form1";
            this.Text = "Async Operations Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button TestButton1;
        private System.Windows.Forms.Button TestButton2;
        private System.Windows.Forms.Button TestButton3;
        private System.Windows.Forms.Button TestButton4;
        private System.Windows.Forms.TextBox InputStringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TestButtonTask;
    }
}

