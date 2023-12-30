namespace homework_string___96
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
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnStarts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(12, 72);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(249, 22);
            this.txtMesaj.TabIndex = 0;
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEndsWith.Location = new System.Drawing.Point(12, 128);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(117, 46);
            this.btnEndsWith.TabIndex = 1;
            this.btnEndsWith.Text = "EndsWith";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndswith_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(7, 34);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(183, 25);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Merhaba, Ben Hilal!";
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndexOf.Location = new System.Drawing.Point(144, 128);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(117, 46);
            this.btnIndexOf.TabIndex = 3;
            this.btnIndexOf.Text = "İndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLast.Location = new System.Drawing.Point(12, 237);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(249, 46);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "LastIndexOf";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnStarts
            // 
            this.btnStarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStarts.Location = new System.Drawing.Point(12, 185);
            this.btnStarts.Name = "btnStarts";
            this.btnStarts.Size = new System.Drawing.Size(117, 46);
            this.btnStarts.TabIndex = 5;
            this.btnStarts.Text = "StartsWith";
            this.btnStarts.UseVisualStyleBackColor = true;
            this.btnStarts.Click += new System.EventHandler(this.btnStarts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.btnStarts);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.txtMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnStarts;
    }
}

