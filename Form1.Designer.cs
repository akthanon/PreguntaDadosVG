namespace PreguntaDadosVG
{
    partial class PreguntasDadosVI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreguntasDadosVI));
            this.botoncito = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.botonClear = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.Label();
            this.opcionesBox = new System.Windows.Forms.ComboBox();
            this.definirBox = new System.Windows.Forms.CheckBox();
            this.tamDadoBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numTiros = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonRoll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cuadroResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tamDadoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botoncito
            // 
            this.botoncito.Location = new System.Drawing.Point(12, 13);
            this.botoncito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botoncito.Name = "botoncito";
            this.botoncito.Size = new System.Drawing.Size(371, 100);
            this.botoncito.TabIndex = 0;
            this.botoncito.Text = "Calcular probabilidad";
            this.botoncito.UseVisualStyleBackColor = true;
            this.botoncito.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.AccessibleName = "";
            this.botonCerrar.BackColor = System.Drawing.Color.Crimson;
            this.botonCerrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonCerrar.Location = new System.Drawing.Point(271, 350);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(112, 62);
            this.botonCerrar.TabIndex = 2;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = false;
            this.botonCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonClear
            // 
            this.botonClear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.botonClear.Location = new System.Drawing.Point(24, 350);
            this.botonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonClear.Name = "botonClear";
            this.botonClear.Size = new System.Drawing.Size(112, 62);
            this.botonClear.TabIndex = 3;
            this.botonClear.Text = "Clear";
            this.botonClear.UseVisualStyleBackColor = false;
            this.botonClear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtSalida
            // 
            this.txtSalida.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSalida.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSalida.Location = new System.Drawing.Point(12, 167);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(371, 37);
            this.txtSalida.TabIndex = 4;
            this.txtSalida.Click += new System.EventHandler(this.textoSalida_Click);
            // 
            // opcionesBox
            // 
            this.opcionesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opcionesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesBox.FormattingEnabled = true;
            this.opcionesBox.Items.AddRange(new object[] {
            "de obtener todas las opciones",
            "de obtener una opción",
            "de obtener una opción antes del lanzamiento dado",
            "de no obtener el resultado deseado",
            "de no obtener la opción en el tiro dado"});
            this.opcionesBox.Location = new System.Drawing.Point(12, 121);
            this.opcionesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opcionesBox.Name = "opcionesBox";
            this.opcionesBox.Size = new System.Drawing.Size(371, 33);
            this.opcionesBox.TabIndex = 7;
            this.opcionesBox.Text = "Seleccionar probabilidad";
            this.opcionesBox.SelectedIndexChanged += new System.EventHandler(this.opcionesBox_SelectedIndexChanged);
            // 
            // definirBox
            // 
            this.definirBox.AutoSize = true;
            this.definirBox.Location = new System.Drawing.Point(12, 226);
            this.definirBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.definirBox.Name = "definirBox";
            this.definirBox.Size = new System.Drawing.Size(124, 24);
            this.definirBox.TabIndex = 8;
            this.definirBox.Text = "Definir Tiros";
            this.definirBox.UseVisualStyleBackColor = true;
            this.definirBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tamDadoBox
            // 
            this.tamDadoBox.Location = new System.Drawing.Point(239, 275);
            this.tamDadoBox.Name = "tamDadoBox";
            this.tamDadoBox.Size = new System.Drawing.Size(144, 26);
            this.tamDadoBox.TabIndex = 9;
            this.tamDadoBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.tamDadoBox.ValueChanged += new System.EventHandler(this.tamDadoBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(16, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tamaño del Dado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numTiros
            // 
            this.numTiros.Location = new System.Drawing.Point(240, 224);
            this.numTiros.Name = "numTiros";
            this.numTiros.Size = new System.Drawing.Size(143, 26);
            this.numTiros.TabIndex = 11;
            this.numTiros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTiros.ValueChanged += new System.EventHandler(this.numTiros_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(404, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(286, 400);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de Tiros";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Probabilidad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // botonRoll
            // 
            this.botonRoll.Location = new System.Drawing.Point(696, 13);
            this.botonRoll.Name = "botonRoll";
            this.botonRoll.Size = new System.Drawing.Size(181, 78);
            this.botonRoll.TabIndex = 14;
            this.botonRoll.Text = "Tirar Dado";
            this.botonRoll.UseVisualStyleBackColor = true;
            this.botonRoll.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(742, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Resultado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cuadroResultado
            // 
            this.cuadroResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuadroResultado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cuadroResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroResultado.ForeColor = System.Drawing.Color.Honeydew;
            this.cuadroResultado.Image = global::PreguntaDadosVG.Properties.Resources.dado_6;
            this.cuadroResultado.Location = new System.Drawing.Point(715, 183);
            this.cuadroResultado.Name = "cuadroResultado";
            this.cuadroResultado.Size = new System.Drawing.Size(150, 150);
            this.cuadroResultado.TabIndex = 16;
            this.cuadroResultado.Text = "0";
            this.cuadroResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cuadroResultado.Click += new System.EventHandler(this.cuadroResultado_Click);
            // 
            // PreguntasDadosVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(887, 420);
            this.Controls.Add(this.cuadroResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonRoll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numTiros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tamDadoBox);
            this.Controls.Add(this.definirBox);
            this.Controls.Add(this.opcionesBox);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.botonClear);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botoncito);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PreguntasDadosVI";
            this.Text = "Preguntas Dados VI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tamDadoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botoncito;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Button botonClear;
        private System.Windows.Forms.Label txtSalida;
        private System.Windows.Forms.ComboBox opcionesBox;
        private System.Windows.Forms.CheckBox definirBox;
        private System.Windows.Forms.NumericUpDown tamDadoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTiros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button botonRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cuadroResultado;
    }
}

