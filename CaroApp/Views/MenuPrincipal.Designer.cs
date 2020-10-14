namespace CaroApp
{
    partial class MenuPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxBancoFile = new System.Windows.Forms.TextBox();
            this.textBoxSAPFile = new System.Windows.Forms.TextBox();
            this.textBoxExtracto = new System.Windows.Forms.TextBox();
            this.textBoxIngresos = new System.Windows.Forms.TextBox();
            this.textBoxEgresos = new System.Windows.Forms.TextBox();
            this.textBoxDivision = new System.Windows.Forms.TextBox();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnUploadFileBanco = new System.Windows.Forms.Button();
            this.btnUploadFileSAP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDelimitador = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombreSalida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Archivo SAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de extracto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuenta de ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuenta de egreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "División";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cabecera archivo salida";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(189, 426);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 43);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(308, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 43);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 495);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(322, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // textBoxBancoFile
            // 
            this.textBoxBancoFile.Location = new System.Drawing.Point(174, 25);
            this.textBoxBancoFile.Name = "textBoxBancoFile";
            this.textBoxBancoFile.Size = new System.Drawing.Size(174, 20);
            this.textBoxBancoFile.TabIndex = 10;
            // 
            // textBoxSAPFile
            // 
            this.textBoxSAPFile.Location = new System.Drawing.Point(174, 64);
            this.textBoxSAPFile.Name = "textBoxSAPFile";
            this.textBoxSAPFile.Size = new System.Drawing.Size(174, 20);
            this.textBoxSAPFile.TabIndex = 11;
            // 
            // textBoxExtracto
            // 
            this.textBoxExtracto.Location = new System.Drawing.Point(174, 179);
            this.textBoxExtracto.Name = "textBoxExtracto";
            this.textBoxExtracto.Size = new System.Drawing.Size(223, 20);
            this.textBoxExtracto.TabIndex = 12;
            // 
            // textBoxIngresos
            // 
            this.textBoxIngresos.Location = new System.Drawing.Point(174, 215);
            this.textBoxIngresos.Name = "textBoxIngresos";
            this.textBoxIngresos.Size = new System.Drawing.Size(223, 20);
            this.textBoxIngresos.TabIndex = 13;
            // 
            // textBoxEgresos
            // 
            this.textBoxEgresos.Location = new System.Drawing.Point(174, 254);
            this.textBoxEgresos.Name = "textBoxEgresos";
            this.textBoxEgresos.Size = new System.Drawing.Size(223, 20);
            this.textBoxEgresos.TabIndex = 14;
            // 
            // textBoxDivision
            // 
            this.textBoxDivision.Location = new System.Drawing.Point(174, 296);
            this.textBoxDivision.Name = "textBoxDivision";
            this.textBoxDivision.Size = new System.Drawing.Size(223, 20);
            this.textBoxDivision.TabIndex = 15;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Location = new System.Drawing.Point(174, 378);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(223, 20);
            this.textBoxHeader.TabIndex = 16;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(373, 505);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(24, 13);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "0 %";
            // 
            // btnUploadFileBanco
            // 
            this.btnUploadFileBanco.Location = new System.Drawing.Point(354, 23);
            this.btnUploadFileBanco.Name = "btnUploadFileBanco";
            this.btnUploadFileBanco.Size = new System.Drawing.Size(49, 23);
            this.btnUploadFileBanco.TabIndex = 18;
            this.btnUploadFileBanco.Text = "Buscar Archivo";
            this.btnUploadFileBanco.UseVisualStyleBackColor = true;
            this.btnUploadFileBanco.Click += new System.EventHandler(this.btnUploadFileBanco_Click);
            // 
            // btnUploadFileSAP
            // 
            this.btnUploadFileSAP.Location = new System.Drawing.Point(354, 62);
            this.btnUploadFileSAP.Name = "btnUploadFileSAP";
            this.btnUploadFileSAP.Size = new System.Drawing.Size(49, 23);
            this.btnUploadFileSAP.TabIndex = 19;
            this.btnUploadFileSAP.Text = "Buscar Archivo";
            this.btnUploadFileSAP.UseVisualStyleBackColor = true;
            this.btnUploadFileSAP.Click += new System.EventHandler(this.btnUploadFileSAP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Codigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Delimitador";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nombre archivo salida";
            // 
            // textBoxDelimitador
            // 
            this.textBoxDelimitador.Location = new System.Drawing.Point(174, 105);
            this.textBoxDelimitador.MaxLength = 1;
            this.textBoxDelimitador.Name = "textBoxDelimitador";
            this.textBoxDelimitador.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelimitador.TabIndex = 23;
            this.textBoxDelimitador.Text = ";";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(174, 140);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 24;
            this.textBoxCodigo.Text = "2";
            // 
            // textBoxNombreSalida
            // 
            this.textBoxNombreSalida.Location = new System.Drawing.Point(174, 339);
            this.textBoxNombreSalida.Name = "textBoxNombreSalida";
            this.textBoxNombreSalida.Size = new System.Drawing.Size(223, 20);
            this.textBoxNombreSalida.TabIndex = 25;
            this.textBoxNombreSalida.Text = "ArchivoSalida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "versión: 0.9.2";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 575);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNombreSalida);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxDelimitador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUploadFileSAP);
            this.Controls.Add(this.btnUploadFileBanco);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.textBoxDivision);
            this.Controls.Add(this.textBoxEgresos);
            this.Controls.Add(this.textBoxIngresos);
            this.Controls.Add(this.textBoxExtracto);
            this.Controls.Add(this.textBoxSAPFile);
            this.Controls.Add(this.textBoxBancoFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.Text = "Caro App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxBancoFile;
        private System.Windows.Forms.TextBox textBoxSAPFile;
        private System.Windows.Forms.TextBox textBoxExtracto;
        private System.Windows.Forms.TextBox textBoxIngresos;
        private System.Windows.Forms.TextBox textBoxEgresos;
        private System.Windows.Forms.TextBox textBoxDivision;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnUploadFileBanco;
        private System.Windows.Forms.Button btnUploadFileSAP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDelimitador;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombreSalida;
        private System.Windows.Forms.Label label11;
    }
}

