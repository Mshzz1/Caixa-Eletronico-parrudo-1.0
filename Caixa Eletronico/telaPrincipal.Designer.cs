namespace Caixa_Eletronico
{
    partial class telaPrincipal
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
            entrardeposito = new Button();
            VerExtrato = new Button();
            EntarTransferencia = new Button();
            EntrarSaque = new Button();
            voltarFrmInicial = new Button();
            mostrarsaldo = new Label();
            SuspendLayout();
            // 
            // entrardeposito
            // 
            entrardeposito.Location = new Point(257, 106);
            entrardeposito.Name = "entrardeposito";
            entrardeposito.Size = new Size(207, 70);
            entrardeposito.TabIndex = 1;
            entrardeposito.Text = "Depositar";
            entrardeposito.UseVisualStyleBackColor = true;
            entrardeposito.Click += entrardeposito_Click;
            // 
            // VerExtrato
            // 
            VerExtrato.Location = new Point(257, 334);
            VerExtrato.Name = "VerExtrato";
            VerExtrato.Size = new Size(207, 70);
            VerExtrato.TabIndex = 2;
            VerExtrato.Text = "Ver extrato";
            VerExtrato.UseVisualStyleBackColor = true;
            VerExtrato.Click += VerExtrato_Click;
            // 
            // EntarTransferencia
            // 
            EntarTransferencia.Location = new Point(257, 258);
            EntarTransferencia.Name = "EntarTransferencia";
            EntarTransferencia.Size = new Size(207, 70);
            EntarTransferencia.TabIndex = 3;
            EntarTransferencia.Text = "Transferir";
            EntarTransferencia.UseVisualStyleBackColor = true;
            EntarTransferencia.Click += EntarTransferencia_Click;
            // 
            // EntrarSaque
            // 
            EntrarSaque.Location = new Point(257, 182);
            EntrarSaque.Name = "EntrarSaque";
            EntrarSaque.Size = new Size(207, 70);
            EntrarSaque.TabIndex = 4;
            EntrarSaque.Text = "Sacar";
            EntrarSaque.UseVisualStyleBackColor = true;
            EntrarSaque.Click += EntrarSaque_Click;
            // 
            // voltarFrmInicial
            // 
            voltarFrmInicial.Location = new Point(12, 12);
            voltarFrmInicial.Name = "voltarFrmInicial";
            voltarFrmInicial.Size = new Size(141, 33);
            voltarFrmInicial.TabIndex = 5;
            voltarFrmInicial.Text = "Voltar";
            voltarFrmInicial.UseVisualStyleBackColor = true;
            voltarFrmInicial.Click += voltarFrmInicial_Click;
            // 
            // mostrarsaldo
            // 
            mostrarsaldo.AutoSize = true;
            mostrarsaldo.Location = new Point(533, 25);
            mostrarsaldo.Name = "mostrarsaldo";
            mostrarsaldo.Size = new Size(79, 20);
            mostrarsaldo.TabIndex = 6;
            mostrarsaldo.Text = "Valor: 0 R$";
            // 
            // telaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mostrarsaldo);
            Controls.Add(voltarFrmInicial);
            Controls.Add(EntrarSaque);
            Controls.Add(EntarTransferencia);
            Controls.Add(VerExtrato);
            Controls.Add(entrardeposito);
            Name = "telaPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button entrardeposito;
        private Button VerExtrato;
        private Button EntarTransferencia;
        private Button EntrarSaque;
        private Button voltarFrmInicial;
        private Label mostrarsaldo;
    }
}