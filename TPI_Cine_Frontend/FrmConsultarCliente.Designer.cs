namespace TPI_Cine_Frontend
{
    partial class FrmConsultarCliente
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
            gpClientConsult = new GroupBox();
            lblFechaIngreso = new Label();
            dtpDesde = new DateTimePicker();
            gpClientConsult.SuspendLayout();
            SuspendLayout();
            // 
            // gpClientConsult
            // 
            gpClientConsult.BackColor = SystemColors.ControlDark;
            gpClientConsult.Controls.Add(lblFechaIngreso);
            gpClientConsult.Controls.Add(dtpDesde);
            gpClientConsult.Location = new Point(3, 6);
            gpClientConsult.Name = "gpClientConsult";
            gpClientConsult.Size = new Size(785, 198);
            gpClientConsult.TabIndex = 0;
            gpClientConsult.TabStop = false;
            gpClientConsult.Text = "Filtros de busqueda";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(9, 44);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(80, 15);
            lblFechaIngreso.TabIndex = 3;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(119, 38);
            dtpDesde.Margin = new Padding(4, 3, 4, 3);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(156, 23);
            dtpDesde.TabIndex = 2;
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(gpClientConsult);
            Name = "FrmConsultarCliente";
            Text = "FrmConsultarCliente";
            Load += FrmConsultarCliente_Load;
            gpClientConsult.ResumeLayout(false);
            gpClientConsult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpClientConsult;
        private Label lblFechaIngreso;
        private DateTimePicker dtpDesde;
    }
}