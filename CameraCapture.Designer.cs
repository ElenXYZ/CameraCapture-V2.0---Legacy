namespace CameraCapture
{
    partial class CameraCapture
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
            this.flipVerticalButton = new System.Windows.Forms.Button();
            this.flipHorizontalButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Setting_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuerySmallFrame = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sharpness_SLD = new System.Windows.Forms.TrackBar();
            this.Sharpness_LBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Brigtness_SLD = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Brigthness_LBL = new System.Windows.Forms.Label();
            this.Contrast_LBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Contrast_SLD = new System.Windows.Forms.TrackBar();
            this.Reset_Cam_Settings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Refresh_BTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RetrieveGrayFrame = new System.Windows.Forms.CheckBox();
            this.RetrieveBgrFrame = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Camera_Selection = new System.Windows.Forms.ComboBox();
            this.Cam_lbl = new System.Windows.Forms.Label();
            this.captureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpness_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brigtness_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_SLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flipVerticalButton
            // 
            this.flipVerticalButton.Location = new System.Drawing.Point(18, 131);
            this.flipVerticalButton.Name = "flipVerticalButton";
            this.flipVerticalButton.Size = new System.Drawing.Size(102, 23);
            this.flipVerticalButton.TabIndex = 2;
            this.flipVerticalButton.Text = "Flip Vertical";
            this.flipVerticalButton.UseVisualStyleBackColor = true;
            this.flipVerticalButton.Click += new System.EventHandler(this.FlipVerticalButtonClick);
            // 
            // flipHorizontalButton
            // 
            this.flipHorizontalButton.Location = new System.Drawing.Point(126, 131);
            this.flipHorizontalButton.Name = "flipHorizontalButton";
            this.flipHorizontalButton.Size = new System.Drawing.Size(102, 23);
            this.flipHorizontalButton.TabIndex = 1;
            this.flipHorizontalButton.Text = "Flip Horizontal";
            this.flipHorizontalButton.UseVisualStyleBackColor = true;
            this.flipHorizontalButton.Click += new System.EventHandler(this.FlipHorizontalButtonClick);
            // 
            // captureButton
            // 
            this.captureButton.Enabled = false;
            this.captureButton.Location = new System.Drawing.Point(18, 63);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(102, 23);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Setting_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cam_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.captureBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 752);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Setting_lbl
            // 
            this.Setting_lbl.AutoSize = true;
            this.Setting_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_lbl.Location = new System.Drawing.Point(412, 0);
            this.Setting_lbl.Name = "Setting_lbl";
            this.Setting_lbl.Size = new System.Drawing.Size(64, 16);
            this.Setting_lbl.TabIndex = 2;
            this.Setting_lbl.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.QuerySmallFrame);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Reset_Cam_Settings);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Refresh_BTN);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RetrieveGrayFrame);
            this.panel1.Controls.Add(this.RetrieveBgrFrame);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Camera_Selection);
            this.panel1.Controls.Add(this.captureButton);
            this.panel1.Controls.Add(this.flipHorizontalButton);
            this.panel1.Controls.Add(this.flipVerticalButton);
            this.panel1.Location = new System.Drawing.Point(412, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 726);
            this.panel1.TabIndex = 0;
            // 
            // QuerySmallFrame
            // 
            this.QuerySmallFrame.AutoSize = true;
            this.QuerySmallFrame.Location = new System.Drawing.Point(176, 174);
            this.QuerySmallFrame.Name = "QuerySmallFrame";
            this.QuerySmallFrame.Size = new System.Drawing.Size(114, 17);
            this.QuerySmallFrame.TabIndex = 25;
            this.QuerySmallFrame.Text = "Query Small Frame";
            this.QuerySmallFrame.UseVisualStyleBackColor = true;
            this.QuerySmallFrame.CheckedChanged += new System.EventHandler(this.QuerySmallFrame_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.Sharpness_SLD);
            this.panel2.Controls.Add(this.Sharpness_LBL);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Brigtness_SLD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Brigthness_LBL);
            this.panel2.Controls.Add(this.Contrast_LBL);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Contrast_SLD);
            this.panel2.Location = new System.Drawing.Point(3, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 285);
            this.panel2.TabIndex = 24;
            // 
            // Sharpness_SLD
            // 
            this.Sharpness_SLD.Location = new System.Drawing.Point(102, 105);
            this.Sharpness_SLD.Maximum = 200;
            this.Sharpness_SLD.Name = "Sharpness_SLD";
            this.Sharpness_SLD.Size = new System.Drawing.Size(238, 45);
            this.Sharpness_SLD.TabIndex = 21;
            this.Sharpness_SLD.TickFrequency = 5;
            this.Sharpness_SLD.Scroll += new System.EventHandler(this.Sharpness_SLD_Scroll);
            // 
            // Sharpness_LBL
            // 
            this.Sharpness_LBL.AutoSize = true;
            this.Sharpness_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sharpness_LBL.Location = new System.Drawing.Point(346, 105);
            this.Sharpness_LBL.Name = "Sharpness_LBL";
            this.Sharpness_LBL.Size = new System.Drawing.Size(16, 16);
            this.Sharpness_LBL.TabIndex = 22;
            this.Sharpness_LBL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sharpness:";
            // 
            // Brigtness_SLD
            // 
            this.Brigtness_SLD.Location = new System.Drawing.Point(102, 3);
            this.Brigtness_SLD.Maximum = 100;
            this.Brigtness_SLD.Name = "Brigtness_SLD";
            this.Brigtness_SLD.Size = new System.Drawing.Size(238, 45);
            this.Brigtness_SLD.TabIndex = 14;
            this.Brigtness_SLD.TickFrequency = 5;
            this.Brigtness_SLD.Scroll += new System.EventHandler(this.Brigtness_SLD_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contrast:";
            // 
            // Brigthness_LBL
            // 
            this.Brigthness_LBL.AutoSize = true;
            this.Brigthness_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brigthness_LBL.Location = new System.Drawing.Point(346, 3);
            this.Brigthness_LBL.Name = "Brigthness_LBL";
            this.Brigthness_LBL.Size = new System.Drawing.Size(16, 16);
            this.Brigthness_LBL.TabIndex = 15;
            this.Brigthness_LBL.Text = "0";
            // 
            // Contrast_LBL
            // 
            this.Contrast_LBL.AutoSize = true;
            this.Contrast_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrast_LBL.Location = new System.Drawing.Point(346, 54);
            this.Contrast_LBL.Name = "Contrast_LBL";
            this.Contrast_LBL.Size = new System.Drawing.Size(16, 16);
            this.Contrast_LBL.TabIndex = 19;
            this.Contrast_LBL.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Brightness:";
            // 
            // Contrast_SLD
            // 
            this.Contrast_SLD.Location = new System.Drawing.Point(102, 54);
            this.Contrast_SLD.Maximum = 200;
            this.Contrast_SLD.Name = "Contrast_SLD";
            this.Contrast_SLD.Size = new System.Drawing.Size(238, 45);
            this.Contrast_SLD.TabIndex = 18;
            this.Contrast_SLD.TickFrequency = 5;
            this.Contrast_SLD.Scroll += new System.EventHandler(this.Contrast_SLD_Scroll);
            // 
            // Reset_Cam_Settings
            // 
            this.Reset_Cam_Settings.Location = new System.Drawing.Point(298, 542);
            this.Reset_Cam_Settings.Name = "Reset_Cam_Settings";
            this.Reset_Cam_Settings.Size = new System.Drawing.Size(102, 23);
            this.Reset_Cam_Settings.TabIndex = 17;
            this.Reset_Cam_Settings.Text = "Reset";
            this.Reset_Cam_Settings.UseVisualStyleBackColor = true;
            this.Reset_Cam_Settings.Click += new System.EventHandler(this.Reset_Cam_Settings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Settings";
            // 
            // Refresh_BTN
            // 
            this.Refresh_BTN.Location = new System.Drawing.Point(298, 697);
            this.Refresh_BTN.Name = "Refresh_BTN";
            this.Refresh_BTN.Size = new System.Drawing.Size(102, 23);
            this.Refresh_BTN.TabIndex = 12;
            this.Refresh_BTN.Text = "Refresh";
            this.Refresh_BTN.UseVisualStyleBackColor = true;
            this.Refresh_BTN.Click += new System.EventHandler(this.Refresh_BTN_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 591);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 100);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Info";
            // 
            // RetrieveGrayFrame
            // 
            this.RetrieveGrayFrame.AutoSize = true;
            this.RetrieveGrayFrame.Location = new System.Drawing.Point(40, 197);
            this.RetrieveGrayFrame.Name = "RetrieveGrayFrame";
            this.RetrieveGrayFrame.Size = new System.Drawing.Size(123, 17);
            this.RetrieveGrayFrame.TabIndex = 9;
            this.RetrieveGrayFrame.Text = "Retrieve Gray Frame";
            this.RetrieveGrayFrame.UseVisualStyleBackColor = true;
            this.RetrieveGrayFrame.CheckedChanged += new System.EventHandler(this.RetrieveGrayFrame_CheckedChanged);
            // 
            // RetrieveBgrFrame
            // 
            this.RetrieveBgrFrame.AutoSize = true;
            this.RetrieveBgrFrame.Checked = true;
            this.RetrieveBgrFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RetrieveBgrFrame.Location = new System.Drawing.Point(40, 174);
            this.RetrieveBgrFrame.Name = "RetrieveBgrFrame";
            this.RetrieveBgrFrame.Size = new System.Drawing.Size(117, 17);
            this.RetrieveBgrFrame.TabIndex = 8;
            this.RetrieveBgrFrame.Text = "Retrieve Bgr Frame";
            this.RetrieveBgrFrame.UseVisualStyleBackColor = true;
            this.RetrieveBgrFrame.CheckedChanged += new System.EventHandler(this.RetrieveBgrFrame_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera";
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.FormattingEnabled = true;
            this.Camera_Selection.Location = new System.Drawing.Point(18, 36);
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(230, 21);
            this.Camera_Selection.TabIndex = 3;
            // 
            // Cam_lbl
            // 
            this.Cam_lbl.AutoSize = true;
            this.Cam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cam_lbl.Location = new System.Drawing.Point(3, 0);
            this.Cam_lbl.Name = "Cam_lbl";
            this.Cam_lbl.Size = new System.Drawing.Size(99, 16);
            this.Cam_lbl.TabIndex = 1;
            this.Cam_lbl.Text = "Camera View";
            // 
            // captureBox
            // 
            this.captureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureBox.Location = new System.Drawing.Point(3, 23);
            this.captureBox.Name = "captureBox";
            this.captureBox.Size = new System.Drawing.Size(403, 726);
            this.captureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.captureBox.TabIndex = 3;
            this.captureBox.TabStop = false;
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 776);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CameraCapture";
            this.Text = "Camera Capture - Legacy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sharpness_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brigtness_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_SLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button flipHorizontalButton;
        private System.Windows.Forms.Button flipVerticalButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Setting_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Cam_lbl;
        private System.Windows.Forms.ComboBox Camera_Selection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox captureBox;
        private System.Windows.Forms.CheckBox RetrieveBgrFrame;
        private System.Windows.Forms.CheckBox RetrieveGrayFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Refresh_BTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Brigthness_LBL;
        private System.Windows.Forms.TrackBar Brigtness_SLD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset_Cam_Settings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Contrast_LBL;
        private System.Windows.Forms.TrackBar Contrast_SLD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar Sharpness_SLD;
        private System.Windows.Forms.Label Sharpness_LBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox QuerySmallFrame;
    }
}

