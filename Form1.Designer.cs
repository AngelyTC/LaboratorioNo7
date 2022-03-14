
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
            this.dgtPropiedades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPropietario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPropiedades)).BeginInit();
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
            // dgtPropiedades
            // 
            this.dgtPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtPropiedades.Location = new System.Drawing.Point(714, 71);
            this.dgtPropiedades.Name = "dgtPropiedades";
            this.dgtPropiedades.RowHeadersWidth = 62;
            this.dgtPropiedades.RowTemplate.Height = 28;
            this.dgtPropiedades.Size = new System.Drawing.Size(675, 455);
            this.dgtPropiedades.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1401, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtPropiedades);
            this.Controls.Add(this.dgtPropietario);
            this.Name = "Form1";
            this.Text = "Propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.dgtPropietario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtPropietario;
        private System.Windows.Forms.DataGridView dgtPropiedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button button1;
    }
}

