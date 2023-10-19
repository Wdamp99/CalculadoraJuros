namespace CalculadoraJuros
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblValorPrincipal = new Label();
            lblTaxaAnualJuros = new Label();
            lblNumParcelas = new Label();
            txtValorPrincipal = new TextBox();
            txtTaxaAnualJuros = new TextBox();
            txtNumParcelas = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCalcJuros = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblValorPrincipal
            // 
            lblValorPrincipal.AutoSize = true;
            lblValorPrincipal.BackColor = SystemColors.ActiveBorder;
            lblValorPrincipal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorPrincipal.Location = new Point(265, 33);
            lblValorPrincipal.Name = "lblValorPrincipal";
            lblValorPrincipal.Size = new Size(267, 25);
            lblValorPrincipal.TabIndex = 0;
            lblValorPrincipal.Text = "Valor Principal do Empréstimo";
            // 
            // lblTaxaAnualJuros
            // 
            lblTaxaAnualJuros.AutoSize = true;
            lblTaxaAnualJuros.BackColor = SystemColors.ActiveBorder;
            lblTaxaAnualJuros.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaxaAnualJuros.Location = new Point(307, 122);
            lblTaxaAnualJuros.Name = "lblTaxaAnualJuros";
            lblTaxaAnualJuros.Size = new Size(178, 25);
            lblTaxaAnualJuros.TabIndex = 1;
            lblTaxaAnualJuros.Text = "Taxa de Juros Anual";
            // 
            // lblNumParcelas
            // 
            lblNumParcelas.AutoSize = true;
            lblNumParcelas.BackColor = SystemColors.ActiveBorder;
            lblNumParcelas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumParcelas.ForeColor = SystemColors.ControlText;
            lblNumParcelas.Location = new Point(304, 219);
            lblNumParcelas.Name = "lblNumParcelas";
            lblNumParcelas.Size = new Size(181, 25);
            lblNumParcelas.TabIndex = 2;
            lblNumParcelas.Text = "Número de Parcelas";
            // 
            // txtValorPrincipal
            // 
            txtValorPrincipal.Location = new Point(316, 80);
            txtValorPrincipal.Name = "txtValorPrincipal";
            txtValorPrincipal.Size = new Size(155, 23);
            txtValorPrincipal.TabIndex = 3;
            // 
            // txtTaxaAnualJuros
            // 
            txtTaxaAnualJuros.Location = new Point(316, 176);
            txtTaxaAnualJuros.Name = "txtTaxaAnualJuros";
            txtTaxaAnualJuros.Size = new Size(155, 23);
            txtTaxaAnualJuros.TabIndex = 4;
            // 
            // txtNumParcelas
            // 
            txtNumParcelas.Location = new Point(316, 263);
            txtNumParcelas.Name = "txtNumParcelas";
            txtNumParcelas.Size = new Size(157, 23);
            txtNumParcelas.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(554, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 458);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 461);
            panel2.TabIndex = 7;
            // 
            // btnCalcJuros
            // 
            btnCalcJuros.BackColor = SystemColors.ActiveCaption;
            btnCalcJuros.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcJuros.Image = (Image)resources.GetObject("btnCalcJuros.Image");
            btnCalcJuros.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcJuros.Location = new Point(304, 306);
            btnCalcJuros.Name = "btnCalcJuros";
            btnCalcJuros.Size = new Size(177, 44);
            btnCalcJuros.TabIndex = 8;
            btnCalcJuros.Text = "Calcular Juros";
            btnCalcJuros.TextAlign = ContentAlignment.MiddleRight;
            btnCalcJuros.UseVisualStyleBackColor = false;
            btnCalcJuros.Click += btnCalcJuros_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = SystemColors.HotTrack;
            lblResultado.Location = new Point(274, 375);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 21);
            lblResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcJuros);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNumParcelas);
            Controls.Add(txtTaxaAnualJuros);
            Controls.Add(txtValorPrincipal);
            Controls.Add(lblNumParcelas);
            Controls.Add(lblTaxaAnualJuros);
            Controls.Add(lblValorPrincipal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValorPrincipal;
        private Label lblTaxaAnualJuros;
        private Label lblNumParcelas;
        private TextBox txtValorPrincipal;
        private TextBox txtTaxaAnualJuros;
        private TextBox txtNumParcelas;
        private Panel panel1;
        private Panel panel2;
        private Button btnCalcJuros;
        private Label lblResultado;
    }
}