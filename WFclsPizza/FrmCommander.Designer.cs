namespace WFclsPizza
{
    partial class FrmCommander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommander));
            lstCommClt = new ListBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            btnEffacer = new Button();
            lblMtPizza = new Label();
            grbClients = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPrenom = new TextBox();
            txtTel = new TextBox();
            txtCp = new TextBox();
            txtVille = new TextBox();
            txtAdresse = new TextBox();
            cmbNom = new ComboBox();
            chkEmporter = new CheckBox();
            groupBox1 = new GroupBox();
            btnCommander = new Button();
            label7 = new Label();
            label8 = new Label();
            toolStrip1.SuspendLayout();
            grbClients.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstCommClt
            // 
            lstCommClt.FormattingEnabled = true;
            lstCommClt.ItemHeight = 15;
            lstCommClt.Location = new Point(0, 28);
            lstCommClt.Name = "lstCommClt";
            lstCommClt.Size = new Size(108, 199);
            lstCommClt.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(541, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(0, 262);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(80, 28);
            btnEffacer.TabIndex = 3;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // lblMtPizza
            // 
            lblMtPizza.AutoSize = true;
            lblMtPizza.Location = new Point(42, 230);
            lblMtPizza.Name = "lblMtPizza";
            lblMtPizza.Size = new Size(13, 15);
            lblMtPizza.TabIndex = 4;
            lblMtPizza.Text = "0";
            // 
            // grbClients
            // 
            grbClients.Controls.Add(chkEmporter);
            grbClients.Controls.Add(cmbNom);
            grbClients.Controls.Add(txtAdresse);
            grbClients.Controls.Add(txtVille);
            grbClients.Controls.Add(txtCp);
            grbClients.Controls.Add(txtTel);
            grbClients.Controls.Add(txtPrenom);
            grbClients.Controls.Add(label6);
            grbClients.Controls.Add(label5);
            grbClients.Controls.Add(label4);
            grbClients.Controls.Add(label3);
            grbClients.Controls.Add(label2);
            grbClients.Controls.Add(label1);
            grbClients.Location = new Point(152, 28);
            grbClients.Name = "grbClients";
            grbClients.Size = new Size(324, 135);
            grbClients.TabIndex = 5;
            grbClients.TabStop = false;
            grbClients.Text = "Client";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 51);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Télépone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 19);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Adresse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 51);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Code Postal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 86);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 5;
            label6.Text = "Ville";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(70, 48);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(80, 23);
            txtPrenom.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(70, 83);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(80, 23);
            txtTel.TabIndex = 7;
            // 
            // txtCp
            // 
            txtCp.Location = new Point(238, 51);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(80, 23);
            txtCp.TabIndex = 8;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(238, 86);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(80, 23);
            txtVille.TabIndex = 9;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(238, 16);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(80, 23);
            txtAdresse.TabIndex = 10;
            // 
            // cmbNom
            // 
            cmbNom.FormattingEnabled = true;
            cmbNom.Location = new Point(68, 16);
            cmbNom.Name = "cmbNom";
            cmbNom.Size = new Size(91, 23);
            cmbNom.TabIndex = 11;
            // 
            // chkEmporter
            // 
            chkEmporter.AutoSize = true;
            chkEmporter.Location = new Point(25, 116);
            chkEmporter.Name = "chkEmporter";
            chkEmporter.Size = new Size(86, 19);
            chkEmporter.TabIndex = 12;
            chkEmporter.Text = "À emporter";
            chkEmporter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(152, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 96);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCommander
            // 
            btnCommander.Location = new Point(152, 271);
            btnCommander.Name = "btnCommander";
            btnCommander.Size = new Size(324, 30);
            btnCommander.TabIndex = 7;
            btnCommander.Text = "Commander";
            btnCommander.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 19);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 0;
            label7.Text = "Pizza";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 19);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 1;
            label8.Text = "Quantité";
            // 
            // FrmCommander
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 302);
            Controls.Add(btnCommander);
            Controls.Add(groupBox1);
            Controls.Add(grbClients);
            Controls.Add(lblMtPizza);
            Controls.Add(btnEffacer);
            Controls.Add(toolStrip1);
            Controls.Add(lstCommClt);
            Name = "FrmCommander";
            Text = "FrmCommander";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            grbClients.ResumeLayout(false);
            grbClients.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCommClt;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Button btnEffacer;
        private Label lblMtPizza;
        private GroupBox grbClients;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbNom;
        private TextBox txtAdresse;
        private TextBox txtVille;
        private TextBox txtCp;
        private TextBox txtTel;
        private TextBox txtPrenom;
        private CheckBox chkEmporter;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Button btnCommander;
    }
}