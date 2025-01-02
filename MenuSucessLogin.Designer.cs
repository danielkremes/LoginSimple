namespace LoginSimple
{
    partial class MenuSucessLogin
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
            this.msgWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgWelcome
            // 
            this.msgWelcome.AutoSize = true;
            this.msgWelcome.Location = new System.Drawing.Point(167, 9);
            this.msgWelcome.Name = "msgWelcome";
            this.msgWelcome.Size = new System.Drawing.Size(83, 13);
            this.msgWelcome.TabIndex = 0;
            this.msgWelcome.Text = "You`re welcome";
            this.msgWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuSucessLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 205);
            this.Controls.Add(this.msgWelcome);
            this.Name = "MenuSucessLogin";
            this.Text = "MenuSucessLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgWelcome;
    }
}