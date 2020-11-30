namespace CLIENTS_MANAGER
{
    partial class AddWeightPage
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblAddWeight = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpWeightData = new System.Windows.Forms.DateTimePicker();
            this.bttnOk = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(337, 267);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(141, 30);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleInput);
            // 
            // lblAddWeight
            // 
            this.lblAddWeight.AutoSize = true;
            this.lblAddWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWeight.Location = new System.Drawing.Point(318, 235);
            this.lblAddWeight.Name = "lblAddWeight";
            this.lblAddWeight.Size = new System.Drawing.Size(180, 29);
            this.lblAddWeight.TabIndex = 2;
            this.lblAddWeight.Text = "Inserisci il peso";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(318, 86);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(185, 29);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Inserisci la data ";
            // 
            // dtpWeightData
            // 
            this.dtpWeightData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeightData.Location = new System.Drawing.Point(229, 118);
            this.dtpWeightData.Name = "dtpWeightData";
            this.dtpWeightData.Size = new System.Drawing.Size(362, 30);
            this.dtpWeightData.TabIndex = 4;
            // 
            // bttnOk
            // 
            this.bttnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnOk.Location = new System.Drawing.Point(509, 385);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(130, 53);
            this.bttnOk.TabIndex = 5;
            this.bttnOk.Text = "OK";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.Location = new System.Drawing.Point(658, 385);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(130, 53);
            this.bttnCancel.TabIndex = 6;
            this.bttnCancel.Text = "Annulla";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kg";
            // 
            // AddWeightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.dtpWeightData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblAddWeight);
            this.Controls.Add(this.txtWeight);
            this.Name = "AddWeightPage";
            this.Text = "AddWeightPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblAddWeight;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpWeightData;
        private System.Windows.Forms.Button bttnOk;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label label1;
    }
}