namespace WFclsPizza
{
    partial class FrmAjouterClient
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNom = new TextBox();
            txtAdresse = new TextBox();
            txtPrenom = new TextBox();
            txtCp = new TextBox();
            txtTel = new TextBox();
            txtVille = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 23);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 125);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Adresse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 174);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Code Postal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 222);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "Ville";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 266);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Télépone";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(149, 20);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 6;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(149, 122);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(100, 23);
            txtAdresse.TabIndex = 7;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(149, 71);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(100, 23);
            txtPrenom.TabIndex = 8;
            // 
            // txtCp
            // 
            txtCp.Location = new Point(149, 171);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(100, 23);
            txtCp.TabIndex = 9;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(149, 263);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 10;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(149, 219);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(100, 23);
            txtVille.TabIndex = 11;
            // 
            // button
            // 
            button.Location = new Point(149, 308);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 12;
            button.Text = "Valider";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click_1;
            // 
            // FrmAjouterClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 352);
            Controls.Add(button);
            Controls.Add(txtVille);
            Controls.Add(txtTel);
            Controls.Add(txtCp);
            Controls.Add(txtPrenom);
            Controls.Add(txtAdresse);
            Controls.Add(txtNom);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAjouterClient";
            Text = "AjouterClient";
            Load += FrmAjouterClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNom;
        private TextBox txtAdresse;
        private TextBox txtPrenom;
        private TextBox txtCp;
        private TextBox txtTel;
        private TextBox txtVille;
        private Button button;
    }
}