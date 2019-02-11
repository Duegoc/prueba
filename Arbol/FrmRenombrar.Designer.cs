namespace Arbol
{
    partial class FrmRenombrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenombrar));
            this.btnInterfases = new System.Windows.Forms.Button();
            this.tvFile = new System.Windows.Forms.TreeView();
            this.btnRenombrar = new System.Windows.Forms.Button();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtExtencion = new System.Windows.Forms.TextBox();
            this.Cootrasalida = new System.Windows.Forms.Button();
            this.lbNombreArchivo = new System.Windows.Forms.Label();
            this.lbExtension = new System.Windows.Forms.Label();
            this.btnMod_130 = new System.Windows.Forms.Button();
            this.btnMod_Acci = new System.Windows.Forms.Button();
            this.btn_mod_blackrock = new System.Windows.Forms.Button();
            this.btnMod_citidirect = new System.Windows.Forms.Button();
            this.lbSeparador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInterfases
            // 
            this.btnInterfases.Location = new System.Drawing.Point(12, 12);
            this.btnInterfases.Name = "btnInterfases";
            this.btnInterfases.Size = new System.Drawing.Size(114, 35);
            this.btnInterfases.TabIndex = 0;
            this.btnInterfases.Text = "&INTERFASES";
            this.btnInterfases.UseVisualStyleBackColor = true;
            this.btnInterfases.Click += new System.EventHandler(this.btnInterfases_Click);
            // 
            // tvFile
            // 
            this.tvFile.Location = new System.Drawing.Point(133, 12);
            this.tvFile.Name = "tvFile";
            this.tvFile.Size = new System.Drawing.Size(291, 199);
            this.tvFile.TabIndex = 1;
            this.tvFile.DoubleClick += new System.EventHandler(this.tvFile_DoubleClick);
            // 
            // btnRenombrar
            // 
            this.btnRenombrar.Location = new System.Drawing.Point(12, 271);
            this.btnRenombrar.Name = "btnRenombrar";
            this.btnRenombrar.Size = new System.Drawing.Size(75, 23);
            this.btnRenombrar.TabIndex = 2;
            this.btnRenombrar.Text = "Renombrar";
            this.btnRenombrar.UseVisualStyleBackColor = true;
            this.btnRenombrar.Click += new System.EventHandler(this.btnRenombrar_Click);
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(12, 236);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(322, 20);
            this.txtCambio.TabIndex = 4;
            // 
            // txtExtencion
            // 
            this.txtExtencion.Location = new System.Drawing.Point(344, 236);
            this.txtExtencion.Name = "txtExtencion";
            this.txtExtencion.Size = new System.Drawing.Size(80, 20);
            this.txtExtencion.TabIndex = 5;
            this.txtExtencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtencion_KeyPress);
            // 
            // Cootrasalida
            // 
            this.Cootrasalida.BackColor = System.Drawing.SystemColors.Control;
            this.Cootrasalida.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cootrasalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cootrasalida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cootrasalida.Image = ((System.Drawing.Image)(resources.GetObject("Cootrasalida.Image")));
            this.Cootrasalida.Location = new System.Drawing.Point(363, 262);
            this.Cootrasalida.Name = "Cootrasalida";
            this.Cootrasalida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cootrasalida.Size = new System.Drawing.Size(61, 53);
            this.Cootrasalida.TabIndex = 9;
            this.Cootrasalida.Text = "&Salir";
            this.Cootrasalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cootrasalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cootrasalida.UseVisualStyleBackColor = false;
            this.Cootrasalida.Click += new System.EventHandler(this.Cootrasalida_Click);
            // 
            // lbNombreArchivo
            // 
            this.lbNombreArchivo.AutoSize = true;
            this.lbNombreArchivo.Location = new System.Drawing.Point(12, 220);
            this.lbNombreArchivo.Name = "lbNombreArchivo";
            this.lbNombreArchivo.Size = new System.Drawing.Size(43, 13);
            this.lbNombreArchivo.TabIndex = 10;
            this.lbNombreArchivo.Text = "Archivo";
            // 
            // lbExtension
            // 
            this.lbExtension.AutoSize = true;
            this.lbExtension.Location = new System.Drawing.Point(341, 220);
            this.lbExtension.Name = "lbExtension";
            this.lbExtension.Size = new System.Drawing.Size(53, 13);
            this.lbExtension.TabIndex = 11;
            this.lbExtension.Text = "Extensión";
            // 
            // btnMod_130
            // 
            this.btnMod_130.Location = new System.Drawing.Point(12, 53);
            this.btnMod_130.Name = "btnMod_130";
            this.btnMod_130.Size = new System.Drawing.Size(114, 35);
            this.btnMod_130.TabIndex = 12;
            this.btnMod_130.Text = "&MOD_130";
            this.btnMod_130.UseVisualStyleBackColor = true;
            this.btnMod_130.Click += new System.EventHandler(this.btnMod_130_Click);
            // 
            // btnMod_Acci
            // 
            this.btnMod_Acci.Location = new System.Drawing.Point(12, 94);
            this.btnMod_Acci.Name = "btnMod_Acci";
            this.btnMod_Acci.Size = new System.Drawing.Size(114, 35);
            this.btnMod_Acci.TabIndex = 13;
            this.btnMod_Acci.Text = "&MOD_ACCI";
            this.btnMod_Acci.UseVisualStyleBackColor = true;
            this.btnMod_Acci.Click += new System.EventHandler(this.btnMod_Acci_Click);
            // 
            // btn_mod_blackrock
            // 
            this.btn_mod_blackrock.Location = new System.Drawing.Point(12, 135);
            this.btn_mod_blackrock.Name = "btn_mod_blackrock";
            this.btn_mod_blackrock.Size = new System.Drawing.Size(114, 35);
            this.btn_mod_blackrock.TabIndex = 14;
            this.btn_mod_blackrock.Text = "&MOD_BLACKROCK";
            this.btn_mod_blackrock.UseVisualStyleBackColor = true;
            this.btn_mod_blackrock.Click += new System.EventHandler(this.btn_mod_blackrock_Click);
            // 
            // btnMod_citidirect
            // 
            this.btnMod_citidirect.Location = new System.Drawing.Point(12, 176);
            this.btnMod_citidirect.Name = "btnMod_citidirect";
            this.btnMod_citidirect.Size = new System.Drawing.Size(114, 35);
            this.btnMod_citidirect.TabIndex = 15;
            this.btnMod_citidirect.Text = "&MOD_CITIDIRECT";
            this.btnMod_citidirect.UseVisualStyleBackColor = true;
            this.btnMod_citidirect.Click += new System.EventHandler(this.btnMod_citidirect_Click);
            // 
            // lbSeparador
            // 
            this.lbSeparador.AutoSize = true;
            this.lbSeparador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeparador.Location = new System.Drawing.Point(328, 227);
            this.lbSeparador.Name = "lbSeparador";
            this.lbSeparador.Size = new System.Drawing.Size(23, 31);
            this.lbSeparador.TabIndex = 16;
            this.lbSeparador.Text = ".";
            // 
            // FrmRenombrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 327);
            this.Controls.Add(this.lbExtension);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtExtencion);
            this.Controls.Add(this.lbSeparador);
            this.Controls.Add(this.btnMod_citidirect);
            this.Controls.Add(this.btn_mod_blackrock);
            this.Controls.Add(this.btnMod_Acci);
            this.Controls.Add(this.btnMod_130);
            this.Controls.Add(this.lbNombreArchivo);
            this.Controls.Add(this.Cootrasalida);
            this.Controls.Add(this.btnRenombrar);
            this.Controls.Add(this.tvFile);
            this.Controls.Add(this.btnInterfases);
            this.Name = "FrmRenombrar";
            this.Text = "Renombrar";
            this.Load += new System.EventHandler(this.FrmRenombrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInterfases;
        private System.Windows.Forms.TreeView tvFile;
        private System.Windows.Forms.Button btnRenombrar;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtExtencion;
        public System.Windows.Forms.Button Cootrasalida;
        private System.Windows.Forms.Label lbNombreArchivo;
        private System.Windows.Forms.Label lbExtension;
        private System.Windows.Forms.Button btnMod_130;
        private System.Windows.Forms.Button btnMod_Acci;
        private System.Windows.Forms.Button btn_mod_blackrock;
        private System.Windows.Forms.Button btnMod_citidirect;
        private System.Windows.Forms.Label lbSeparador;
    }
}

