namespace PrivatePC
{
    partial class Sheet3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sheet3));
            this.btnSave3 = new System.Windows.Forms.Button();
            this.txtLarge3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave3
            // 
            this.btnSave3.BackColor = System.Drawing.Color.White;
            this.btnSave3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave3.BackgroundImage")));
            this.btnSave3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave3.Font = new System.Drawing.Font("Cooper Std Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave3.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave3.Location = new System.Drawing.Point(12, 3);
            this.btnSave3.Name = "btnSave3";
            this.btnSave3.Size = new System.Drawing.Size(102, 96);
            this.btnSave3.TabIndex = 13;
            this.btnSave3.UseVisualStyleBackColor = false;
            this.btnSave3.Click += new System.EventHandler(this.btnSave3_Click);
            // 
            // txtLarge3
            // 
            this.txtLarge3.BackColor = System.Drawing.Color.White;
            this.txtLarge3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLarge3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLarge3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLarge3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLarge3.Location = new System.Drawing.Point(0, 116);
            this.txtLarge3.Name = "txtLarge3";
            this.txtLarge3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtLarge3.Size = new System.Drawing.Size(766, 518);
            this.txtLarge3.TabIndex = 12;
            this.txtLarge3.Text = "";
            // 
            // Sheet3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(766, 634);
            this.Controls.Add(this.btnSave3);
            this.Controls.Add(this.txtLarge3);
            this.Name = "Sheet3";
            this.Text = "Sheet3";
            this.Load += new System.EventHandler(this.Sheet3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave3;
        public System.Windows.Forms.RichTextBox txtLarge3;
    }
}