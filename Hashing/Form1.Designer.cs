namespace Hashing
{
    partial class Form1
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
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.btnHash256 = new System.Windows.Forms.Button();
            this.btnHash512 = new System.Windows.Forms.Button();
            this.textBoxHashed = new System.Windows.Forms.TextBox();
            this.btnAddSalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(476, 34);
            this.textBoxOriginal.TabIndex = 0;
             // 
            // btnHash256
            // 
            this.btnHash256.Location = new System.Drawing.Point(332, 52);
            this.btnHash256.Name = "btnHash256";
            this.btnHash256.Size = new System.Drawing.Size(156, 61);
            this.btnHash256.TabIndex = 1;
            this.btnHash256.Text = "Hash256";
            this.btnHash256.UseVisualStyleBackColor = true;
            this.btnHash256.Click += new System.EventHandler(this.btnHash256_Click);
            // 
            // btnHash512
            // 
            this.btnHash512.Location = new System.Drawing.Point(12, 52);
            this.btnHash512.Name = "btnHash512";
            this.btnHash512.Size = new System.Drawing.Size(156, 61);
            this.btnHash512.TabIndex = 2;
            this.btnHash512.Text = "Hash512";
            this.btnHash512.UseVisualStyleBackColor = true;
            this.btnHash512.Click += new System.EventHandler(this.btnHash512_Click);
            // 
            // textBoxHashed
            // 
            this.textBoxHashed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHashed.Location = new System.Drawing.Point(12, 119);
            this.textBoxHashed.Name = "textBoxHashed";
            this.textBoxHashed.Size = new System.Drawing.Size(476, 34);
            this.textBoxHashed.TabIndex = 3;
            // 
            // btnAddSalt
            // 
            this.btnAddSalt.Location = new System.Drawing.Point(172, 52);
            this.btnAddSalt.Name = "btnAddSalt";
            this.btnAddSalt.Size = new System.Drawing.Size(156, 61);
            this.btnAddSalt.TabIndex = 4;
            this.btnAddSalt.Text = "Add Salt";
            this.btnAddSalt.UseVisualStyleBackColor = true;
            this.btnAddSalt.Click += new System.EventHandler(this.btnAddSalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 164);
            this.Controls.Add(this.btnAddSalt);
            this.Controls.Add(this.textBoxHashed);
            this.Controls.Add(this.btnHash512);
            this.Controls.Add(this.btnHash256);
            this.Controls.Add(this.textBoxOriginal);
            this.Name = "Form1";
            this.Text = "Hashing - Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.Button btnHash256;
        private System.Windows.Forms.Button btnHash512;
        private System.Windows.Forms.TextBox textBoxHashed;
        private System.Windows.Forms.Button btnAddSalt;
    }
}

