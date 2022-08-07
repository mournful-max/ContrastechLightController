namespace ContrastechLightController
{
    partial class ViewFrm
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
            this.lblChannel = new System.Windows.Forms.Label();
            this.btnOpenConn = new System.Windows.Forms.Button();
            this.btnCloseConn = new System.Windows.Forms.Button();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.btnSetBrightness = new System.Windows.Forms.Button();
            this.nudChannel = new System.Windows.Forms.NumericUpDown();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.lblComPortName = new System.Windows.Forms.Label();
            this.txtComPortName = new System.Windows.Forms.TextBox();
            this.gbCommunication = new System.Windows.Forms.GroupBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            this.gbCommunication.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(40, 33);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(63, 15);
            this.lblChannel.TabIndex = 0;
            this.lblChannel.Text = "Channel:";
            // 
            // btnOpenConn
            // 
            this.btnOpenConn.Location = new System.Drawing.Point(109, 69);
            this.btnOpenConn.Name = "btnOpenConn";
            this.btnOpenConn.Size = new System.Drawing.Size(148, 30);
            this.btnOpenConn.TabIndex = 2;
            this.btnOpenConn.Text = "Open connection";
            this.btnOpenConn.UseVisualStyleBackColor = true;
            this.btnOpenConn.Click += new System.EventHandler(this.btnOpenConn_Click);
            // 
            // btnCloseConn
            // 
            this.btnCloseConn.Location = new System.Drawing.Point(109, 105);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new System.Drawing.Size(148, 30);
            this.btnCloseConn.TabIndex = 3;
            this.btnCloseConn.Text = "Close connection";
            this.btnCloseConn.UseVisualStyleBackColor = true;
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(19, 65);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(84, 15);
            this.lblBrightness.TabIndex = 0;
            this.lblBrightness.Text = "Brightness:";
            // 
            // btnSetBrightness
            // 
            this.btnSetBrightness.Location = new System.Drawing.Point(47, 92);
            this.btnSetBrightness.Name = "btnSetBrightness";
            this.btnSetBrightness.Size = new System.Drawing.Size(148, 30);
            this.btnSetBrightness.TabIndex = 6;
            this.btnSetBrightness.Text = "Set brightness";
            this.btnSetBrightness.UseVisualStyleBackColor = true;
            this.btnSetBrightness.Click += new System.EventHandler(this.btnSetBrightness_Click);
            // 
            // nudChannel
            // 
            this.nudChannel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudChannel.Location = new System.Drawing.Point(109, 28);
            this.nudChannel.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChannel.Name = "nudChannel";
            this.nudChannel.Size = new System.Drawing.Size(64, 26);
            this.nudChannel.TabIndex = 4;
            this.nudChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBrightness
            // 
            this.nudBrightness.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudBrightness.Location = new System.Drawing.Point(109, 60);
            this.nudBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.Size = new System.Drawing.Size(86, 26);
            this.nudBrightness.TabIndex = 5;
            this.nudBrightness.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblComPortName
            // 
            this.lblComPortName.AutoSize = true;
            this.lblComPortName.Location = new System.Drawing.Point(26, 43);
            this.lblComPortName.Name = "lblComPortName";
            this.lblComPortName.Size = new System.Drawing.Size(77, 15);
            this.lblComPortName.TabIndex = 0;
            this.lblComPortName.Text = "Port name:";
            // 
            // txtComPortName
            // 
            this.txtComPortName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComPortName.Location = new System.Drawing.Point(109, 37);
            this.txtComPortName.Name = "txtComPortName";
            this.txtComPortName.Size = new System.Drawing.Size(148, 26);
            this.txtComPortName.TabIndex = 1;
            this.txtComPortName.Text = "COM";
            // 
            // gbCommunication
            // 
            this.gbCommunication.Controls.Add(this.txtComPortName);
            this.gbCommunication.Controls.Add(this.lblComPortName);
            this.gbCommunication.Controls.Add(this.btnOpenConn);
            this.gbCommunication.Controls.Add(this.btnCloseConn);
            this.gbCommunication.Location = new System.Drawing.Point(28, 30);
            this.gbCommunication.Name = "gbCommunication";
            this.gbCommunication.Size = new System.Drawing.Size(279, 156);
            this.gbCommunication.TabIndex = 0;
            this.gbCommunication.TabStop = false;
            this.gbCommunication.Text = "Communication";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.nudChannel);
            this.gbControl.Controls.Add(this.lblChannel);
            this.gbControl.Controls.Add(this.btnSetBrightness);
            this.gbControl.Controls.Add(this.nudBrightness);
            this.gbControl.Controls.Add(this.lblBrightness);
            this.gbControl.Location = new System.Drawing.Point(341, 37);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(216, 142);
            this.gbControl.TabIndex = 0;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // ViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 198);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbCommunication);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light controller test";
            this.Load += new System.EventHandler(this.ViewFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            this.gbCommunication.ResumeLayout(false);
            this.gbCommunication.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Button btnOpenConn;
        private System.Windows.Forms.Button btnCloseConn;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Button btnSetBrightness;
        private System.Windows.Forms.NumericUpDown nudChannel;
        private System.Windows.Forms.NumericUpDown nudBrightness;
        private System.Windows.Forms.Label lblComPortName;
        private System.Windows.Forms.TextBox txtComPortName;
        private System.Windows.Forms.GroupBox gbCommunication;
        private System.Windows.Forms.GroupBox gbControl;
    }
}

