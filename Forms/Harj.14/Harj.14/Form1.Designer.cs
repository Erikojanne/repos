namespace Harj._14
{
    partial class DiaryForm
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
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.TalennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(12, 12);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(958, 390);
            this.SyottoTB.TabIndex = 0;
            // 
            // TalennaBT
            // 
            this.TalennaBT.Location = new System.Drawing.Point(12, 420);
            this.TalennaBT.Name = "TalennaBT";
            this.TalennaBT.Size = new System.Drawing.Size(958, 55);
            this.TalennaBT.TabIndex = 1;
            this.TalennaBT.Text = "Tallenna päiväkirjaan";
            this.TalennaBT.UseVisualStyleBackColor = true;
            this.TalennaBT.Click += new System.EventHandler(this.TalennaBT_Click);
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 487);
            this.Controls.Add(this.TalennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DiaryForm";
            this.Text = "Päiväkirja Janne Korhonen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SyottoTB;
        private Button TalennaBT;
    }
}