namespace CLIENTS_MANAGER
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.grpBoxClientList = new System.Windows.Forms.GroupBox();
            this.grpBoxWeightChart = new System.Windows.Forms.GroupBox();
            this.chrtWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBoxClientList.SuspendLayout();
            this.grpBoxWeightChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewClient
            // 
            this.lblNewClient.AutoSize = true;
            this.lblNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewClient.Location = new System.Drawing.Point(185, 348);
            this.lblNewClient.Name = "lblNewClient";
            this.lblNewClient.Size = new System.Drawing.Size(130, 25);
            this.lblNewClient.TabIndex = 0;
            this.lblNewClient.Text = "Nuovo cliente";
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
            this.bttnNewClient.Click += new System.EventHandler(this.bttnNewClient_Click);
            // 
            // lstVwMain
            // 
            this.lstVwMain.AccessibleDescription = "";
            this.lstVwMain.AccessibleName = "";
            this.lstVwMain.Activation = System.Windows.Forms.ItemActivation.OneClick;
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
            this.lstVwMain.ItemActivate += new System.EventHandler(this.lstVwMain_ItemActivate);
            // 
            // cHName
            // 
            this.cHName.Text = "Nome";
            this.cHName.Width = 65;
            // 
            // cHSurname
            // 
            this.cHSurname.Text = "Cognome";
            this.cHSurname.Width = 83;
            // 
            // cHWeight
            // 
            this.cHWeight.Text = "Peso";
            this.cHWeight.Width = 71;
            // 
            // cHHeight
            // 
            this.cHHeight.Text = "Altezza";
            this.cHHeight.Width = 62;
            // 
            // cHSex
            // 
            this.cHSex.Text = "Sesso";
            this.cHSex.Width = 58;
            // 
            // cHAge
            // 
            this.cHAge.Text = "Età";
            this.cHAge.Width = 51;
            // 
            // lblEditClient
            // 
            this.lblEditClient.AutoSize = true;
            this.lblEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClient.Location = new System.Drawing.Point(492, 348);
            this.lblEditClient.Name = "lblEditClient";
            this.lblEditClient.Size = new System.Drawing.Size(146, 25);
            this.lblEditClient.TabIndex = 6;
            this.lblEditClient.Text = "Modifica cliente";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(678, 348);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(75, 25);
            this.lblDelete.TabIndex = 7;
            this.lblDelete.Text = "Elimina";
            // 
            // lblClientPage
            // 
            this.lblClientPage.AutoSize = true;
            this.lblClientPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPage.Location = new System.Drawing.Point(14, 348);
            this.lblClientPage.Name = "lblClientPage";
            this.lblClientPage.Size = new System.Drawing.Size(165, 25);
            this.lblClientPage.TabIndex = 8;
            this.lblClientPage.Text = "Pagina del cliente";
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
            this.bttnClientPage.Click += new System.EventHandler(this.bttnClientPage_Click);
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
            this.lblAddWeight.Location = new System.Drawing.Point(338, 348);
            this.lblAddWeight.Name = "lblAddWeight";
            this.lblAddWeight.Size = new System.Drawing.Size(137, 25);
            this.lblAddWeight.TabIndex = 13;
            this.lblAddWeight.Text = "Aggiungi peso";
            // 
            // grpBoxClientList
            // 
            this.grpBoxClientList.Controls.Add(this.lstVwMain);
            this.grpBoxClientList.Location = new System.Drawing.Point(19, 12);
            this.grpBoxClientList.Name = "grpBoxClientList";
            this.grpBoxClientList.Size = new System.Drawing.Size(389, 322);
            this.grpBoxClientList.TabIndex = 23;
            this.grpBoxClientList.TabStop = false;
            this.grpBoxClientList.Text = "Lista Clienti";
            // 
            // grpBoxWeightChart
            // 
            this.grpBoxWeightChart.Controls.Add(this.chrtWeight);
            this.grpBoxWeightChart.Location = new System.Drawing.Point(414, 12);
            this.grpBoxWeightChart.Name = "grpBoxWeightChart";
            this.grpBoxWeightChart.Size = new System.Drawing.Size(379, 313);
            this.grpBoxWeightChart.TabIndex = 24;
            this.grpBoxWeightChart.TabStop = false;
            this.grpBoxWeightChart.Text = "Grafico del peso";
            // 
            // chrtWeight
            // 
            this.chrtWeight.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chrtWeight.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtWeight.Legends.Add(legend2);
            this.chrtWeight.Location = new System.Drawing.Point(6, 22);
            this.chrtWeight.Name = "chrtWeight";
            series2.BorderColor = System.Drawing.Color.White;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Kg";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chrtWeight.Series.Add(series2);
            this.chrtWeight.Size = new System.Drawing.Size(367, 285);
            this.chrtWeight.TabIndex = 0;
            this.chrtWeight.Text = "chart1";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxWeightChart);
            this.Controls.Add(this.grpBoxClientList);
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
            this.Text = "GESTORE CLIENTI";
            this.grpBoxClientList.ResumeLayout(false);
            this.grpBoxWeightChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtWeight)).EndInit();
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
        private System.Windows.Forms.GroupBox grpBoxClientList;
        private System.Windows.Forms.GroupBox grpBoxWeightChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtWeight;
    }
}

