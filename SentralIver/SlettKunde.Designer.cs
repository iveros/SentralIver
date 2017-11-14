namespace SentralIver
{
    partial class SlettKunde
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
            this.txtSlett = new System.Windows.Forms.TextBox();
            this.btnSlett = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skriv inn KID på kunde ønsker å slette";
            // 
            // txtSlett
            // 
            this.txtSlett.Location = new System.Drawing.Point(38, 58);
            this.txtSlett.Name = "txtSlett";
            this.txtSlett.Size = new System.Drawing.Size(131, 22);
            this.txtSlett.TabIndex = 1;
            // 
            // btnSlett
            // 
            this.btnSlett.Location = new System.Drawing.Point(175, 56);
            this.btnSlett.Name = "btnSlett";
            this.btnSlett.Size = new System.Drawing.Size(85, 24);
            this.btnSlett.TabIndex = 2;
            this.btnSlett.Text = "Slett";
            this.btnSlett.UseVisualStyleBackColor = true;
            this.btnSlett.Click += new System.EventHandler(this.btnSlett_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(175, 108);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(85, 29);
            this.btnAvbryt.TabIndex = 3;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            this.btnAvbryt.Click += new System.EventHandler(this.btnAvbryt_Click);
            // 
            // SlettKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSlett);
            this.Controls.Add(this.txtSlett);
            this.Controls.Add(this.label1);
            this.Name = "SlettKunde";
            this.Text = "SlettKunde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlett;
        private System.Windows.Forms.Button btnSlett;
        private System.Windows.Forms.Button btnAvbryt;
    }
}