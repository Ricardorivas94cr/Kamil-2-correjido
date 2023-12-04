namespace ProyectoKamil
{
    partial class Formulario_Directivos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtboxnumeroemp = new System.Windows.Forms.TextBox();
            this.txtboxciudad = new System.Windows.Forms.TextBox();
            this.txtboxcentros = new System.Windows.Forms.TextBox();
            this.txtboxnumero = new System.Windows.Forms.TextBox();
            this.lblnumeroemp = new System.Windows.Forms.Label();
            this.lblciudad = new System.Windows.Forms.Label();
            this.lblcentros = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.dtGRIDViewDirectivos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGRIDViewDirectivos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtboxnumeroemp);
            this.groupBox1.Controls.Add(this.txtboxciudad);
            this.groupBox1.Controls.Add(this.txtboxcentros);
            this.groupBox1.Controls.Add(this.txtboxnumero);
            this.groupBox1.Controls.Add(this.lblnumeroemp);
            this.groupBox1.Controls.Add(this.lblciudad);
            this.groupBox1.Controls.Add(this.lblcentros);
            this.groupBox1.Controls.Add(this.lblnumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo Directivos";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(616, 178);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(71, 23);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(528, 179);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(71, 23);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(442, 179);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(71, 23);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(442, 29);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(71, 23);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtboxnumeroemp
            // 
            this.txtboxnumeroemp.Location = new System.Drawing.Point(179, 178);
            this.txtboxnumeroemp.Name = "txtboxnumeroemp";
            this.txtboxnumeroemp.Size = new System.Drawing.Size(223, 20);
            this.txtboxnumeroemp.TabIndex = 7;
            // 
            // txtboxciudad
            // 
            this.txtboxciudad.Location = new System.Drawing.Point(179, 134);
            this.txtboxciudad.Name = "txtboxciudad";
            this.txtboxciudad.Size = new System.Drawing.Size(223, 20);
            this.txtboxciudad.TabIndex = 6;
            // 
            // txtboxcentros
            // 
            this.txtboxcentros.Location = new System.Drawing.Point(179, 85);
            this.txtboxcentros.Name = "txtboxcentros";
            this.txtboxcentros.Size = new System.Drawing.Size(223, 20);
            this.txtboxcentros.TabIndex = 5;
            // 
            // txtboxnumero
            // 
            this.txtboxnumero.Location = new System.Drawing.Point(179, 32);
            this.txtboxnumero.Name = "txtboxnumero";
            this.txtboxnumero.Size = new System.Drawing.Size(223, 20);
            this.txtboxnumero.TabIndex = 4;
            // 
            // lblnumeroemp
            // 
            this.lblnumeroemp.AutoSize = true;
            this.lblnumeroemp.BackColor = System.Drawing.Color.Yellow;
            this.lblnumeroemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroemp.Location = new System.Drawing.Point(6, 182);
            this.lblnumeroemp.Name = "lblnumeroemp";
            this.lblnumeroemp.Size = new System.Drawing.Size(162, 16);
            this.lblnumeroemp.TabIndex = 3;
            this.lblnumeroemp.Text = "Numero de Empleado:";
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.BackColor = System.Drawing.Color.Yellow;
            this.lblciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.Location = new System.Drawing.Point(6, 138);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(60, 16);
            this.lblciudad.TabIndex = 2;
            this.lblciudad.Text = "Ciudad:";
            // 
            // lblcentros
            // 
            this.lblcentros.AutoSize = true;
            this.lblcentros.BackColor = System.Drawing.Color.Yellow;
            this.lblcentros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcentros.Location = new System.Drawing.Point(6, 89);
            this.lblcentros.Name = "lblcentros";
            this.lblcentros.Size = new System.Drawing.Size(148, 16);
            this.lblcentros.TabIndex = 1;
            this.lblcentros.Text = "Centro Supervisado:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Yellow;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(6, 36);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(65, 16);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Numero:";
            // 
            // dtGRIDViewDirectivos
            // 
            this.dtGRIDViewDirectivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGRIDViewDirectivos.Location = new System.Drawing.Point(12, 245);
            this.dtGRIDViewDirectivos.Name = "dtGRIDViewDirectivos";
            this.dtGRIDViewDirectivos.Size = new System.Drawing.Size(776, 193);
            this.dtGRIDViewDirectivos.TabIndex = 1;
            // 
            // Formulario_Directivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGRIDViewDirectivos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulario_Directivos";
            this.Text = "Formulario_Directivos";
            this.Load += new System.EventHandler(this.Formulario_Directivos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGRIDViewDirectivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGRIDViewDirectivos;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtboxnumeroemp;
        private System.Windows.Forms.TextBox txtboxciudad;
        private System.Windows.Forms.TextBox txtboxcentros;
        private System.Windows.Forms.TextBox txtboxnumero;
        private System.Windows.Forms.Label lblnumeroemp;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Label lblcentros;
    }
}