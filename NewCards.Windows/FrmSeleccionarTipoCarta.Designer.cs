
namespace NewCards.Windows
{
    partial class FrmSeleccionarTipoCarta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Espaniolas40RadioButton = new System.Windows.Forms.RadioButton();
            this.Espaniolas50RadioButton = new System.Windows.Forms.RadioButton();
            this.FrancesasSinComodinRadioButton = new System.Windows.Forms.RadioButton();
            this.FrancesasConComodinRadioButton = new System.Windows.Forms.RadioButton();
            this.CrearMazoButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FrancesasConComodinRadioButton);
            this.groupBox1.Controls.Add(this.FrancesasSinComodinRadioButton);
            this.groupBox1.Controls.Add(this.Espaniolas50RadioButton);
            this.groupBox1.Controls.Add(this.Espaniolas40RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Seleccione Tipo de Carta ";
            // 
            // Espaniolas40RadioButton
            // 
            this.Espaniolas40RadioButton.AutoSize = true;
            this.Espaniolas40RadioButton.Checked = true;
            this.Espaniolas40RadioButton.Location = new System.Drawing.Point(19, 31);
            this.Espaniolas40RadioButton.Name = "Espaniolas40RadioButton";
            this.Espaniolas40RadioButton.Size = new System.Drawing.Size(104, 17);
            this.Espaniolas40RadioButton.TabIndex = 0;
            this.Espaniolas40RadioButton.Text = "Españolas de 40";
            this.Espaniolas40RadioButton.UseVisualStyleBackColor = true;
            // 
            // Espaniolas50RadioButton
            // 
            this.Espaniolas50RadioButton.AutoSize = true;
            this.Espaniolas50RadioButton.Location = new System.Drawing.Point(19, 54);
            this.Espaniolas50RadioButton.Name = "Espaniolas50RadioButton";
            this.Espaniolas50RadioButton.Size = new System.Drawing.Size(104, 17);
            this.Espaniolas50RadioButton.TabIndex = 0;
            this.Espaniolas50RadioButton.Text = "Españolas de 50";
            this.Espaniolas50RadioButton.UseVisualStyleBackColor = true;
            // 
            // FrancesasSinComodinRadioButton
            // 
            this.FrancesasSinComodinRadioButton.AutoSize = true;
            this.FrancesasSinComodinRadioButton.Location = new System.Drawing.Point(19, 77);
            this.FrancesasSinComodinRadioButton.Name = "FrancesasSinComodinRadioButton";
            this.FrancesasSinComodinRadioButton.Size = new System.Drawing.Size(136, 17);
            this.FrancesasSinComodinRadioButton.TabIndex = 0;
            this.FrancesasSinComodinRadioButton.Text = "Francesas sin Comodín";
            this.FrancesasSinComodinRadioButton.UseVisualStyleBackColor = true;
            // 
            // FrancesasConComodinRadioButton
            // 
            this.FrancesasConComodinRadioButton.AutoSize = true;
            this.FrancesasConComodinRadioButton.Location = new System.Drawing.Point(19, 100);
            this.FrancesasConComodinRadioButton.Name = "FrancesasConComodinRadioButton";
            this.FrancesasConComodinRadioButton.Size = new System.Drawing.Size(141, 17);
            this.FrancesasConComodinRadioButton.TabIndex = 0;
            this.FrancesasConComodinRadioButton.Text = "Francesas con Comodín";
            this.FrancesasConComodinRadioButton.UseVisualStyleBackColor = true;
            // 
            // CrearMazoButton
            // 
            this.CrearMazoButton.Location = new System.Drawing.Point(249, 35);
            this.CrearMazoButton.Name = "CrearMazoButton";
            this.CrearMazoButton.Size = new System.Drawing.Size(115, 37);
            this.CrearMazoButton.TabIndex = 1;
            this.CrearMazoButton.Text = "Crear Mazo";
            this.CrearMazoButton.UseVisualStyleBackColor = true;
            this.CrearMazoButton.Click += new System.EventHandler(this.CrearMazoButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(249, 114);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(115, 37);
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // FrmSeleccionarTipoCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 305);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.CrearMazoButton);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(406, 344);
            this.MinimumSize = new System.Drawing.Size(406, 344);
            this.Name = "FrmSeleccionarTipoCarta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FrancesasConComodinRadioButton;
        private System.Windows.Forms.RadioButton FrancesasSinComodinRadioButton;
        private System.Windows.Forms.RadioButton Espaniolas50RadioButton;
        private System.Windows.Forms.RadioButton Espaniolas40RadioButton;
        private System.Windows.Forms.Button CrearMazoButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}

