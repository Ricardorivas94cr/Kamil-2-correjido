namespace ProyectoKamil
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregaremp = new System.Windows.Forms.Button();
            this.btnveremp = new System.Windows.Forms.Button();
            this.btnagregardirectivos = new System.Windows.Forms.Button();
            this.btnverdirectivos = new System.Windows.Forms.Button();
            this.btnagregarcentros = new System.Windows.Forms.Button();
            this.btnvercentros = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto Kamil";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.btnveremp);
            this.groupBox1.Controls.Add(this.btnagregaremp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Blue;
            this.groupBox2.Controls.Add(this.btnverdirectivos);
            this.groupBox2.Controls.Add(this.btnagregardirectivos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(311, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 334);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directivo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Blue;
            this.groupBox3.Controls.Add(this.btnvercentros);
            this.groupBox3.Controls.Add(this.btnagregarcentros);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(581, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 334);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Centros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Directivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Centros";
            // 
            // btnagregaremp
            // 
            this.btnagregaremp.BackColor = System.Drawing.Color.Yellow;
            this.btnagregaremp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregaremp.Location = new System.Drawing.Point(46, 73);
            this.btnagregaremp.Name = "btnagregaremp";
            this.btnagregaremp.Size = new System.Drawing.Size(100, 62);
            this.btnagregaremp.TabIndex = 2;
            this.btnagregaremp.Text = "Agregar Empleados";
            this.btnagregaremp.UseVisualStyleBackColor = false;
            this.btnagregaremp.Click += new System.EventHandler(this.btnagregaremp_Click);
            // 
            // btnveremp
            // 
            this.btnveremp.BackColor = System.Drawing.Color.Yellow;
            this.btnveremp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveremp.Location = new System.Drawing.Point(46, 188);
            this.btnveremp.Name = "btnveremp";
            this.btnveremp.Size = new System.Drawing.Size(100, 62);
            this.btnveremp.TabIndex = 3;
            this.btnveremp.Text = "Ver Empleados";
            this.btnveremp.UseVisualStyleBackColor = false;
            // 
            // btnagregardirectivos
            // 
            this.btnagregardirectivos.BackColor = System.Drawing.Color.Yellow;
            this.btnagregardirectivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregardirectivos.Location = new System.Drawing.Point(56, 73);
            this.btnagregardirectivos.Name = "btnagregardirectivos";
            this.btnagregardirectivos.Size = new System.Drawing.Size(100, 62);
            this.btnagregardirectivos.TabIndex = 4;
            this.btnagregardirectivos.Text = "Agregar Directivos";
            this.btnagregardirectivos.UseVisualStyleBackColor = false;
            this.btnagregardirectivos.Click += new System.EventHandler(this.btnagregardirectivos_Click);
            // 
            // btnverdirectivos
            // 
            this.btnverdirectivos.BackColor = System.Drawing.Color.Yellow;
            this.btnverdirectivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverdirectivos.Location = new System.Drawing.Point(56, 188);
            this.btnverdirectivos.Name = "btnverdirectivos";
            this.btnverdirectivos.Size = new System.Drawing.Size(100, 62);
            this.btnverdirectivos.TabIndex = 5;
            this.btnverdirectivos.Text = "Ver Directivos";
            this.btnverdirectivos.UseVisualStyleBackColor = false;
            // 
            // btnagregarcentros
            // 
            this.btnagregarcentros.BackColor = System.Drawing.Color.Yellow;
            this.btnagregarcentros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarcentros.Location = new System.Drawing.Point(48, 73);
            this.btnagregarcentros.Name = "btnagregarcentros";
            this.btnagregarcentros.Size = new System.Drawing.Size(100, 62);
            this.btnagregarcentros.TabIndex = 6;
            this.btnagregarcentros.Text = "Agregar Centros";
            this.btnagregarcentros.UseVisualStyleBackColor = false;
            this.btnagregarcentros.Click += new System.EventHandler(this.btnagregarcentros_Click);
            // 
            // btnvercentros
            // 
            this.btnvercentros.BackColor = System.Drawing.Color.Yellow;
            this.btnvercentros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvercentros.Location = new System.Drawing.Point(48, 188);
            this.btnvercentros.Name = "btnvercentros";
            this.btnvercentros.Size = new System.Drawing.Size(100, 62);
            this.btnvercentros.TabIndex = 7;
            this.btnvercentros.Text = "Ver Centros";
            this.btnvercentros.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnagregaremp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnveremp;
        private System.Windows.Forms.Button btnverdirectivos;
        private System.Windows.Forms.Button btnagregardirectivos;
        private System.Windows.Forms.Button btnvercentros;
        private System.Windows.Forms.Button btnagregarcentros;
    }
}

