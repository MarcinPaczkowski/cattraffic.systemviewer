namespace CatTraffic.SystemViewer.TcpTestClient
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxPort = new System.Windows.Forms.TextBox();
            this.uxTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // uxIpAddress
            // 
            this.uxIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxIpAddress.Location = new System.Drawing.Point(59, 11);
            this.uxIpAddress.Name = "uxIpAddress";
            this.uxIpAddress.Size = new System.Drawing.Size(170, 26);
            this.uxIpAddress.TabIndex = 1;
            this.uxIpAddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // uxPort
            // 
            this.uxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxPort.Location = new System.Drawing.Point(59, 42);
            this.uxPort.Name = "uxPort";
            this.uxPort.Size = new System.Drawing.Size(170, 26);
            this.uxPort.TabIndex = 3;
            this.uxPort.Text = "6666";
            // 
            // uxTest
            // 
            this.uxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxTest.Location = new System.Drawing.Point(6, 74);
            this.uxTest.Name = "uxTest";
            this.uxTest.Size = new System.Drawing.Size(223, 42);
            this.uxTest.TabIndex = 4;
            this.uxTest.Text = "Testuj";
            this.uxTest.UseVisualStyleBackColor = true;
            this.uxTest.Click += new System.EventHandler(this.uxTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 126);
            this.Controls.Add(this.uxTest);
            this.Controls.Add(this.uxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxIpAddress);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Tcp Test Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxPort;
        private System.Windows.Forms.Button uxTest;
    }
}

