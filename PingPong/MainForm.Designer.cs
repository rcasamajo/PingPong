﻿namespace PingPong
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
            this.llegirRESTMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostrarJugadorsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escripturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertFDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMissatge = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitxerToolStripMenuItem,
            this.escripturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fitxerToolStripMenuItem
            // 
            this.fitxerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.llegirRESTMenuItem,
            this.MostrarJugadorsMenuItem});
            this.fitxerToolStripMenuItem.Name = "fitxerToolStripMenuItem";
            this.fitxerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fitxerToolStripMenuItem.Text = "Lectura";
            // 
            // llegirRESTMenuItem
            // 
            this.llegirRESTMenuItem.Name = "llegirRESTMenuItem";
            this.llegirRESTMenuItem.Size = new System.Drawing.Size(164, 22);
            this.llegirRESTMenuItem.Text = "Petició REST";
            this.llegirRESTMenuItem.Click += new System.EventHandler(this.llegirRESTMenuItem_Click);
            // 
            // MostrarJugadorsMenuItem
            // 
            this.MostrarJugadorsMenuItem.Name = "MostrarJugadorsMenuItem";
            this.MostrarJugadorsMenuItem.Size = new System.Drawing.Size(164, 22);
            this.MostrarJugadorsMenuItem.Text = "Mostrar jugadors";
            this.MostrarJugadorsMenuItem.Click += new System.EventHandler(this.MostrarJugadorsMenuItem_Click);
            // 
            // escripturaToolStripMenuItem
            // 
            this.escripturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertFDMenuItem,
            this.modificarFDMenuItem,
            this.eliminarFDMenuItem});
            this.escripturaToolStripMenuItem.Name = "escripturaToolStripMenuItem";
            this.escripturaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.escripturaToolStripMenuItem.Text = "Escriptura";
            // 
            // insertFDMenuItem
            // 
            this.insertFDMenuItem.Name = "insertFDMenuItem";
            this.insertFDMenuItem.Size = new System.Drawing.Size(125, 22);
            this.insertFDMenuItem.Text = "Insert";
            this.insertFDMenuItem.Click += new System.EventHandler(this.insertFDMenuItem_Click);
            // 
            // modificarFDMenuItem
            // 
            this.modificarFDMenuItem.Name = "modificarFDMenuItem";
            this.modificarFDMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarFDMenuItem.Text = "Modificar";
            this.modificarFDMenuItem.Click += new System.EventHandler(this.modificarFDMenuItem_Click);
            // 
            // eliminarFDMenuItem
            // 
            this.eliminarFDMenuItem.Name = "eliminarFDMenuItem";
            this.eliminarFDMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarFDMenuItem.Text = "Eliminar";
            this.eliminarFDMenuItem.Click += new System.EventHandler(this.eliminarFDMenuItem_Click);
            // 
            // tbMissatge
            // 
            this.tbMissatge.AcceptsReturn = true;
            this.tbMissatge.AcceptsTab = true;
            this.tbMissatge.AllowDrop = true;
            this.tbMissatge.Enabled = false;
            this.tbMissatge.Location = new System.Drawing.Point(12, 99);
            this.tbMissatge.Multiline = true;
            this.tbMissatge.Name = "tbMissatge";
            this.tbMissatge.ReadOnly = true;
            this.tbMissatge.Size = new System.Drawing.Size(431, 309);
            this.tbMissatge.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbMissatge);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ping-Pong Poblenou";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fitxerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llegirRESTMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MostrarJugadorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escripturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertFDMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFDMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFDMenuItem;
        private System.Windows.Forms.TextBox tbMissatge;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

