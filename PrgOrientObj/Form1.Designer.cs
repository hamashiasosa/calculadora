namespace PrgOrientObj
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OP1 = new System.Windows.Forms.TextBox();
            this.OP2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.resultado2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboBoxText = new System.Windows.Forms.ComboBox();
            this.Operar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OP1
            // 
            this.OP1.BackColor = System.Drawing.Color.White;
            this.OP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OP1.Location = new System.Drawing.Point(48, 120);
            this.OP1.Name = "OP1";
            this.OP1.Size = new System.Drawing.Size(117, 27);
            this.OP1.TabIndex = 0;
            // 
            // OP2
            // 
            this.OP2.Location = new System.Drawing.Point(354, 120);
            this.OP2.Name = "OP2";
            this.OP2.Size = new System.Drawing.Size(117, 27);
            this.OP2.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(498, 119);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(117, 27);
            this.txtResult.TabIndex = 4;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(116, 193);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(219, 27);
            this.text1.TabIndex = 5;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(116, 252);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(219, 27);
            this.text2.TabIndex = 6;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(116, 321);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(219, 27);
            this.text3.TabIndex = 7;
            // 
            // resultado2
            // 
            this.resultado2.Location = new System.Drawing.Point(116, 381);
            this.resultado2.Name = "resultado2";
            this.resultado2.ReadOnly = true;
            this.resultado2.Size = new System.Drawing.Size(219, 27);
            this.resultado2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(48, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Operando 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(363, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operando 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(498, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Location = new System.Drawing.Point(198, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Operacion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.White;
            this.Calcular.Location = new System.Drawing.Point(647, 112);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(117, 41);
            this.Calcular.TabIndex = 14;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(27, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cadena 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Chartreuse;
            this.label6.Location = new System.Drawing.Point(27, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cadena 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Chartreuse;
            this.label7.Location = new System.Drawing.Point(27, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cadena 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Chartreuse;
            this.label8.Location = new System.Drawing.Point(27, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Resultado";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+ Suma",
            "- Resta",
            "x Multiplicar",
            "/ Dividir"});
            this.comboBox1.Location = new System.Drawing.Point(181, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Seleccionar";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 20;
            // 
            // ComboBoxText
            // 
            this.ComboBoxText.FormattingEnabled = true;
            this.ComboBoxText.Items.AddRange(new object[] {
            "Concatenar",
            "Reemplazar",
            "Longitud",
            "Mayusculas",
            "Minusculas",
            "Comparar"});
            this.ComboBoxText.Location = new System.Drawing.Point(428, 316);
            this.ComboBoxText.Name = "ComboBoxText";
            this.ComboBoxText.Size = new System.Drawing.Size(151, 28);
            this.ComboBoxText.TabIndex = 21;
            this.ComboBoxText.Text = "Seleccionar";
            // 
            // Operar
            // 
            this.Operar.BackColor = System.Drawing.Color.OldLace;
            this.Operar.Location = new System.Drawing.Point(428, 360);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(151, 38);
            this.Operar.TabIndex = 22;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = false;
            this.Operar.Click += new System.EventHandler(this.Operar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Digital-7 Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.LawnGreen;
            this.label10.Location = new System.Drawing.Point(204, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(375, 33);
            this.label10.TabIndex = 24;
            this.label10.Text = "La SuperCalculadora 2000";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.ComboBoxText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.OP2);
            this.Controls.Add(this.OP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculadora";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OP1;
        private TextBox OP2;
        private TextBox txtResult;
        private TextBox text1;
        private TextBox text2;
        private TextBox text3;
        private TextBox resultado2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button Calcular;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox ComboBoxText;
        private Button Operar;
        private Label label10;
    }
}