namespace TPI_Cine_Frontend
{
    partial class Principal
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
            menuStrip1 = new MenuStrip();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ticketToolStripMenuItem = new ToolStripMenuItem();
            altaTicketToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            altaClienteToolStripMenuItem = new ToolStripMenuItem();
            consultarClienteToolStripMenuItem = new ToolStripMenuItem();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            altaFuncionesToolStripMenuItem = new ToolStripMenuItem();
            consultaFuncionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, ticketToolStripMenuItem, clienteToolStripMenuItem, funcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(60, 20);
            nuevoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // ticketToolStripMenuItem
            // 
            ticketToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaTicketToolStripMenuItem });
            ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            ticketToolStripMenuItem.Size = new Size(50, 20);
            ticketToolStripMenuItem.Text = "Ticket";
            // 
            // altaTicketToolStripMenuItem
            // 
            altaTicketToolStripMenuItem.Name = "altaTicketToolStripMenuItem";
            altaTicketToolStripMenuItem.Size = new Size(129, 22);
            altaTicketToolStripMenuItem.Text = "Alta Ticket";
            altaTicketToolStripMenuItem.Click += altaTicketToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaClienteToolStripMenuItem, consultarClienteToolStripMenuItem });
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(56, 20);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // altaClienteToolStripMenuItem
            // 
            altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            altaClienteToolStripMenuItem.Size = new Size(180, 22);
            altaClienteToolStripMenuItem.Text = "Alta Cliente";
            altaClienteToolStripMenuItem.Click += altaClienteToolStripMenuItem_Click;
            // 
            // consultarClienteToolStripMenuItem
            // 
            consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            consultarClienteToolStripMenuItem.Size = new Size(180, 22);
            consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            consultarClienteToolStripMenuItem.Click += consultarClienteToolStripMenuItem_Click;
            // 
            // funcionesToolStripMenuItem
            // 
            funcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaFuncionesToolStripMenuItem, consultaFuncionesToolStripMenuItem });
            funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            funcionesToolStripMenuItem.Size = new Size(73, 20);
            funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // altaFuncionesToolStripMenuItem
            // 
            altaFuncionesToolStripMenuItem.Name = "altaFuncionesToolStripMenuItem";
            altaFuncionesToolStripMenuItem.Size = new Size(167, 22);
            altaFuncionesToolStripMenuItem.Text = "Alta Funcion";
            altaFuncionesToolStripMenuItem.Click += altaFuncionesToolStripMenuItem_Click;
            // 
            // consultaFuncionesToolStripMenuItem
            // 
            consultaFuncionesToolStripMenuItem.Name = "consultaFuncionesToolStripMenuItem";
            consultaFuncionesToolStripMenuItem.Size = new Size(167, 22);
            consultaFuncionesToolStripMenuItem.Text = "Consulta Funcion";
            consultaFuncionesToolStripMenuItem.Click += consultaFuncionesToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ticketToolStripMenuItem;
        private ToolStripMenuItem altaTicketToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem altaClienteToolStripMenuItem;
        private ToolStripMenuItem consultarClienteToolStripMenuItem;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem altaFuncionesToolStripMenuItem;
        private ToolStripMenuItem consultaFuncionesToolStripMenuItem;
    }
}