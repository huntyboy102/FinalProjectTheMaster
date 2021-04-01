
namespace FinalProjectTheMaster
{
    partial class TheMasterForm
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
            this.buttonAverageUnitsShipped = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonAverageUnitsShipped
            // 
            this.buttonAverageUnitsShipped.Location = new System.Drawing.Point(12, 0);
            this.buttonAverageUnitsShipped.Name = "buttonAverageUnitsShipped";
            this.buttonAverageUnitsShipped.Size = new System.Drawing.Size(239, 84);
            this.buttonAverageUnitsShipped.TabIndex = 0;
            this.buttonAverageUnitsShipped.Text = "Average Units Shipped";
            this.toolTip1.SetToolTip(this.buttonAverageUnitsShipped, "Click this to open the Average Units Shipped Form");
            this.buttonAverageUnitsShipped.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 90);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(239, 84);
            this.button.TabIndex = 1;
            this.button.Text = "button2";
            this.button.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 84);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 84);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 84);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TheMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 445);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonAverageUnitsShipped);
            this.Name = "TheMasterForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAverageUnitsShipped;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

