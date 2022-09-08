namespace PrivatePC
{
    partial class Sheet2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sheet2));
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtLarge2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.White;
            this.btnSave2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave2.BackgroundImage")));
            this.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave2.Font = new System.Drawing.Font("Cooper Std Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave2.Location = new System.Drawing.Point(12, 6);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(102, 96);
            this.btnSave2.TabIndex = 11;
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLarge2
            // 
            this.txtLarge2.BackColor = System.Drawing.Color.White;
            this.txtLarge2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLarge2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLarge2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLarge2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLarge2.Location = new System.Drawing.Point(0, 108);
            this.txtLarge2.Name = "txtLarge2";
            this.txtLarge2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtLarge2.Size = new System.Drawing.Size(841, 569);
            this.txtLarge2.TabIndex = 10;
            this.txtLarge2.Text = "";
            // 
            // Sheet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(841, 677);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.txtLarge2);
            this.Name = "Sheet2";
            this.Text = "Sheet2";
            this.Load += new System.EventHandler(this.Sheet2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave2;
        public System.Windows.Forms.RichTextBox txtLarge2;
    }
}