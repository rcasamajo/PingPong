namespace PingPong
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fitxerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firebasedatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escripturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firebaseDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitxerToolStripMenuItem,
            this.escripturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fitxerToolStripMenuItem
            // 
            this.fitxerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.firebasedatabaseToolStripMenuItem});
            this.fitxerToolStripMenuItem.Name = "fitxerToolStripMenuItem";
            this.fitxerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fitxerToolStripMenuItem.Text = "Lectura";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.testToolStripMenuItem.Text = "DataContractJsonSerializer";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // firebasedatabaseToolStripMenuItem
            // 
            this.firebasedatabaseToolStripMenuItem.Name = "firebasedatabaseToolStripMenuItem";
            this.firebasedatabaseToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.firebasedatabaseToolStripMenuItem.Text = "FirebaseDatabase";
            this.firebasedatabaseToolStripMenuItem.Click += new System.EventHandler(this.firebasedatabaseToolStripMenuItem_Click);
            // 
            // escripturaToolStripMenuItem
            // 
            this.escripturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firebaseDatabaseToolStripMenuItem1});
            this.escripturaToolStripMenuItem.Name = "escripturaToolStripMenuItem";
            this.escripturaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.escripturaToolStripMenuItem.Text = "Escriptura";
            // 
            // firebaseDatabaseToolStripMenuItem1
            // 
            this.firebaseDatabaseToolStripMenuItem1.Name = "firebaseDatabaseToolStripMenuItem1";
            this.firebaseDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.firebaseDatabaseToolStripMenuItem1.Text = "FirebaseDatabase";
            this.firebaseDatabaseToolStripMenuItem1.Click += new System.EventHandler(this.firebaseDatabaseToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 343);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ping-Pong Poblenou";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fitxerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firebasedatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escripturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firebaseDatabaseToolStripMenuItem1;
    }
}

