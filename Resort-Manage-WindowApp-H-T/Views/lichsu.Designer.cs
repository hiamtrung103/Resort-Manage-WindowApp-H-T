namespace Resort_Manage_WindowApp_H_T.Interface
{
    partial class lichsu
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
            label27 = new Label();
            SuspendLayout();
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(12, 9);
            label27.Name = "label27";
            label27.Size = new Size(95, 29);
            label27.TabIndex = 7;
            label27.Text = "Lịch sử";
            // 
            // lichsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 711);
            Controls.Add(label27);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lichsu";
            Text = "lichsu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label27;
    }
}