namespace QUEUE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grElEliminado = new System.Windows.Forms.GroupBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrListDgv = new System.Windows.Forms.GroupBox();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.DgvCola = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PctImagen = new System.Windows.Forms.PictureBox();
            this.grNuevoElemento.SuspendLayout();
            this.grElEliminado.SuspendLayout();
            this.GrListDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grNuevoElemento
            // 
            this.grNuevoElemento.Controls.Add(this.btnInsert);
            this.grNuevoElemento.Controls.Add(this.txtProcess);
            this.grNuevoElemento.Controls.Add(this.txtName);
            this.grNuevoElemento.Controls.Add(this.txtCode);
            this.grNuevoElemento.Controls.Add(this.label3);
            this.grNuevoElemento.Controls.Add(this.label2);
            this.grNuevoElemento.Controls.Add(this.label1);
            this.grNuevoElemento.Location = new System.Drawing.Point(375, 12);
            this.grNuevoElemento.Name = "grNuevoElemento";
            this.grNuevoElemento.Size = new System.Drawing.Size(220, 325);
            this.grNuevoElemento.TabIndex = 4;
            this.grNuevoElemento.TabStop = false;
            this.grNuevoElemento.Text = "new element";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(20, 207);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(170, 41);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(90, 143);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(100, 20);
            this.txtProcess.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(90, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "code";
            // 
            // grElEliminado
            // 
            this.grElEliminado.Controls.Add(this.lblProcess);
            this.grElEliminado.Controls.Add(this.lblName);
            this.grElEliminado.Controls.Add(this.lblCode);
            this.grElEliminado.Controls.Add(this.btnDelete);
            this.grElEliminado.Controls.Add(this.label6);
            this.grElEliminado.Controls.Add(this.label5);
            this.grElEliminado.Controls.Add(this.label4);
            this.grElEliminado.Location = new System.Drawing.Point(601, 12);
            this.grElEliminado.Name = "grElEliminado";
            this.grElEliminado.Size = new System.Drawing.Size(361, 325);
            this.grElEliminado.TabIndex = 5;
            this.grElEliminado.TabStop = false;
            this.grElEliminado.Text = "delete element";
            // 
            // lblProcess
            // 
            this.lblProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(199, 153);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(69, 29);
            this.lblProcess.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(199, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 33);
            this.lblName.TabIndex = 10;
            // 
            // lblCode
            // 
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(199, 37);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(69, 25);
            this.lblCode.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(42, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "code";
            // 
            // GrListDgv
            // 
            this.GrListDgv.Controls.Add(this.lstQueue);
            this.GrListDgv.Controls.Add(this.DgvCola);
            this.GrListDgv.Location = new System.Drawing.Point(12, 343);
            this.GrListDgv.Name = "GrListDgv";
            this.GrListDgv.Size = new System.Drawing.Size(960, 182);
            this.GrListDgv.TabIndex = 6;
            this.GrListDgv.TabStop = false;
            this.GrListDgv.Text = "LIST";
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.Location = new System.Drawing.Point(20, 19);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(324, 147);
            this.lstQueue.TabIndex = 2;
            // 
            // DgvCola
            // 
            this.DgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.Column1,
            this.Column2});
            this.DgvCola.Location = new System.Drawing.Point(357, 19);
            this.DgvCola.Name = "DgvCola";
            this.DgvCola.RowHeadersWidth = 51;
            this.DgvCola.Size = new System.Drawing.Size(587, 150);
            this.DgvCola.TabIndex = 1;
            // 
            // c1
            // 
            this.c1.HeaderText = "Codigo";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.Width = 145;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "tramite";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // PctImagen
            // 
            this.PctImagen.Image = ((System.Drawing.Image)(resources.GetObject("PctImagen.Image")));
            this.PctImagen.Location = new System.Drawing.Point(12, 12);
            this.PctImagen.Name = "PctImagen";
            this.PctImagen.Size = new System.Drawing.Size(344, 325);
            this.PctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctImagen.TabIndex = 7;
            this.PctImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 537);
            this.Controls.Add(this.PctImagen);
            this.Controls.Add(this.GrListDgv);
            this.Controls.Add(this.grElEliminado);
            this.Controls.Add(this.grNuevoElemento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grNuevoElemento.ResumeLayout(false);
            this.grNuevoElemento.PerformLayout();
            this.grElEliminado.ResumeLayout(false);
            this.grElEliminado.PerformLayout();
            this.GrListDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grNuevoElemento;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grElEliminado;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrListDgv;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.DataGridView DgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox PctImagen;
    }
}

