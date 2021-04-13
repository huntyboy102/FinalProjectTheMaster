// Aurthor :  Praveen JM
   // Student ID: 100789496
   // Description: Lab 1, program which calculates the average of toat items shipped in a week.
   // date : 25th Jan
namespace AvgUnitsShipped
{
    partial class formAvgShippedUnit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textBoxEntryNumber = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxPastEntries = new System.Windows.Forms.TextBox();
            this.labelAvgOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(106, 20);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(100, 23);
            this.labelUnitsPrompt.TabIndex = 0;
            this.labelUnitsPrompt.Text = "&Units:";
            // 
            // textBoxEntryNumber
            // 
            this.textBoxEntryNumber.Location = new System.Drawing.Point(163, 16);
            this.textBoxEntryNumber.Name = "textBoxEntryNumber";
            this.textBoxEntryNumber.Size = new System.Drawing.Size(80, 23);
            this.textBoxEntryNumber.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxEntryNumber, "Enter the units shipped to the specified day.");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(267, 19);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(67, 20);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day1";
            // 
            // textBoxPastEntries
            // 
            this.textBoxPastEntries.Location = new System.Drawing.Point(144, 58);
            this.textBoxPastEntries.Multiline = true;
            this.textBoxPastEntries.Name = "textBoxPastEntries";
            this.textBoxPastEntries.ReadOnly = true;
            this.textBoxPastEntries.Size = new System.Drawing.Size(128, 153);
            this.textBoxPastEntries.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxPastEntries, "Displays the the units shits for all days entered so far.");
            // 
            // labelAvgOutput
            // 
            this.labelAvgOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAvgOutput.Location = new System.Drawing.Point(143, 226);
            this.labelAvgOutput.Name = "labelAvgOutput";
            this.labelAvgOutput.Size = new System.Drawing.Size(128, 30);
            this.labelAvgOutput.TabIndex = 4;
            this.labelAvgOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(33, 284);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to process the current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(168, 284);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "click to reset this form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(296, 284);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.ButtonExit, "click to end the application.");
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // formAvgshippedUnit
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(408, 342);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAvgOutput);
            this.Controls.Add(this.textBoxPastEntries);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxEntryNumber);
            this.Controls.Add(this.labelUnitsPrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAvgshippedUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AverageUntisShippedClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textBoxEntryNumber;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxPastEntries;
        private System.Windows.Forms.Label labelAvgOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button ButtonExit;
    }
}

