namespace Caixa_Eletronico
{
    partial class FormDepositos
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
            ValorDeposito = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            FazerDeposito = new Button();
            ((System.ComponentModel.ISupportInitialize)ValorDeposito).BeginInit();
            SuspendLayout();
            // 
            // ValorDeposito
            // 
            ValorDeposito.Location = new Point(290, 173);
            ValorDeposito.Name = "ValorDeposito";
            ValorDeposito.Size = new Size(274, 27);
            ValorDeposito.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 175);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 33);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Depositos";
            // 
            // FazerDeposito
            // 
            FazerDeposito.Location = new Point(358, 282);
            FazerDeposito.Name = "FazerDeposito";
            FazerDeposito.Size = new Size(94, 29);
            FazerDeposito.TabIndex = 3;
            FazerDeposito.Text = "Realizar";
            FazerDeposito.UseVisualStyleBackColor = true;
            // 
            // depositos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FazerDeposito);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ValorDeposito);
            Name = "depositos";
            Text = "depositos";
            ((System.ComponentModel.ISupportInitialize)ValorDeposito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown ValorDeposito;
        private Label label1;
        private Label label2;
        private Button FazerDeposito;
    }
}