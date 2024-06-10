namespace Caixa_Eletronico
{
    partial class Transferir
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
            valortransferir = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btTransferir = new Button();
            destinotransferir = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)valortransferir).BeginInit();
            SuspendLayout();
            // 
            // valortransferir
            // 
            valortransferir.Location = new Point(327, 178);
            valortransferir.Name = "valortransferir";
            valortransferir.Size = new Size(150, 27);
            valortransferir.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 185);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Transferir";
            // 
            // btTransferir
            // 
            btTransferir.Location = new Point(327, 314);
            btTransferir.Name = "btTransferir";
            btTransferir.Size = new Size(150, 29);
            btTransferir.TabIndex = 3;
            btTransferir.Text = "Realizar";
            btTransferir.UseVisualStyleBackColor = true;
            // 
            // destinotransferir
            // 
            destinotransferir.Location = new Point(327, 231);
            destinotransferir.Name = "destinotransferir";
            destinotransferir.Size = new Size(150, 27);
            destinotransferir.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 234);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Destinatário";
            // 
            // Transferir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(destinotransferir);
            Controls.Add(btTransferir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(valortransferir);
            Name = "Transferir";
            Text = "Transferir";
            ((System.ComponentModel.ISupportInitialize)valortransferir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown valortransferir;
        private Label label1;
        private Label label2;
        private Button btTransferir;
        private TextBox destinotransferir;
        private Label label3;
    }
}