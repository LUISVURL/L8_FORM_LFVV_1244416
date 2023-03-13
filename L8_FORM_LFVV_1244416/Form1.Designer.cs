namespace L8_FORM_LFVV_1244416
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.GB_SELECCION = new System.Windows.Forms.GroupBox();
            this.CB_SELECCION = new System.Windows.Forms.ComboBox();
            this.TC_RESPUESTAS = new System.Windows.Forms.TabControl();
            this.TP_SUMATORIA = new System.Windows.Forms.TabPage();
            this.LBL_RESULTADO2 = new System.Windows.Forms.Label();
            this.LBL_RESULTADO1 = new System.Windows.Forms.Label();
            this.TB_INGRESARNSUMATORIA = new System.Windows.Forms.TextBox();
            this.LBL_INGRESEN = new System.Windows.Forms.Label();
            this.TP_MULTIPLICAR = new System.Windows.Forms.TabPage();
            this.LBL_MULTIRESULTADO2 = new System.Windows.Forms.Label();
            this.TP_NPERFECTO = new System.Windows.Forms.TabPage();
            this.LBL_R2NPERFECTO = new System.Windows.Forms.Label();
            this.LBL_R1NPERFECTO = new System.Windows.Forms.Label();
            this.TB_NPERFECTO = new System.Windows.Forms.TextBox();
            this.LBL_INGRESENPERFECTO = new System.Windows.Forms.Label();
            this.BTT_SELECCION = new System.Windows.Forms.Button();
            this.LBL_MULTIRESULTADO1 = new System.Windows.Forms.Label();
            this.LBL_INGRESEN1M = new System.Windows.Forms.Label();
            this.LBL_INGRESEN2M = new System.Windows.Forms.Label();
            this.TB_N1MULTIPLICACION = new System.Windows.Forms.TextBox();
            this.TB_N2MULTIPLICACION = new System.Windows.Forms.TextBox();
            this.GB_SELECCION.SuspendLayout();
            this.TC_RESPUESTAS.SuspendLayout();
            this.TP_SUMATORIA.SuspendLayout();
            this.TP_MULTIPLICAR.SuspendLayout();
            this.TP_NPERFECTO.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(371, 26);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(286, 36);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Laboratorio 8 Form";
            // 
            // GB_SELECCION
            // 
            this.GB_SELECCION.Controls.Add(this.CB_SELECCION);
            this.GB_SELECCION.Location = new System.Drawing.Point(44, 117);
            this.GB_SELECCION.Margin = new System.Windows.Forms.Padding(4);
            this.GB_SELECCION.Name = "GB_SELECCION";
            this.GB_SELECCION.Padding = new System.Windows.Forms.Padding(4);
            this.GB_SELECCION.Size = new System.Drawing.Size(267, 123);
            this.GB_SELECCION.TabIndex = 2;
            this.GB_SELECCION.TabStop = false;
            this.GB_SELECCION.Text = "Selección";
            // 
            // CB_SELECCION
            // 
            this.CB_SELECCION.FormattingEnabled = true;
            this.CB_SELECCION.Items.AddRange(new object[] {
            "Sumatoria",
            "Tablas de Multiplicar",
            "Número Perfecto"});
            this.CB_SELECCION.Location = new System.Drawing.Point(48, 53);
            this.CB_SELECCION.Margin = new System.Windows.Forms.Padding(4);
            this.CB_SELECCION.Name = "CB_SELECCION";
            this.CB_SELECCION.Size = new System.Drawing.Size(160, 24);
            this.CB_SELECCION.TabIndex = 0;
            this.CB_SELECCION.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TC_RESPUESTAS
            // 
            this.TC_RESPUESTAS.Controls.Add(this.TP_SUMATORIA);
            this.TC_RESPUESTAS.Controls.Add(this.TP_MULTIPLICAR);
            this.TC_RESPUESTAS.Controls.Add(this.TP_NPERFECTO);
            this.TC_RESPUESTAS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TC_RESPUESTAS.Location = new System.Drawing.Point(353, 117);
            this.TC_RESPUESTAS.Margin = new System.Windows.Forms.Padding(4);
            this.TC_RESPUESTAS.Name = "TC_RESPUESTAS";
            this.TC_RESPUESTAS.SelectedIndex = 0;
            this.TC_RESPUESTAS.Size = new System.Drawing.Size(638, 365);
            this.TC_RESPUESTAS.TabIndex = 3;
            this.TC_RESPUESTAS.TabStop = false;
            // 
            // TP_SUMATORIA
            // 
            this.TP_SUMATORIA.Controls.Add(this.LBL_RESULTADO2);
            this.TP_SUMATORIA.Controls.Add(this.LBL_RESULTADO1);
            this.TP_SUMATORIA.Controls.Add(this.TB_INGRESARNSUMATORIA);
            this.TP_SUMATORIA.Controls.Add(this.LBL_INGRESEN);
            this.TP_SUMATORIA.Location = new System.Drawing.Point(4, 25);
            this.TP_SUMATORIA.Margin = new System.Windows.Forms.Padding(4);
            this.TP_SUMATORIA.Name = "TP_SUMATORIA";
            this.TP_SUMATORIA.Padding = new System.Windows.Forms.Padding(4);
            this.TP_SUMATORIA.Size = new System.Drawing.Size(693, 404);
            this.TP_SUMATORIA.TabIndex = 0;
            this.TP_SUMATORIA.Text = "Sumatoria";
            this.TP_SUMATORIA.UseVisualStyleBackColor = true;
            // 
            // LBL_RESULTADO2
            // 
            this.LBL_RESULTADO2.AutoSize = true;
            this.LBL_RESULTADO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RESULTADO2.Location = new System.Drawing.Point(243, 135);
            this.LBL_RESULTADO2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_RESULTADO2.Name = "LBL_RESULTADO2";
            this.LBL_RESULTADO2.Size = new System.Drawing.Size(0, 20);
            this.LBL_RESULTADO2.TabIndex = 3;
            // 
            // LBL_RESULTADO1
            // 
            this.LBL_RESULTADO1.AutoSize = true;
            this.LBL_RESULTADO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RESULTADO1.Location = new System.Drawing.Point(42, 135);
            this.LBL_RESULTADO1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_RESULTADO1.Name = "LBL_RESULTADO1";
            this.LBL_RESULTADO1.Size = new System.Drawing.Size(105, 20);
            this.LBL_RESULTADO1.TabIndex = 2;
            this.LBL_RESULTADO1.Text = "Resultado: ";
            this.LBL_RESULTADO1.Click += new System.EventHandler(this.LBL_RESULTADO1_Click);
            // 
            // TB_INGRESARNSUMATORIA
            // 
            this.TB_INGRESARNSUMATORIA.Location = new System.Drawing.Point(247, 37);
            this.TB_INGRESARNSUMATORIA.Margin = new System.Windows.Forms.Padding(4);
            this.TB_INGRESARNSUMATORIA.Name = "TB_INGRESARNSUMATORIA";
            this.TB_INGRESARNSUMATORIA.Size = new System.Drawing.Size(132, 22);
            this.TB_INGRESARNSUMATORIA.TabIndex = 1;
            this.TB_INGRESARNSUMATORIA.TextChanged += new System.EventHandler(this.TB_INGRESARNSUMATORIA_TextChanged);
            // 
            // LBL_INGRESEN
            // 
            this.LBL_INGRESEN.AutoSize = true;
            this.LBL_INGRESEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_INGRESEN.Location = new System.Drawing.Point(42, 40);
            this.LBL_INGRESEN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_INGRESEN.Name = "LBL_INGRESEN";
            this.LBL_INGRESEN.Size = new System.Drawing.Size(164, 20);
            this.LBL_INGRESEN.TabIndex = 0;
            this.LBL_INGRESEN.Text = "Ingrese número N:";
            this.LBL_INGRESEN.Click += new System.EventHandler(this.LBL_INGRESEN_Click);
            // 
            // TP_MULTIPLICAR
            // 
            this.TP_MULTIPLICAR.Controls.Add(this.TB_N2MULTIPLICACION);
            this.TP_MULTIPLICAR.Controls.Add(this.TB_N1MULTIPLICACION);
            this.TP_MULTIPLICAR.Controls.Add(this.LBL_INGRESEN2M);
            this.TP_MULTIPLICAR.Controls.Add(this.LBL_INGRESEN1M);
            this.TP_MULTIPLICAR.Controls.Add(this.LBL_MULTIRESULTADO1);
            this.TP_MULTIPLICAR.Controls.Add(this.LBL_MULTIRESULTADO2);
            this.TP_MULTIPLICAR.Location = new System.Drawing.Point(4, 25);
            this.TP_MULTIPLICAR.Margin = new System.Windows.Forms.Padding(4);
            this.TP_MULTIPLICAR.Name = "TP_MULTIPLICAR";
            this.TP_MULTIPLICAR.Padding = new System.Windows.Forms.Padding(4);
            this.TP_MULTIPLICAR.Size = new System.Drawing.Size(630, 336);
            this.TP_MULTIPLICAR.TabIndex = 2;
            this.TP_MULTIPLICAR.Text = "Tablas de Multiplicar";
            this.TP_MULTIPLICAR.UseVisualStyleBackColor = true;
            // 
            // LBL_MULTIRESULTADO2
            // 
            this.LBL_MULTIRESULTADO2.AutoSize = true;
            this.LBL_MULTIRESULTADO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MULTIRESULTADO2.Location = new System.Drawing.Point(247, 167);
            this.LBL_MULTIRESULTADO2.Name = "LBL_MULTIRESULTADO2";
            this.LBL_MULTIRESULTADO2.Size = new System.Drawing.Size(0, 20);
            this.LBL_MULTIRESULTADO2.TabIndex = 0;
            // 
            // TP_NPERFECTO
            // 
            this.TP_NPERFECTO.Controls.Add(this.LBL_R2NPERFECTO);
            this.TP_NPERFECTO.Controls.Add(this.LBL_R1NPERFECTO);
            this.TP_NPERFECTO.Controls.Add(this.TB_NPERFECTO);
            this.TP_NPERFECTO.Controls.Add(this.LBL_INGRESENPERFECTO);
            this.TP_NPERFECTO.Location = new System.Drawing.Point(4, 25);
            this.TP_NPERFECTO.Margin = new System.Windows.Forms.Padding(4);
            this.TP_NPERFECTO.Name = "TP_NPERFECTO";
            this.TP_NPERFECTO.Padding = new System.Windows.Forms.Padding(4);
            this.TP_NPERFECTO.Size = new System.Drawing.Size(693, 404);
            this.TP_NPERFECTO.TabIndex = 3;
            this.TP_NPERFECTO.Text = "Número Perfecto";
            this.TP_NPERFECTO.UseVisualStyleBackColor = true;
            // 
            // LBL_R2NPERFECTO
            // 
            this.LBL_R2NPERFECTO.AutoSize = true;
            this.LBL_R2NPERFECTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_R2NPERFECTO.Location = new System.Drawing.Point(244, 149);
            this.LBL_R2NPERFECTO.Name = "LBL_R2NPERFECTO";
            this.LBL_R2NPERFECTO.Size = new System.Drawing.Size(0, 20);
            this.LBL_R2NPERFECTO.TabIndex = 6;
            // 
            // LBL_R1NPERFECTO
            // 
            this.LBL_R1NPERFECTO.AutoSize = true;
            this.LBL_R1NPERFECTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_R1NPERFECTO.Location = new System.Drawing.Point(43, 149);
            this.LBL_R1NPERFECTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_R1NPERFECTO.Name = "LBL_R1NPERFECTO";
            this.LBL_R1NPERFECTO.Size = new System.Drawing.Size(105, 20);
            this.LBL_R1NPERFECTO.TabIndex = 5;
            this.LBL_R1NPERFECTO.Text = "Resultado: ";
            // 
            // TB_NPERFECTO
            // 
            this.TB_NPERFECTO.Location = new System.Drawing.Point(248, 51);
            this.TB_NPERFECTO.Margin = new System.Windows.Forms.Padding(4);
            this.TB_NPERFECTO.Name = "TB_NPERFECTO";
            this.TB_NPERFECTO.Size = new System.Drawing.Size(132, 22);
            this.TB_NPERFECTO.TabIndex = 4;
            this.TB_NPERFECTO.TextChanged += new System.EventHandler(this.TB_NPERFECTO_TextChanged);
            // 
            // LBL_INGRESENPERFECTO
            // 
            this.LBL_INGRESENPERFECTO.AutoSize = true;
            this.LBL_INGRESENPERFECTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_INGRESENPERFECTO.Location = new System.Drawing.Point(43, 54);
            this.LBL_INGRESENPERFECTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_INGRESENPERFECTO.Name = "LBL_INGRESENPERFECTO";
            this.LBL_INGRESENPERFECTO.Size = new System.Drawing.Size(164, 20);
            this.LBL_INGRESENPERFECTO.TabIndex = 3;
            this.LBL_INGRESENPERFECTO.Text = "Ingrese número N:";
            // 
            // BTT_SELECCION
            // 
            this.BTT_SELECCION.Location = new System.Drawing.Point(107, 270);
            this.BTT_SELECCION.Margin = new System.Windows.Forms.Padding(4);
            this.BTT_SELECCION.Name = "BTT_SELECCION";
            this.BTT_SELECCION.Size = new System.Drawing.Size(133, 37);
            this.BTT_SELECCION.TabIndex = 4;
            this.BTT_SELECCION.Text = "Seleccionar";
            this.BTT_SELECCION.UseVisualStyleBackColor = true;
            this.BTT_SELECCION.Click += new System.EventHandler(this.BTT_SELECCION_Click);
            // 
            // LBL_MULTIRESULTADO1
            // 
            this.LBL_MULTIRESULTADO1.AutoSize = true;
            this.LBL_MULTIRESULTADO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MULTIRESULTADO1.Location = new System.Drawing.Point(60, 167);
            this.LBL_MULTIRESULTADO1.Name = "LBL_MULTIRESULTADO1";
            this.LBL_MULTIRESULTADO1.Size = new System.Drawing.Size(99, 20);
            this.LBL_MULTIRESULTADO1.TabIndex = 1;
            this.LBL_MULTIRESULTADO1.Text = "Resultado:";
            // 
            // LBL_INGRESEN1M
            // 
            this.LBL_INGRESEN1M.AutoSize = true;
            this.LBL_INGRESEN1M.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_INGRESEN1M.Location = new System.Drawing.Point(60, 44);
            this.LBL_INGRESEN1M.Name = "LBL_INGRESEN1M";
            this.LBL_INGRESEN1M.Size = new System.Drawing.Size(174, 20);
            this.LBL_INGRESEN1M.TabIndex = 2;
            this.LBL_INGRESEN1M.Text = "Ingrese un Número:";
            // 
            // LBL_INGRESEN2M
            // 
            this.LBL_INGRESEN2M.AutoSize = true;
            this.LBL_INGRESEN2M.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_INGRESEN2M.Location = new System.Drawing.Point(60, 106);
            this.LBL_INGRESEN2M.Name = "LBL_INGRESEN2M";
            this.LBL_INGRESEN2M.Size = new System.Drawing.Size(174, 20);
            this.LBL_INGRESEN2M.TabIndex = 3;
            this.LBL_INGRESEN2M.Text = "Ingrese un Número:";
            // 
            // TB_N1MULTIPLICACION
            // 
            this.TB_N1MULTIPLICACION.Location = new System.Drawing.Point(292, 44);
            this.TB_N1MULTIPLICACION.Name = "TB_N1MULTIPLICACION";
            this.TB_N1MULTIPLICACION.Size = new System.Drawing.Size(144, 22);
            this.TB_N1MULTIPLICACION.TabIndex = 4;
            this.TB_N1MULTIPLICACION.TextChanged += new System.EventHandler(this.TB_N1MULTIPLICACION_TextChanged);
            // 
            // TB_N2MULTIPLICACION
            // 
            this.TB_N2MULTIPLICACION.Location = new System.Drawing.Point(292, 106);
            this.TB_N2MULTIPLICACION.Name = "TB_N2MULTIPLICACION";
            this.TB_N2MULTIPLICACION.Size = new System.Drawing.Size(144, 22);
            this.TB_N2MULTIPLICACION.TabIndex = 5;
            this.TB_N2MULTIPLICACION.TextChanged += new System.EventHandler(this.TB_N2MULTIPLICACION_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BTT_SELECCION);
            this.Controls.Add(this.TC_RESPUESTAS);
            this.Controls.Add(this.GB_SELECCION);
            this.Controls.Add(this.lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Laboratorio 8";
            this.GB_SELECCION.ResumeLayout(false);
            this.TC_RESPUESTAS.ResumeLayout(false);
            this.TP_SUMATORIA.ResumeLayout(false);
            this.TP_SUMATORIA.PerformLayout();
            this.TP_MULTIPLICAR.ResumeLayout(false);
            this.TP_MULTIPLICAR.PerformLayout();
            this.TP_NPERFECTO.ResumeLayout(false);
            this.TP_NPERFECTO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox GB_SELECCION;
        private System.Windows.Forms.ComboBox CB_SELECCION;
        private System.Windows.Forms.TabControl TC_RESPUESTAS;
        private System.Windows.Forms.TabPage TP_SUMATORIA;
        private System.Windows.Forms.Button BTT_SELECCION;
        private System.Windows.Forms.TabPage TP_MULTIPLICAR;
        private System.Windows.Forms.TabPage TP_NPERFECTO;
        private System.Windows.Forms.Label LBL_RESULTADO2;
        private System.Windows.Forms.Label LBL_RESULTADO1;
        private System.Windows.Forms.TextBox TB_INGRESARNSUMATORIA;
        private System.Windows.Forms.Label LBL_INGRESEN;
        private System.Windows.Forms.Label LBL_MULTIRESULTADO2;
        private System.Windows.Forms.Label LBL_R2NPERFECTO;
        private System.Windows.Forms.Label LBL_R1NPERFECTO;
        private System.Windows.Forms.TextBox TB_NPERFECTO;
        private System.Windows.Forms.Label LBL_INGRESENPERFECTO;
        private System.Windows.Forms.Label LBL_INGRESEN2M;
        private System.Windows.Forms.Label LBL_INGRESEN1M;
        private System.Windows.Forms.Label LBL_MULTIRESULTADO1;
        private System.Windows.Forms.TextBox TB_N2MULTIPLICACION;
        private System.Windows.Forms.TextBox TB_N1MULTIPLICACION;
    }
}

