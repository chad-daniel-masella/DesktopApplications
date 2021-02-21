namespace WindowsAppPredicateCalculator
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
            this.StudentNo = new System.Windows.Forms.Label();
            this.testMarkOne = new System.Windows.Forms.Label();
            this.ClassTestOne = new System.Windows.Forms.Label();
            this.ClassTestTwo = new System.Windows.Forms.Label();
            this.SemesterTestOne = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.SemesterTestTwo = new System.Windows.Forms.Label();
            this.StdntNo = new System.Windows.Forms.TextBox();
            this.StdntFullName = new System.Windows.Forms.TextBox();
            this.StdntClassTestOne = new System.Windows.Forms.TextBox();
            this.StdntClassTestTwo = new System.Windows.Forms.TextBox();
            this.StdntSemesterTestOne = new System.Windows.Forms.TextBox();
            this.StdntSemesterTestTwo = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.FormDisplayData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StudentNo
            // 
            this.StudentNo.AutoSize = true;
            this.StudentNo.Location = new System.Drawing.Point(22, 50);
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.Size = new System.Drawing.Size(58, 13);
            this.StudentNo.TabIndex = 0;
            this.StudentNo.Text = "StudentNo";
            this.StudentNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // testMarkOne
            // 
            this.testMarkOne.AutoSize = true;
            this.testMarkOne.Location = new System.Drawing.Point(22, 96);
            this.testMarkOne.Name = "testMarkOne";
            this.testMarkOne.Size = new System.Drawing.Size(51, 13);
            this.testMarkOne.TabIndex = 1;
            this.testMarkOne.Text = "FullName";
            // 
            // ClassTestOne
            // 
            this.ClassTestOne.AutoSize = true;
            this.ClassTestOne.Location = new System.Drawing.Point(22, 147);
            this.ClassTestOne.Name = "ClassTestOne";
            this.ClassTestOne.Size = new System.Drawing.Size(73, 13);
            this.ClassTestOne.TabIndex = 2;
            this.ClassTestOne.Text = "ClassTestOne";
            // 
            // ClassTestTwo
            // 
            this.ClassTestTwo.AutoSize = true;
            this.ClassTestTwo.Location = new System.Drawing.Point(22, 198);
            this.ClassTestTwo.Name = "ClassTestTwo";
            this.ClassTestTwo.Size = new System.Drawing.Size(74, 13);
            this.ClassTestTwo.TabIndex = 3;
            this.ClassTestTwo.Text = "ClassTestTwo";
            // 
            // SemesterTestOne
            // 
            this.SemesterTestOne.AutoSize = true;
            this.SemesterTestOne.Location = new System.Drawing.Point(22, 248);
            this.SemesterTestOne.Name = "SemesterTestOne";
            this.SemesterTestOne.Size = new System.Drawing.Size(92, 13);
            this.SemesterTestOne.TabIndex = 4;
            this.SemesterTestOne.Text = "SemesterTestOne";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(315, 360);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(115, 32);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(462, 360);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(129, 32);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(633, 360);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(129, 32);
            this.View.TabIndex = 8;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // SemesterTestTwo
            // 
            this.SemesterTestTwo.AutoSize = true;
            this.SemesterTestTwo.Location = new System.Drawing.Point(22, 296);
            this.SemesterTestTwo.Name = "SemesterTestTwo";
            this.SemesterTestTwo.Size = new System.Drawing.Size(93, 13);
            this.SemesterTestTwo.TabIndex = 9;
            this.SemesterTestTwo.Text = "SemesterTestTwo";
            this.SemesterTestTwo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // StdntNo
            // 
            this.StdntNo.Location = new System.Drawing.Point(140, 43);
            this.StdntNo.Name = "StdntNo";
            this.StdntNo.Size = new System.Drawing.Size(100, 20);
            this.StdntNo.TabIndex = 10;
            this.StdntNo.TextChanged += new System.EventHandler(this.StdntNo_TextChanged);
            // 
            // StdntFullName
            // 
            this.StdntFullName.Location = new System.Drawing.Point(140, 96);
            this.StdntFullName.Name = "StdntFullName";
            this.StdntFullName.Size = new System.Drawing.Size(100, 20);
            this.StdntFullName.TabIndex = 11;
            this.StdntFullName.TextChanged += new System.EventHandler(this.StdntFullName_TextChanged);
            // 
            // StdntClassTestOne
            // 
            this.StdntClassTestOne.Location = new System.Drawing.Point(140, 140);
            this.StdntClassTestOne.Name = "StdntClassTestOne";
            this.StdntClassTestOne.Size = new System.Drawing.Size(100, 20);
            this.StdntClassTestOne.TabIndex = 12;
            this.StdntClassTestOne.TextChanged += new System.EventHandler(this.StdntClassTestOne_TextChanged);
            // 
            // StdntClassTestTwo
            // 
            this.StdntClassTestTwo.Location = new System.Drawing.Point(140, 191);
            this.StdntClassTestTwo.Name = "StdntClassTestTwo";
            this.StdntClassTestTwo.Size = new System.Drawing.Size(100, 20);
            this.StdntClassTestTwo.TabIndex = 13;
            this.StdntClassTestTwo.TextChanged += new System.EventHandler(this.StdntClassTestTwo_TextChanged);
            // 
            // StdntSemesterTestOne
            // 
            this.StdntSemesterTestOne.Location = new System.Drawing.Point(140, 241);
            this.StdntSemesterTestOne.Name = "StdntSemesterTestOne";
            this.StdntSemesterTestOne.Size = new System.Drawing.Size(100, 20);
            this.StdntSemesterTestOne.TabIndex = 14;
            this.StdntSemesterTestOne.TextChanged += new System.EventHandler(this.StdntSemesterTestOne_TextChanged);
            // 
            // StdntSemesterTestTwo
            // 
            this.StdntSemesterTestTwo.Location = new System.Drawing.Point(140, 296);
            this.StdntSemesterTestTwo.Name = "StdntSemesterTestTwo";
            this.StdntSemesterTestTwo.Size = new System.Drawing.Size(100, 20);
            this.StdntSemesterTestTwo.TabIndex = 15;
            this.StdntSemesterTestTwo.TextChanged += new System.EventHandler(this.StdntSemesterTestTwo_TextChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(-1, 522);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(802, 63);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.btnExit);
            // 
            // FormDisplayData
            // 
            this.FormDisplayData.Location = new System.Drawing.Point(315, 22);
            this.FormDisplayData.Name = "FormDisplayData";
            this.FormDisplayData.Size = new System.Drawing.Size(447, 315);
            this.FormDisplayData.TabIndex = 20;
            this.FormDisplayData.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.FormDisplayData);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StdntSemesterTestTwo);
            this.Controls.Add(this.StdntSemesterTestOne);
            this.Controls.Add(this.StdntClassTestTwo);
            this.Controls.Add(this.StdntClassTestOne);
            this.Controls.Add(this.StdntFullName);
            this.Controls.Add(this.StdntNo);
            this.Controls.Add(this.SemesterTestTwo);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.SemesterTestOne);
            this.Controls.Add(this.ClassTestTwo);
            this.Controls.Add(this.ClassTestOne);
            this.Controls.Add(this.testMarkOne);
            this.Controls.Add(this.StudentNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNo;
        private System.Windows.Forms.Label testMarkOne;
        private System.Windows.Forms.Label ClassTestOne;
        private System.Windows.Forms.Label ClassTestTwo;
        private System.Windows.Forms.Label SemesterTestOne;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label SemesterTestTwo;
        private System.Windows.Forms.TextBox StdntNo;
        private System.Windows.Forms.TextBox StdntFullName;
        private System.Windows.Forms.TextBox StdntClassTestOne;
        private System.Windows.Forms.TextBox StdntClassTestTwo;
        private System.Windows.Forms.TextBox StdntSemesterTestOne;
        private System.Windows.Forms.TextBox StdntSemesterTestTwo;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.RichTextBox FormDisplayData;
    }
}

