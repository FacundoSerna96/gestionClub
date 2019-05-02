namespace gestionClub
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gestion_Clubes_DataBaseDataSet = new gestionClub.Gestion_Clubes_DataBaseDataSet();
            this.gestionClubesDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_Clubes_DataBaseDataSet1 = new gestionClub.Gestion_Clubes_DataBaseDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new gestionClub.Gestion_Clubes_DataBaseDataSet1TableAdapters.clienteTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numLibretaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutor2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_Clubes_DataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionClubesDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_Clubes_DataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.numLibretaDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.tutor1DataGridViewTextBoxColumn,
            this.tutor2DataGridViewTextBoxColumn,
            this.diciplinaDataGridViewTextBoxColumn,
            this.tel1DataGridViewTextBoxColumn,
            this.tel2DataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.campo1DataGridViewTextBoxColumn,
            this.campo2DataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // gestion_Clubes_DataBaseDataSet
            // 
            this.gestion_Clubes_DataBaseDataSet.DataSetName = "Gestion_Clubes_DataBaseDataSet";
            this.gestion_Clubes_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionClubesDataBaseDataSetBindingSource
            // 
            this.gestionClubesDataBaseDataSetBindingSource.DataSource = this.gestion_Clubes_DataBaseDataSet;
            this.gestionClubesDataBaseDataSetBindingSource.Position = 0;
            // 
            // gestion_Clubes_DataBaseDataSet1
            // 
            this.gestion_Clubes_DataBaseDataSet1.DataSetName = "Gestion_Clubes_DataBaseDataSet1";
            this.gestion_Clubes_DataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.gestion_Clubes_DataBaseDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // numLibretaDataGridViewTextBoxColumn
            // 
            this.numLibretaDataGridViewTextBoxColumn.DataPropertyName = "numLibreta";
            this.numLibretaDataGridViewTextBoxColumn.HeaderText = "numLibreta";
            this.numLibretaDataGridViewTextBoxColumn.Name = "numLibretaDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // tutor1DataGridViewTextBoxColumn
            // 
            this.tutor1DataGridViewTextBoxColumn.DataPropertyName = "tutor1";
            this.tutor1DataGridViewTextBoxColumn.HeaderText = "tutor1";
            this.tutor1DataGridViewTextBoxColumn.Name = "tutor1DataGridViewTextBoxColumn";
            // 
            // tutor2DataGridViewTextBoxColumn
            // 
            this.tutor2DataGridViewTextBoxColumn.DataPropertyName = "tutor2";
            this.tutor2DataGridViewTextBoxColumn.HeaderText = "tutor2";
            this.tutor2DataGridViewTextBoxColumn.Name = "tutor2DataGridViewTextBoxColumn";
            // 
            // diciplinaDataGridViewTextBoxColumn
            // 
            this.diciplinaDataGridViewTextBoxColumn.DataPropertyName = "diciplina";
            this.diciplinaDataGridViewTextBoxColumn.HeaderText = "diciplina";
            this.diciplinaDataGridViewTextBoxColumn.Name = "diciplinaDataGridViewTextBoxColumn";
            // 
            // tel1DataGridViewTextBoxColumn
            // 
            this.tel1DataGridViewTextBoxColumn.DataPropertyName = "tel1";
            this.tel1DataGridViewTextBoxColumn.HeaderText = "tel1";
            this.tel1DataGridViewTextBoxColumn.Name = "tel1DataGridViewTextBoxColumn";
            // 
            // tel2DataGridViewTextBoxColumn
            // 
            this.tel2DataGridViewTextBoxColumn.DataPropertyName = "tel2";
            this.tel2DataGridViewTextBoxColumn.HeaderText = "tel2";
            this.tel2DataGridViewTextBoxColumn.Name = "tel2DataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // campo1DataGridViewTextBoxColumn
            // 
            this.campo1DataGridViewTextBoxColumn.DataPropertyName = "Campo1";
            this.campo1DataGridViewTextBoxColumn.HeaderText = "Campo1";
            this.campo1DataGridViewTextBoxColumn.Name = "campo1DataGridViewTextBoxColumn";
            // 
            // campo2DataGridViewTextBoxColumn
            // 
            this.campo2DataGridViewTextBoxColumn.DataPropertyName = "Campo2";
            this.campo2DataGridViewTextBoxColumn.HeaderText = "Campo2";
            this.campo2DataGridViewTextBoxColumn.Name = "campo2DataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_Clubes_DataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionClubesDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_Clubes_DataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gestionClubesDataBaseDataSetBindingSource;
        private Gestion_Clubes_DataBaseDataSet gestion_Clubes_DataBaseDataSet;
        private Gestion_Clubes_DataBaseDataSet1 gestion_Clubes_DataBaseDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Gestion_Clubes_DataBaseDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLibretaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
    }
}

