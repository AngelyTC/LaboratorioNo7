
namespace LaboratorioNo7
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
            this.dgtPropietario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrdenarCuota = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCuotas3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPropAlto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtPropietario
            // 
            this.dgtPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtPropietario.Location = new System.Drawing.Point(23, 71);
            this.dgtPropietario.Name = "dgtPropietario";
            this.dgtPropietario.RowHeadersWidth = 62;
            this.dgtPropietario.RowTemplate.Height = 28;
            this.dgtPropietario.Size = new System.Drawing.Size(675, 455);
            this.dgtPropietario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(169, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Propietarios            ---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(422, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Propiedades";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(260, 580);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(153, 68);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver propiedad de propietario";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cargar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrdenarCuota
            // 
            this.btnOrdenarCuota.Location = new System.Drawing.Point(427, 580);
            this.btnOrdenarCuota.Name = "btnOrdenarCuota";
            this.btnOrdenarCuota.Size = new System.Drawing.Size(138, 68);
            this.btnOrdenarCuota.TabIndex = 6;
            this.btnOrdenarCuota.Text = "Ordenar por cuota";
            this.btnOrdenarCuota.UseVisualStyleBackColor = true;
            this.btnOrdenarCuota.Click += new System.EventHandler(this.btnOrdenarCuota_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(777, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "3 Cuotas mas altas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "_______________________________________ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(776, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "3 Cuotas mas bajas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(778, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "___________________________________________________";
            // 
            // btnCuotas3
            // 
            this.btnCuotas3.Location = new System.Drawing.Point(781, 240);
            this.btnCuotas3.Name = "btnCuotas3";
            this.btnCuotas3.Size = new System.Drawing.Size(160, 70);
            this.btnCuotas3.TabIndex = 11;
            this.btnCuotas3.Text = "Ver";
            this.btnCuotas3.UseVisualStyleBackColor = true;
            this.btnCuotas3.Click += new System.EventHandler(this.btnCuotas3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(776, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Propietario de cuota mas alta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "_______________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(778, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "____________";
            // 
            // btnPropAlto
            // 
            this.btnPropAlto.Location = new System.Drawing.Point(786, 517);
            this.btnPropAlto.Name = "btnPropAlto";
            this.btnPropAlto.Size = new System.Drawing.Size(136, 56);
            this.btnPropAlto.TabIndex = 15;
            this.btnPropAlto.Text = "Ver";
            this.btnPropAlto.UseVisualStyleBackColor = true;
            this.btnPropAlto.Click += new System.EventHandler(this.btnPropAlto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1401, 772);
            this.Controls.Add(this.btnPropAlto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCuotas3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrdenarCuota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtPropietario);
            this.Name = "Form1";
            this.Text = "Propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.dgtPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtPropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOrdenarCuota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCuotas3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPropAlto;
    }
}

