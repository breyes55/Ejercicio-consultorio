namespace ConsultorioRAD
{
    partial class VCitas
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
            this.components = new System.ComponentModel.Container();
            this.cbxpacienteid = new System.Windows.Forms.ComboBox();
            this.cbxMedicoId = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgcitas = new System.Windows.Forms.DataGridView();
            this.txtCitaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechacita = new System.Windows.Forms.DateTimePicker();
            this.errorcitas = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgcitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcitas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxpacienteid
            // 
            this.cbxpacienteid.FormattingEnabled = true;
            this.cbxpacienteid.Location = new System.Drawing.Point(191, 206);
            this.cbxpacienteid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxpacienteid.Name = "cbxpacienteid";
            this.cbxpacienteid.Size = new System.Drawing.Size(270, 28);
            this.cbxpacienteid.TabIndex = 51;
            // 
            // cbxMedicoId
            // 
            this.cbxMedicoId.FormattingEnabled = true;
            this.cbxMedicoId.Location = new System.Drawing.Point(188, 163);
            this.cbxMedicoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMedicoId.Name = "cbxMedicoId";
            this.cbxMedicoId.Size = new System.Drawing.Size(270, 28);
            this.cbxMedicoId.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(572, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 22);
            this.label10.TabIndex = 48;
            this.label10.Text = "PacienteId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "MedicoId";
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivos.Location = new System.Drawing.Point(35, 394);
            this.cbActivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(215, 26);
            this.cbActivos.TabIndex = 44;
            this.cbActivos.Text = "Mostrar solo activas";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(682, 362);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 40);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(482, 362);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 40);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgcitas
            // 
            this.dgcitas.AllowUserToAddRows = false;
            this.dgcitas.AllowUserToDeleteRows = false;
            this.dgcitas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgcitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcitas.Location = new System.Drawing.Point(35, 429);
            this.dgcitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgcitas.Name = "dgcitas";
            this.dgcitas.ReadOnly = true;
            this.dgcitas.RowHeadersWidth = 62;
            this.dgcitas.RowTemplate.Height = 28;
            this.dgcitas.Size = new System.Drawing.Size(1176, 339);
            this.dgcitas.TabIndex = 41;
            this.dgcitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcitas_CellDoubleClick);
            // 
            // txtCitaId
            // 
            this.txtCitaId.Location = new System.Drawing.Point(174, 111);
            this.txtCitaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCitaId.Name = "txtCitaId";
            this.txtCitaId.ReadOnly = true;
            this.txtCitaId.Size = new System.Drawing.Size(100, 26);
            this.txtCitaId.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Apartado de Citas";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.Location = new System.Drawing.Point(322, 111);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(91, 26);
            this.cbEstado.TabIndex = 36;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fecha de la Cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "CitaId";
            // 
            // dtpFechacita
            // 
            this.dtpFechacita.Location = new System.Drawing.Point(276, 268);
            this.dtpFechacita.Name = "dtpFechacita";
            this.dtpFechacita.Size = new System.Drawing.Size(296, 26);
            this.dtpFechacita.TabIndex = 52;
            // 
            // errorcitas
            // 
            this.errorcitas.ContainerControl = this;
            // 
            // VCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 812);
            this.Controls.Add(this.dtpFechacita);
            this.Controls.Add(this.cbxpacienteid);
            this.Controls.Add(this.cbxMedicoId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgcitas);
            this.Controls.Add(this.txtCitaId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VCitas";
            this.Load += new System.EventHandler(this.VCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxpacienteid;
        private System.Windows.Forms.ComboBox cbxMedicoId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgcitas;
        private System.Windows.Forms.TextBox txtCitaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechacita;
        private System.Windows.Forms.ErrorProvider errorcitas;
    }
}