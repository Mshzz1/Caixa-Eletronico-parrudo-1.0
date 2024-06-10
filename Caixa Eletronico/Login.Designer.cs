
namespace Caixa_Eletronico
{
    partial class Login
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
            label1 = new Label();
            BTBuscar = new Button();
            InserirConta = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 200);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Conta:";
            // 
            // BTBuscar
            // 
            BTBuscar.Location = new Point(319, 278);
            BTBuscar.Name = "BTBuscar";
            BTBuscar.Size = new Size(94, 29);
            BTBuscar.TabIndex = 1;
            BTBuscar.Text = "Buscar";
            BTBuscar.UseVisualStyleBackColor = true;
            BTBuscar.Click += BTBuscar_Click;
            // 
            // InserirConta
            // 
            InserirConta.Location = new Point(268, 200);
            InserirConta.Name = "InserirConta";
            InserirConta.Size = new Size(212, 27);
            InserirConta.TabIndex = 2;
            InserirConta.TextChanged += InserirConta_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InserirConta);
            Controls.Add(BTBuscar);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BTBuscar;
        private TextBox InserirConta;
    }
}