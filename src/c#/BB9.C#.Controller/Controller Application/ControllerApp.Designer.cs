namespace NET_RobotController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GrabberCtrl = new System.Windows.Forms.TrackBar();
            this.GrabberLabel = new System.Windows.Forms.Label();
            this.ShoulderLabel = new System.Windows.Forms.Label();
            this.ShoulderCtrl = new System.Windows.Forms.TrackBar();
            this.ElbowLabel = new System.Windows.Forms.Label();
            this.ElbowCtrl = new System.Windows.Forms.TrackBar();
            this.WristLabel = new System.Windows.Forms.Label();
            this.WristCtrl = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrabberCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoulderCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElbowCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WristCtrl)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrabberCtrl
            // 
            this.GrabberCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(240)))));
            this.GrabberCtrl.Location = new System.Drawing.Point(383, 96);
            this.GrabberCtrl.Maximum = 100;
            this.GrabberCtrl.Name = "GrabberCtrl";
            this.GrabberCtrl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GrabberCtrl.Size = new System.Drawing.Size(45, 265);
            this.GrabberCtrl.SmallChange = 5;
            this.GrabberCtrl.TabIndex = 0;
            this.GrabberCtrl.TickFrequency = 0;
            this.GrabberCtrl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.GrabberCtrl.Scroll += new System.EventHandler(this.Grabber_Scroll);
            // 
            // GrabberLabel
            // 
            this.GrabberLabel.AutoSize = true;
            this.GrabberLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrabberLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrabberLabel.Location = new System.Drawing.Point(367, 74);
            this.GrabberLabel.Name = "GrabberLabel";
            this.GrabberLabel.Size = new System.Drawing.Size(80, 19);
            this.GrabberLabel.TabIndex = 3;
            this.GrabberLabel.Text = "Grabber ";
            this.GrabberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShoulderLabel
            // 
            this.ShoulderLabel.AutoSize = true;
            this.ShoulderLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoulderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShoulderLabel.Location = new System.Drawing.Point(33, 74);
            this.ShoulderLabel.Name = "ShoulderLabel";
            this.ShoulderLabel.Size = new System.Drawing.Size(81, 19);
            this.ShoulderLabel.TabIndex = 6;
            this.ShoulderLabel.Text = "Shoulder";
            this.ShoulderLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ShoulderCtrl
            // 
            this.ShoulderCtrl.Location = new System.Drawing.Point(45, 96);
            this.ShoulderCtrl.Maximum = 100;
            this.ShoulderCtrl.Name = "ShoulderCtrl";
            this.ShoulderCtrl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ShoulderCtrl.Size = new System.Drawing.Size(45, 265);
            this.ShoulderCtrl.SmallChange = 5;
            this.ShoulderCtrl.TabIndex = 4;
            this.ShoulderCtrl.TickFrequency = 0;
            this.ShoulderCtrl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ShoulderCtrl.Scroll += new System.EventHandler(this.ShoulderCtrl_Scroll);
            // 
            // ElbowLabel
            // 
            this.ElbowLabel.AutoSize = true;
            this.ElbowLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElbowLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ElbowLabel.Location = new System.Drawing.Point(155, 74);
            this.ElbowLabel.Name = "ElbowLabel";
            this.ElbowLabel.Size = new System.Drawing.Size(58, 19);
            this.ElbowLabel.TabIndex = 9;
            this.ElbowLabel.Text = "Elbow";
            this.ElbowLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ElbowCtrl
            // 
            this.ElbowCtrl.Location = new System.Drawing.Point(159, 96);
            this.ElbowCtrl.Maximum = 100;
            this.ElbowCtrl.Name = "ElbowCtrl";
            this.ElbowCtrl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ElbowCtrl.Size = new System.Drawing.Size(45, 265);
            this.ElbowCtrl.SmallChange = 5;
            this.ElbowCtrl.TabIndex = 7;
            this.ElbowCtrl.TickFrequency = 0;
            this.ElbowCtrl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ElbowCtrl.Scroll += new System.EventHandler(this.ElbowCtrl_Scroll);
            // 
            // WristLabel
            // 
            this.WristLabel.AutoSize = true;
            this.WristLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WristLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WristLabel.Location = new System.Drawing.Point(261, 74);
            this.WristLabel.Name = "WristLabel";
            this.WristLabel.Size = new System.Drawing.Size(52, 19);
            this.WristLabel.TabIndex = 12;
            this.WristLabel.Text = "Wrist";
            // 
            // WristCtrl
            // 
            this.WristCtrl.Location = new System.Drawing.Point(265, 96);
            this.WristCtrl.Maximum = 100;
            this.WristCtrl.Name = "WristCtrl";
            this.WristCtrl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.WristCtrl.Size = new System.Drawing.Size(45, 265);
            this.WristCtrl.SmallChange = 5;
            this.WristCtrl.TabIndex = 10;
            this.WristCtrl.TickFrequency = 0;
            this.WristCtrl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.WristCtrl.Scroll += new System.EventHandler(this.WristCtrl_Scroll);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "JKI Robot Controller (C#)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 66);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(505, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WristLabel);
            this.Controls.Add(this.WristCtrl);
            this.Controls.Add(this.ElbowLabel);
            this.Controls.Add(this.ElbowCtrl);
            this.Controls.Add(this.ShoulderLabel);
            this.Controls.Add(this.ShoulderCtrl);
            this.Controls.Add(this.GrabberLabel);
            this.Controls.Add(this.GrabberCtrl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrabberCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoulderCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElbowCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WristCtrl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar GrabberCtrl;
        private System.Windows.Forms.Label GrabberLabel;
        private System.Windows.Forms.Label ShoulderLabel;
        private System.Windows.Forms.TrackBar ShoulderCtrl;
        private System.Windows.Forms.Label ElbowLabel;
        private System.Windows.Forms.TrackBar ElbowCtrl;
        private System.Windows.Forms.Label WristLabel;
        private System.Windows.Forms.TrackBar WristCtrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

