using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace timerMinutesPrueba
{
    partial class StopwatchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopwatchForm));
            this.dataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.miliseconds = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tiemposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stopwatchDataSet1 = new stopwatch1.stopwatchDataSet1();
            this.Save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.stopwatchDataSet = new stopwatch1.stopwatchDataSet();
            this.tiemposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiemposTableAdapter = new stopwatch1.stopwatchDataSetTableAdapters.tiemposTableAdapter();
            this.tiemposTableAdapter1 = new stopwatch1.stopwatchDataSet1TableAdapters.tiemposTableAdapter();
            this.idtiempos = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
            this.timeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtiemposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
=======
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtiemposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopwatchDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopwatchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposBindingSource)).BeginInit();
<<<<<<< HEAD
            this.panel1.SuspendLayout();
=======
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn
            // 
            this.dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
<<<<<<< HEAD
            this.start.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(43, 81);
=======
            this.start.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(41, 92);
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(105, 31);
            this.start.TabIndex = 0;
            this.start.TabStop = false;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
<<<<<<< HEAD
            this.stop.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(178, 81);
=======
            this.stop.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(176, 92);
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(105, 31);
            this.stop.TabIndex = 0;
            this.stop.TabStop = false;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // miliseconds
            // 
            this.miliseconds.Interval = 1;
            this.miliseconds.Tick += new System.EventHandler(this.miliseconds_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(116, 16);
=======
            this.label5.Location = new System.Drawing.Point(122, 19);
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 55);
            this.label5.TabIndex = 6;
            this.label5.Text = "00:00:00.0";
            // 
            // restart
            // 
<<<<<<< HEAD
            this.restart.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(307, 81);
=======
            this.restart.Font = new System.Drawing.Font("Calibri", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(305, 92);
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(105, 31);
            this.restart.TabIndex = 0;
            this.restart.TabStop = false;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtiempos,
<<<<<<< HEAD
            this.timeName,
            this.Time,
=======
            this.NameColumn,
            this.TimeColumn,
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.idtiemposDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tiempoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tiemposBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(83)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
            this.dataGridView1.Size = new System.Drawing.Size(452, 615);
=======
            this.dataGridView1.Size = new System.Drawing.Size(369, 153);
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ControlError);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // tiemposBindingSource1
            // 
            this.tiemposBindingSource1.DataMember = "tiempos";
            this.tiemposBindingSource1.DataSource = this.stopwatchDataSet1;
            // 
            // stopwatchDataSet1
            // 
            this.stopwatchDataSet1.DataSetName = "stopwatchDataSet1";
            this.stopwatchDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(41, 146);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(122, 146);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // stopwatchDataSet
            // 
            this.stopwatchDataSet.DataSetName = "stopwatchDataSet";
            this.stopwatchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiemposBindingSource
            // 
            this.tiemposBindingSource.DataMember = "tiempos";
            this.tiemposBindingSource.DataSource = this.stopwatchDataSet;
            // 
            // tiemposTableAdapter
            // 
            this.tiemposTableAdapter.ClearBeforeFill = true;
            // 
            // tiemposTableAdapter1
            // 
            this.tiemposTableAdapter1.ClearBeforeFill = true;
            // 
            // idtiempos
            // 
            this.idtiempos.DataPropertyName = "idtiempos";
            this.idtiempos.HeaderText = "idtiempos";
            this.idtiempos.Name = "idtiempos";
            this.idtiempos.Visible = false;
            // 
<<<<<<< HEAD
            // timeName
            // 
            this.timeName.DataPropertyName = "nombre";
            this.timeName.HeaderText = "Name";
            this.timeName.Name = "timeName";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "tiempo";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
=======
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "nombre";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // TimeColumn
            // 
            this.TimeColumn.DataPropertyName = "tiempo";
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.
                //c# datagridview column allow nulls <---Buscar por esto
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            // 
            // idtiemposDataGridViewTextBoxColumn
            // 
            this.idtiemposDataGridViewTextBoxColumn.DataPropertyName = "idtiempos";
            this.idtiemposDataGridViewTextBoxColumn.HeaderText = "idtiempos";
            this.idtiemposDataGridViewTextBoxColumn.Name = "idtiemposDataGridViewTextBoxColumn";
            this.idtiemposDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiempoDataGridViewTextBoxColumn
            // 
            this.tiempoDataGridViewTextBoxColumn.DataPropertyName = "tiempo";
            this.tiempoDataGridViewTextBoxColumn.HeaderText = "tiempo";
            this.tiempoDataGridViewTextBoxColumn.Name = "tiempoDataGridViewTextBoxColumn";
            this.tiempoDataGridViewTextBoxColumn.Visible = false;
            // 
<<<<<<< HEAD
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.restart);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 136);
            this.panel1.TabIndex = 13;
            // 
=======
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            // StopwatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(484, 400);
            this.Controls.Add(this.panel1);
=======
            this.ClientSize = new System.Drawing.Size(474, 340);
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
<<<<<<< HEAD
            this.MinimumSize = new System.Drawing.Size(500, 439);
            this.Name = "StopwatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
=======
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 490);
            this.MinimumSize = new System.Drawing.Size(490, 39);
            this.Name = "StopwatchForm";
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_keypress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopwatchDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopwatchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemposBindingSource)).EndInit();
<<<<<<< HEAD
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
=======
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
            this.ResumeLayout(false);

        }

        #endregion
        private Stopwatch stopwatch;
        private System.Windows.Forms.Label label5;private System.Windows.Forms.Timer miliseconds; private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button restart;
        private stopwatch1.stopwatchDataSet stopwatchDataSet;
        private BindingSource tiemposBindingSource;
        private stopwatch1.stopwatchDataSetTableAdapters.tiemposTableAdapter tiemposTableAdapter;
        private stopwatch1.stopwatchDataSet1 stopwatchDataSet1;
        private BindingSource tiemposBindingSource1;
        private stopwatch1.stopwatchDataSet1TableAdapters.tiemposTableAdapter tiemposTableAdapter1;
        private DataGridView dataGridView1;
        private Button Save;
        private Button delete;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idtiempos;
<<<<<<< HEAD
        private DataGridViewTextBoxColumn timeName;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn idtiemposDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn;
        private Panel panel1;
=======
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn idtiemposDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn;
>>>>>>> b2269c3a44629d992e7cf087266d4cabf7b5f584
    }
}

