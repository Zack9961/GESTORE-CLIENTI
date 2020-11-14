namespace PrototipoProgetto
{
    partial class MainPage
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewClient = new System.Windows.Forms.Label();
            this.bttnNewClient = new System.Windows.Forms.Button();
            this.lstVwMain = new System.Windows.Forms.ListView();
            this.cHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEditClient = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblClientPage = new System.Windows.Forms.Label();
            this.bttnClientPage = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnEditClient = new System.Windows.Forms.Button();
            this.bttnAddWeight = new System.Windows.Forms.Button();
            this.lblAddWeight = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewClient
            // 
            this.lblNewClient.AutoSize = true;
            this.lblNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewClient.Location = new System.Drawing.Point(201, 348);
            this.lblNewClient.Name = "lblNewClient";
            this.lblNewClient.Size = new System.Drawing.Size(106, 25);
            this.lblNewClient.TabIndex = 0;
            this.lblNewClient.Text = "New Client";
            // 
            // bttnNewClient
            // 
            this.bttnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNewClient.Location = new System.Drawing.Point(177, 376);
            this.bttnNewClient.Name = "bttnNewClient";
            this.bttnNewClient.Size = new System.Drawing.Size(152, 62);
            this.bttnNewClient.TabIndex = 1;
            this.bttnNewClient.Text = "➕";
            this.bttnNewClient.UseVisualStyleBackColor = true;
            this.bttnNewClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstVwMain
            // 
            this.lstVwMain.AccessibleDescription = "";
            this.lstVwMain.AccessibleName = "";
            this.lstVwMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHName,
            this.cHSurname,
            this.cHWeight,
            this.cHHeight,
            this.cHSex,
            this.cHAge});
            this.lstVwMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstVwMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVwMain.FullRowSelect = true;
            this.lstVwMain.GridLines = true;
            this.lstVwMain.HideSelection = false;
            this.lstVwMain.Location = new System.Drawing.Point(6, 21);
            this.lstVwMain.Name = "lstVwMain";
            this.lstVwMain.Size = new System.Drawing.Size(377, 292);
            this.lstVwMain.TabIndex = 4;
            this.lstVwMain.UseCompatibleStateImageBehavior = false;
            this.lstVwMain.View = System.Windows.Forms.View.Details;
            // 
            // cHName
            // 
            this.cHName.Text = "Name";
            this.cHName.Width = 84;
            // 
            // cHSurname
            // 
            this.cHSurname.Text = "Surname";
            this.cHSurname.Width = 83;
            // 
            // cHWeight
            // 
            this.cHWeight.Text = "Weight (Kg)";
            this.cHWeight.Width = 80;
            // 
            // cHHeight
            // 
            this.cHHeight.Text = "Height (M)";
            this.cHHeight.Width = 77;
            // 
            // cHSex
            // 
            this.cHSex.Text = "Sex";
            this.cHSex.Width = 49;
            // 
            // cHAge
            // 
            this.cHAge.Text = "Age";
            this.cHAge.Width = 51;
            // 
            // lblEditClient
            // 
            this.lblEditClient.AutoSize = true;
            this.lblEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClient.Location = new System.Drawing.Point(514, 348);
            this.lblEditClient.Name = "lblEditClient";
            this.lblEditClient.Size = new System.Drawing.Size(100, 25);
            this.lblEditClient.TabIndex = 6;
            this.lblEditClient.Text = "Edit Client";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(679, 348);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(68, 25);
            this.lblDelete.TabIndex = 7;
            this.lblDelete.Text = "Delete";
            // 
            // lblClientPage
            // 
            this.lblClientPage.AutoSize = true;
            this.lblClientPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPage.Location = new System.Drawing.Point(22, 348);
            this.lblClientPage.Name = "lblClientPage";
            this.lblClientPage.Size = new System.Drawing.Size(113, 25);
            this.lblClientPage.TabIndex = 8;
            this.lblClientPage.Text = "Client Page";
            this.lblClientPage.Click += new System.EventHandler(this.lblClientPage_Click);
            // 
            // bttnClientPage
            // 
            this.bttnClientPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClientPage.Location = new System.Drawing.Point(19, 376);
            this.bttnClientPage.Name = "bttnClientPage";
            this.bttnClientPage.Size = new System.Drawing.Size(152, 62);
            this.bttnClientPage.TabIndex = 9;
            this.bttnClientPage.Text = "🙋🏽";
            this.bttnClientPage.UseVisualStyleBackColor = true;
            this.bttnClientPage.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.Location = new System.Drawing.Point(641, 376);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(152, 62);
            this.bttnDelete.TabIndex = 10;
            this.bttnDelete.Text = "🗑️";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // bttnEditClient
            // 
            this.bttnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEditClient.Location = new System.Drawing.Point(486, 376);
            this.bttnEditClient.Name = "bttnEditClient";
            this.bttnEditClient.Size = new System.Drawing.Size(152, 62);
            this.bttnEditClient.TabIndex = 11;
            this.bttnEditClient.Text = "✏️";
            this.bttnEditClient.UseVisualStyleBackColor = true;
            this.bttnEditClient.Click += new System.EventHandler(this.bttnEditClient_Click);
            // 
            // bttnAddWeight
            // 
            this.bttnAddWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddWeight.Location = new System.Drawing.Point(332, 376);
            this.bttnAddWeight.Name = "bttnAddWeight";
            this.bttnAddWeight.Size = new System.Drawing.Size(152, 62);
            this.bttnAddWeight.TabIndex = 12;
            this.bttnAddWeight.Text = "⚖️";
            this.bttnAddWeight.UseVisualStyleBackColor = true;
            this.bttnAddWeight.Click += new System.EventHandler(this.bttnAddWeight_Click);
            // 
            // lblAddWeight
            // 
            this.lblAddWeight.AutoSize = true;
            this.lblAddWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWeight.Location = new System.Drawing.Point(352, 348);
            this.lblAddWeight.Name = "lblAddWeight";
            this.lblAddWeight.Size = new System.Drawing.Size(115, 25);
            this.lblAddWeight.TabIndex = 13;
            this.lblAddWeight.Text = "Add Weight";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstVwMain);
            this.groupBox2.Location = new System.Drawing.Point(19, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 322);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 313);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weight List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(367, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblAddWeight);
            this.Controls.Add(this.bttnAddWeight);
            this.Controls.Add(this.bttnEditClient);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnClientPage);
            this.Controls.Add(this.lblClientPage);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEditClient);
            this.Controls.Add(this.bttnNewClient);
            this.Controls.Add(this.lblNewClient);
            this.Name = "MainPage";
            this.Text = "Main";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewClient;
        private System.Windows.Forms.Button bttnNewClient;
        private System.Windows.Forms.ListView lstVwMain;
        private System.Windows.Forms.Label lblEditClient;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblClientPage;
        private System.Windows.Forms.Button bttnClientPage;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnEditClient;
        private System.Windows.Forms.Button bttnAddWeight;
        private System.Windows.Forms.Label lblAddWeight;
        private System.Windows.Forms.ColumnHeader cHName;
        private System.Windows.Forms.ColumnHeader cHSurname;
        private System.Windows.Forms.ColumnHeader cHWeight;
        private System.Windows.Forms.ColumnHeader cHHeight;
        private System.Windows.Forms.ColumnHeader cHSex;
        private System.Windows.Forms.ColumnHeader cHAge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

