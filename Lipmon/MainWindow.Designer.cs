namespace Lipmon
{
    partial class MainWindow
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
            this.Connect = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.coordinatesTextBox = new System.Windows.Forms.TextBox();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(160, 30);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(180, 12);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(160, 30);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(348, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(160, 30);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // coordinatesTextBox
            // 
            this.coordinatesTextBox.Location = new System.Drawing.Point(12, 61);
            this.coordinatesTextBox.Name = "coordinatesTextBox";
            this.coordinatesTextBox.Size = new System.Drawing.Size(328, 20);
            this.coordinatesTextBox.TabIndex = 3;
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.Location = new System.Drawing.Point(60, 45);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(59, 13);
            this.ConnectedLabel.TabIndex = 4;
            this.ConnectedLabel.Text = "Connected";
            this.ConnectedLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(458, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controlled device:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(32, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = Device.ArmSmaller;
            this.radioButton3.Text = "Arm Smaller";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = Device.ArmBigger;
            this.radioButton2.Text = "Arm Bigger";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = Device.Platform;
            this.radioButton1.Text = "Platform";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConnectedLabel);
            this.Controls.Add(this.coordinatesTextBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Connect);
            this.Name = "MainWindow";
            this.Text = "Lipmon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox coordinatesTextBox;
        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

