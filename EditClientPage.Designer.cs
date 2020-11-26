namespace CLIENTS_MANAGER
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
            this.rBttnFemale = new System.Windows.Forms.RadioButton();
            this.rBttnMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rBttnFemale
            // 
            this.rBttnFemale.AutoSize = true;
            this.rBttnFemale.Location = new System.Drawing.Point(33, 172);
            this.rBttnFemale.Name = "rBttnFemale";
            this.rBttnFemale.Size = new System.Drawing.Size(86, 21);
            this.rBttnFemale.TabIndex = 35;
            this.rBttnFemale.Text = "Femmina";
            this.rBttnFemale.UseVisualStyleBackColor = true;
            // 
            // rBttnMale
            // 
            this.rBttnMale.AutoSize = true;
            this.rBttnMale.Location = new System.Drawing.Point(33, 145);
            this.rBttnMale.Name = "rBttnMale";
            this.rBttnMale.Size = new System.Drawing.Size(81, 21);
            this.rBttnMale.TabIndex = 34;
            this.rBttnMale.Text = "Maschio";
            this.rBttnMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(494, 53);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthday.TabIndex = 33;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(489, 21);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(169, 29);
            this.lblBirthDate.TabIndex = 24;
            this.lblBirthDate.Text = "Data di nascita";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(489, 113);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(89, 29);
            this.lblHeight.TabIndex = 26;
            this.lblHeight.Text = "Altezza";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(494, 145);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(84, 27);
            this.txtHeight.TabIndex = 32;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleInput); 
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(243, 53);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(158, 27);
            this.txtSurname.TabIndex = 30;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(238, 113);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(150, 29);
            this.lblWeight.TabIndex = 25;
            this.lblWeight.Text = "Peso iniziale";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(243, 145);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(80, 27);
            this.txtWeight.TabIndex = 31;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleInput);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(238, 21);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(119, 29);
            this.lblSurname.TabIndex = 27;
            this.lblSurname.Text = "Cognome";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(28, 113);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(81, 29);
            this.lblSex.TabIndex = 28;
            this.lblSex.Text = "Sesso";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(28, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 29);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Nome";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(33, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 27);
            this.txtName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Metri";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(645, 366);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(130, 53);
            this.bttnCancel.TabIndex = 37;
            this.bttnCancel.Text = "Annulla";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnOk
            // 
            this.bttnOk.Location = new System.Drawing.Point(494, 366);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(130, 53);
            this.bttnOk.TabIndex = 36;
            this.bttnOk.Text = "OK";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // EditClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.rBttnFemale);
            this.Controls.Add(this.rBttnMale);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "EditClientPage";
            this.Text = "EditClientPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rBttnFemale;
        private System.Windows.Forms.RadioButton rBttnMale;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnOk;
    }
}