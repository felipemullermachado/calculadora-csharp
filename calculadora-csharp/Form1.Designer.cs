﻿
namespace calculadora_csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultipli = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(253, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(254, 157);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(66, 58);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(326, 157);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(66, 58);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(398, 157);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(66, 58);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(253, 221);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(66, 58);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(326, 221);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(66, 58);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(398, 221);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(66, 58);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(253, 285);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(66, 58);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(326, 285);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(66, 58);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(398, 285);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 58);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(253, 349);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(66, 58);
            this.btnVirgula.TabIndex = 10;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(326, 349);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(66, 58);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(398, 349);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(66, 58);
            this.btnIgual.TabIndex = 12;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(470, 157);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(66, 58);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultipli
            // 
            this.btnMultipli.Location = new System.Drawing.Point(470, 221);
            this.btnMultipli.Name = "btnMultipli";
            this.btnMultipli.Size = new System.Drawing.Size(66, 58);
            this.btnMultipli.TabIndex = 14;
            this.btnMultipli.Text = "X";
            this.btnMultipli.UseVisualStyleBackColor = true;
            this.btnMultipli.Click += new System.EventHandler(this.btnMultipli_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(470, 285);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(66, 58);
            this.btnMenos.TabIndex = 15;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(470, 349);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(66, 58);
            this.btnMais.TabIndex = 16;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(542, 157);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(66, 58);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMultipli);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultipli;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnLimpar;
    }
}

