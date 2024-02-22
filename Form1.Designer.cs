namespace ArchivosSecuenciales_Indexos_Directos_WF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SecuencialesFileManager1 = new System.Windows.Forms.TabPage();
            this.SecuencialesIndexadosFileManager1 = new System.Windows.Forms.TabPage();
            this.AccesoDirectoFileManager1 = new System.Windows.Forms.TabPage();
            this.btnSecuencialesInsert = new System.Windows.Forms.Button();
            this.btnSecuencialesSearch = new System.Windows.Forms.Button();
            this.txtSecuencialesData = new System.Windows.Forms.TextBox();
            this.txtSecuencialesSearch = new System.Windows.Forms.TextBox();
            this.btnSecuencialesIndexadosSearch = new System.Windows.Forms.Button();
            this.txtSecuencialesIndexadosSearch = new System.Windows.Forms.TextBox();
            this.btnAccesoDirectoSearch = new System.Windows.Forms.Button();
            this.btnAccesoDirectoInsert = new System.Windows.Forms.Button();
            this.btnAccesoDirectoDelete = new System.Windows.Forms.Button();
            this.txtAccesoDirectoPosition = new System.Windows.Forms.TextBox();
            this.txtAccesoDirectoData = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.SecuencialesFileManager1.SuspendLayout();
            this.SecuencialesIndexadosFileManager1.SuspendLayout();
            this.AccesoDirectoFileManager1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SecuencialesFileManager1);
            this.tabControl1.Controls.Add(this.SecuencialesIndexadosFileManager1);
            this.tabControl1.Controls.Add(this.AccesoDirectoFileManager1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // SecuencialesFileManager1
            // 
            this.SecuencialesFileManager1.AccessibleName = "SecuencialesFileManager";
            this.SecuencialesFileManager1.Controls.Add(this.txtSecuencialesSearch);
            this.SecuencialesFileManager1.Controls.Add(this.txtSecuencialesData);
            this.SecuencialesFileManager1.Controls.Add(this.btnSecuencialesSearch);
            this.SecuencialesFileManager1.Controls.Add(this.btnSecuencialesInsert);
            this.SecuencialesFileManager1.Location = new System.Drawing.Point(4, 22);
            this.SecuencialesFileManager1.Name = "SecuencialesFileManager1";
            this.SecuencialesFileManager1.Padding = new System.Windows.Forms.Padding(3);
            this.SecuencialesFileManager1.Size = new System.Drawing.Size(768, 400);
            this.SecuencialesFileManager1.TabIndex = 0;
            this.SecuencialesFileManager1.Text = "SecuencialesFileManager";
            this.SecuencialesFileManager1.UseVisualStyleBackColor = true;
            // 
            // SecuencialesIndexadosFileManager1
            // 
            this.SecuencialesIndexadosFileManager1.AccessibleName = "SecuencialesIndexadosFileManager";
            this.SecuencialesIndexadosFileManager1.Controls.Add(this.txtSecuencialesIndexadosSearch);
            this.SecuencialesIndexadosFileManager1.Controls.Add(this.btnSecuencialesIndexadosSearch);
            this.SecuencialesIndexadosFileManager1.Location = new System.Drawing.Point(4, 22);
            this.SecuencialesIndexadosFileManager1.Name = "SecuencialesIndexadosFileManager1";
            this.SecuencialesIndexadosFileManager1.Padding = new System.Windows.Forms.Padding(3);
            this.SecuencialesIndexadosFileManager1.Size = new System.Drawing.Size(768, 400);
            this.SecuencialesIndexadosFileManager1.TabIndex = 1;
            this.SecuencialesIndexadosFileManager1.Text = "SecuencialesIndexadosFileManager";
            this.SecuencialesIndexadosFileManager1.UseVisualStyleBackColor = true;
            // 
            // AccesoDirectoFileManager1
            // 
            this.AccesoDirectoFileManager1.AccessibleName = "AccesoDirectoFileManager";
            this.AccesoDirectoFileManager1.Controls.Add(this.txtAccesoDirectoData);
            this.AccesoDirectoFileManager1.Controls.Add(this.txtAccesoDirectoPosition);
            this.AccesoDirectoFileManager1.Controls.Add(this.btnAccesoDirectoDelete);
            this.AccesoDirectoFileManager1.Controls.Add(this.btnAccesoDirectoInsert);
            this.AccesoDirectoFileManager1.Controls.Add(this.btnAccesoDirectoSearch);
            this.AccesoDirectoFileManager1.Location = new System.Drawing.Point(4, 22);
            this.AccesoDirectoFileManager1.Name = "AccesoDirectoFileManager1";
            this.AccesoDirectoFileManager1.Padding = new System.Windows.Forms.Padding(3);
            this.AccesoDirectoFileManager1.Size = new System.Drawing.Size(768, 400);
            this.AccesoDirectoFileManager1.TabIndex = 2;
            this.AccesoDirectoFileManager1.Text = "AccesoDirectoFileManager";
            this.AccesoDirectoFileManager1.UseVisualStyleBackColor = true;
            // 
            // btnSecuencialesInsert
            // 
            this.btnSecuencialesInsert.Location = new System.Drawing.Point(481, 32);
            this.btnSecuencialesInsert.Name = "btnSecuencialesInsert";
            this.btnSecuencialesInsert.Size = new System.Drawing.Size(150, 81);
            this.btnSecuencialesInsert.TabIndex = 0;
            this.btnSecuencialesInsert.Text = "Insertar Secuencial";
            this.btnSecuencialesInsert.UseVisualStyleBackColor = true;
            this.btnSecuencialesInsert.Click += new System.EventHandler(this.btnSecuencialesInsert_Click_1);
            // 
            // btnSecuencialesSearch
            // 
            this.btnSecuencialesSearch.Location = new System.Drawing.Point(481, 186);
            this.btnSecuencialesSearch.Name = "btnSecuencialesSearch";
            this.btnSecuencialesSearch.Size = new System.Drawing.Size(150, 88);
            this.btnSecuencialesSearch.TabIndex = 1;
            this.btnSecuencialesSearch.Text = "Buscar Secuencial";
            this.btnSecuencialesSearch.UseVisualStyleBackColor = true;
            this.btnSecuencialesSearch.Click += new System.EventHandler(this.btnSecuencialesSearch_Click_1);
            // 
            // txtSecuencialesData
            // 
            this.txtSecuencialesData.Location = new System.Drawing.Point(102, 63);
            this.txtSecuencialesData.Name = "txtSecuencialesData";
            this.txtSecuencialesData.Size = new System.Drawing.Size(305, 20);
            this.txtSecuencialesData.TabIndex = 2;
            // 
            // txtSecuencialesSearch
            // 
            this.txtSecuencialesSearch.Location = new System.Drawing.Point(102, 221);
            this.txtSecuencialesSearch.Name = "txtSecuencialesSearch";
            this.txtSecuencialesSearch.Size = new System.Drawing.Size(305, 20);
            this.txtSecuencialesSearch.TabIndex = 3;
            // 
            // btnSecuencialesIndexadosSearch
            // 
            this.btnSecuencialesIndexadosSearch.Location = new System.Drawing.Point(413, 128);
            this.btnSecuencialesIndexadosSearch.Name = "btnSecuencialesIndexadosSearch";
            this.btnSecuencialesIndexadosSearch.Size = new System.Drawing.Size(132, 83);
            this.btnSecuencialesIndexadosSearch.TabIndex = 0;
            this.btnSecuencialesIndexadosSearch.Text = "Buscar Secuencial Indexado";
            this.btnSecuencialesIndexadosSearch.UseVisualStyleBackColor = true;
            this.btnSecuencialesIndexadosSearch.Click += new System.EventHandler(this.btnSecuencialesIndexadosSearch_Click_1);
            // 
            // txtSecuencialesIndexadosSearch
            // 
            this.txtSecuencialesIndexadosSearch.Location = new System.Drawing.Point(94, 160);
            this.txtSecuencialesIndexadosSearch.Name = "txtSecuencialesIndexadosSearch";
            this.txtSecuencialesIndexadosSearch.Size = new System.Drawing.Size(291, 20);
            this.txtSecuencialesIndexadosSearch.TabIndex = 1;
            // 
            // btnAccesoDirectoSearch
            // 
            this.btnAccesoDirectoSearch.Location = new System.Drawing.Point(509, 31);
            this.btnAccesoDirectoSearch.Name = "btnAccesoDirectoSearch";
            this.btnAccesoDirectoSearch.Size = new System.Drawing.Size(147, 74);
            this.btnAccesoDirectoSearch.TabIndex = 0;
            this.btnAccesoDirectoSearch.Text = "Buscar Acceso Directo";
            this.btnAccesoDirectoSearch.UseVisualStyleBackColor = true;
            this.btnAccesoDirectoSearch.Click += new System.EventHandler(this.btnAccesoDirectoSearch_Click_1);
            // 
            // btnAccesoDirectoInsert
            // 
            this.btnAccesoDirectoInsert.Location = new System.Drawing.Point(509, 225);
            this.btnAccesoDirectoInsert.Name = "btnAccesoDirectoInsert";
            this.btnAccesoDirectoInsert.Size = new System.Drawing.Size(147, 74);
            this.btnAccesoDirectoInsert.TabIndex = 1;
            this.btnAccesoDirectoInsert.Text = "Insertar Acceso Directo";
            this.btnAccesoDirectoInsert.UseVisualStyleBackColor = true;
            this.btnAccesoDirectoInsert.Click += new System.EventHandler(this.btnAccesoDirectoInsert_Click_1);
            // 
            // btnAccesoDirectoDelete
            // 
            this.btnAccesoDirectoDelete.Location = new System.Drawing.Point(509, 129);
            this.btnAccesoDirectoDelete.Name = "btnAccesoDirectoDelete";
            this.btnAccesoDirectoDelete.Size = new System.Drawing.Size(147, 74);
            this.btnAccesoDirectoDelete.TabIndex = 2;
            this.btnAccesoDirectoDelete.Text = "Borrar Acceso Directo";
            this.btnAccesoDirectoDelete.UseVisualStyleBackColor = true;
            this.btnAccesoDirectoDelete.Click += new System.EventHandler(this.btnAccesoDirectoDelete_Click_1);
            // 
            // txtAccesoDirectoPosition
            // 
            this.txtAccesoDirectoPosition.Location = new System.Drawing.Point(95, 108);
            this.txtAccesoDirectoPosition.Name = "txtAccesoDirectoPosition";
            this.txtAccesoDirectoPosition.Size = new System.Drawing.Size(379, 20);
            this.txtAccesoDirectoPosition.TabIndex = 3;
            // 
            // txtAccesoDirectoData
            // 
            this.txtAccesoDirectoData.Location = new System.Drawing.Point(95, 253);
            this.txtAccesoDirectoData.Name = "txtAccesoDirectoData";
            this.txtAccesoDirectoData.Size = new System.Drawing.Size(379, 20);
            this.txtAccesoDirectoData.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.SecuencialesFileManager1.ResumeLayout(false);
            this.SecuencialesFileManager1.PerformLayout();
            this.SecuencialesIndexadosFileManager1.ResumeLayout(false);
            this.SecuencialesIndexadosFileManager1.PerformLayout();
            this.AccesoDirectoFileManager1.ResumeLayout(false);
            this.AccesoDirectoFileManager1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SecuencialesFileManager1;
        private System.Windows.Forms.TabPage SecuencialesIndexadosFileManager1;
        private System.Windows.Forms.TabPage AccesoDirectoFileManager1;
        private System.Windows.Forms.Button btnSecuencialesSearch;
        private System.Windows.Forms.Button btnSecuencialesInsert;
        private System.Windows.Forms.TextBox txtSecuencialesSearch;
        private System.Windows.Forms.TextBox txtSecuencialesData;
        private System.Windows.Forms.Button btnSecuencialesIndexadosSearch;
        private System.Windows.Forms.TextBox txtSecuencialesIndexadosSearch;
        private System.Windows.Forms.Button btnAccesoDirectoDelete;
        private System.Windows.Forms.Button btnAccesoDirectoInsert;
        private System.Windows.Forms.Button btnAccesoDirectoSearch;
        private System.Windows.Forms.TextBox txtAccesoDirectoPosition;
        private System.Windows.Forms.TextBox txtAccesoDirectoData;
    }
}

