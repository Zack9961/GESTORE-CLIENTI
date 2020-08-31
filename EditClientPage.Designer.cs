namespace Prova2
{
    partial class EditClientPage
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnDiscard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(42, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(48, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 22);
            this.txtName.TabIndex = 1;
            // 
            // bttnSave
            // 
            this.bttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSave.Location = new System.Drawing.Point(488, 375);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(136, 58);
            this.bttnSave.TabIndex = 2;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnDiscard
            // 
            this.bttnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDiscard.Location = new System.Drawing.Point(645, 375);
            this.bttnDiscard.Name = "bttnDiscard";
            this.bttnDiscard.Size = new System.Drawing.Size(143, 58);
            this.bttnDiscard.TabIndex = 3;
            this.bttnDiscard.Text = "Discard";
            this.bttnDiscard.UseVisualStyleBackColor = true;
            // 
            // EditClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnDiscard);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "EditClientPage";
            this.Text = "EditClientPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Button bttnDiscard;
    }
}