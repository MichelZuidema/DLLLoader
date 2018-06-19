namespace DLLLoader
{
    partial class Form2
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
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtSystemHWID = new System.Windows.Forms.TextBox();
            this.btnInject = new System.Windows.Forms.Button();
            this.btnCopyHWID = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(9, 9);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(68, 13);
            this.lblCheck.TabIndex = 0;
            this.lblCheck.Text = "Hello, World!";
            // 
            // txtSystemHWID
            // 
            this.txtSystemHWID.Location = new System.Drawing.Point(12, 40);
            this.txtSystemHWID.Name = "txtSystemHWID";
            this.txtSystemHWID.Size = new System.Drawing.Size(287, 20);
            this.txtSystemHWID.TabIndex = 1;
            this.txtSystemHWID.Text = "S-1-5-21-472196058-1765021086-2834703902-1001";
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(156, 66);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(143, 47);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // btnCopyHWID
            // 
            this.btnCopyHWID.Location = new System.Drawing.Point(12, 66);
            this.btnCopyHWID.Name = "btnCopyHWID";
            this.btnCopyHWID.Size = new System.Drawing.Size(143, 47);
            this.btnCopyHWID.TabIndex = 4;
            this.btnCopyHWID.Text = "Copy HWID";
            this.btnCopyHWID.UseVisualStyleBackColor = true;
            this.btnCopyHWID.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(287, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Internet Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(90, 159);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "lblStatus";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 381);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCopyHWID);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.txtSystemHWID);
            this.Controls.Add(this.lblCheck);
            this.Name = "Form2";
            this.Text = "Injector - Inject Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox txtSystemHWID;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnCopyHWID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
    }
}