namespace JenkinsTest
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
            this.components = new System.ComponentModel.Container();
            this.buttonPass = new System.Windows.Forms.Button();
            this.buttonFail = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonPass
            // 
            this.buttonPass.BackColor = System.Drawing.Color.Lime;
            this.buttonPass.Location = new System.Drawing.Point(13, 13);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(75, 23);
            this.buttonPass.TabIndex = 0;
            this.buttonPass.Text = "Pass";
            this.buttonPass.UseVisualStyleBackColor = false;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // buttonFail
            // 
            this.buttonFail.BackColor = System.Drawing.Color.Red;
            this.buttonFail.Location = new System.Drawing.Point(94, 13);
            this.buttonFail.Name = "buttonFail";
            this.buttonFail.Size = new System.Drawing.Size(75, 23);
            this.buttonFail.TabIndex = 1;
            this.buttonFail.Text = "Fail";
            this.buttonFail.UseVisualStyleBackColor = false;
            this.buttonFail.Click += new System.EventHandler(this.buttonFail_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 77);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonFail);
            this.Controls.Add(this.buttonPass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "   ";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Button buttonFail;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerProgress;
    }
}

