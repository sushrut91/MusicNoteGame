namespace MusicNoteClient
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.InsructionsLbl = new System.Windows.Forms.Label();
            this.HelpTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsructionsLbl
            // 
            this.InsructionsLbl.AutoSize = true;
            this.InsructionsLbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsructionsLbl.Location = new System.Drawing.Point(199, 21);
            this.InsructionsLbl.Name = "InsructionsLbl";
            this.InsructionsLbl.Size = new System.Drawing.Size(119, 26);
            this.InsructionsLbl.TabIndex = 0;
            this.InsructionsLbl.Text = "Instructions";
            // 
            // HelpTxt
            // 
            this.HelpTxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.HelpTxt.Enabled = false;
            this.HelpTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpTxt.ForeColor = System.Drawing.Color.DarkOrange;
            this.HelpTxt.Location = new System.Drawing.Point(12, 50);
            this.HelpTxt.Multiline = true;
            this.HelpTxt.Name = "HelpTxt";
            this.HelpTxt.Size = new System.Drawing.Size(492, 201);
            this.HelpTxt.TabIndex = 1;
            this.HelpTxt.Text = resources.GetString("HelpTxt.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 264);
            this.Controls.Add(this.HelpTxt);
            this.Controls.Add(this.InsructionsLbl);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsructionsLbl;
        private System.Windows.Forms.TextBox HelpTxt;
    }
}