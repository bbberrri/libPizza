namespace WFclsPizza
{
    partial class Menu
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
            menuStrip = new MenuStrip();
            commanderToolStripMenuItem = new ToolStripMenuItem();
            ajouterClientToolStripMenuItem = new ToolStripMenuItem();
            ajouterPizzaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { commanderToolStripMenuItem, ajouterClientToolStripMenuItem, ajouterPizzaToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(543, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // commanderToolStripMenuItem
            // 
            commanderToolStripMenuItem.Name = "commanderToolStripMenuItem";
            commanderToolStripMenuItem.Size = new Size(86, 20);
            commanderToolStripMenuItem.Text = "Commander";
            commanderToolStripMenuItem.Click += commanderToolStripMenuItem_Click;
            // 
            // ajouterClientToolStripMenuItem
            // 
            ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            ajouterClientToolStripMenuItem.Size = new Size(89, 20);
            ajouterClientToolStripMenuItem.Text = "AjouterClient";
            ajouterClientToolStripMenuItem.Click += ajouterClientToolStripMenuItem_Click;
            // 
            // ajouterPizzaToolStripMenuItem
            // 
            ajouterPizzaToolStripMenuItem.Name = "ajouterPizzaToolStripMenuItem";
            ajouterPizzaToolStripMenuItem.Size = new Size(84, 20);
            ajouterPizzaToolStripMenuItem.Text = "AjouterPizza";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 291);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem commanderToolStripMenuItem;
        private ToolStripMenuItem ajouterClientToolStripMenuItem;
        private ToolStripMenuItem ajouterPizzaToolStripMenuItem;
    }
}
