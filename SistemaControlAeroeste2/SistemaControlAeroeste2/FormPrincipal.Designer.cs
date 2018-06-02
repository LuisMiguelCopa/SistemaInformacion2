namespace SistemaControlAeroeste2
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMarcaModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarRegistroAeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarAeronaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarResponsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarOMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEstacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarSolicitudDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA DE CONTROL DE SERVICIO DE AERONAVE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aeronaveToolStripMenuItem,
            this.recursosHumanosToolStripMenuItem,
            this.oMAToolStripMenuItem,
            this.servicioToolStripMenuItem,
            this.controlDeServicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aeronaveToolStripMenuItem
            // 
            this.aeronaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarMarcaToolStripMenuItem,
            this.gestionarModeloToolStripMenuItem,
            this.gestionarMarcaModeloToolStripMenuItem,
            this.gestionarRegistroAeronaveToolStripMenuItem,
            this.gestionarAeronaveToolStripMenuItem});
            this.aeronaveToolStripMenuItem.Name = "aeronaveToolStripMenuItem";
            this.aeronaveToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aeronaveToolStripMenuItem.Text = "Aeronave";
            // 
            // gestionarMarcaToolStripMenuItem
            // 
            this.gestionarMarcaToolStripMenuItem.Name = "gestionarMarcaToolStripMenuItem";
            this.gestionarMarcaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gestionarMarcaToolStripMenuItem.Text = "Gestionar Marca";
            this.gestionarMarcaToolStripMenuItem.Click += new System.EventHandler(this.gestionarMarcaToolStripMenuItem_Click);
            // 
            // gestionarModeloToolStripMenuItem
            // 
            this.gestionarModeloToolStripMenuItem.Name = "gestionarModeloToolStripMenuItem";
            this.gestionarModeloToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gestionarModeloToolStripMenuItem.Text = "Gestionar Modelo";
            this.gestionarModeloToolStripMenuItem.Click += new System.EventHandler(this.gestionarModeloToolStripMenuItem_Click);
            // 
            // gestionarMarcaModeloToolStripMenuItem
            // 
            this.gestionarMarcaModeloToolStripMenuItem.Name = "gestionarMarcaModeloToolStripMenuItem";
            this.gestionarMarcaModeloToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gestionarMarcaModeloToolStripMenuItem.Text = "Gestionar Marca Modelo";
            this.gestionarMarcaModeloToolStripMenuItem.Click += new System.EventHandler(this.gestionarMarcaModeloToolStripMenuItem_Click);
            // 
            // gestionarRegistroAeronaveToolStripMenuItem
            // 
            this.gestionarRegistroAeronaveToolStripMenuItem.Name = "gestionarRegistroAeronaveToolStripMenuItem";
            this.gestionarRegistroAeronaveToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gestionarRegistroAeronaveToolStripMenuItem.Text = "Gestionar Registro Aeronave";
            this.gestionarRegistroAeronaveToolStripMenuItem.Click += new System.EventHandler(this.gestionarRegistroAeronaveToolStripMenuItem_Click);
            // 
            // gestionarAeronaveToolStripMenuItem
            // 
            this.gestionarAeronaveToolStripMenuItem.Name = "gestionarAeronaveToolStripMenuItem";
            this.gestionarAeronaveToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gestionarAeronaveToolStripMenuItem.Text = "Gestionar Aeronave";
            this.gestionarAeronaveToolStripMenuItem.Click += new System.EventHandler(this.gestionarAeronaveToolStripMenuItem_Click);
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPersonaToolStripMenuItem,
            this.gestionarDepartamentoToolStripMenuItem,
            this.gestionarTrabajadorToolStripMenuItem});
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            // 
            // gestionarPersonaToolStripMenuItem
            // 
            this.gestionarPersonaToolStripMenuItem.Name = "gestionarPersonaToolStripMenuItem";
            this.gestionarPersonaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionarPersonaToolStripMenuItem.Text = "Gestionar Persona";
            // 
            // gestionarDepartamentoToolStripMenuItem
            // 
            this.gestionarDepartamentoToolStripMenuItem.Name = "gestionarDepartamentoToolStripMenuItem";
            this.gestionarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionarDepartamentoToolStripMenuItem.Text = "Gestionar Departamento";
            // 
            // gestionarTrabajadorToolStripMenuItem
            // 
            this.gestionarTrabajadorToolStripMenuItem.Name = "gestionarTrabajadorToolStripMenuItem";
            this.gestionarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gestionarTrabajadorToolStripMenuItem.Text = "Gestionar Trabajador";
            // 
            // oMAToolStripMenuItem
            // 
            this.oMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarResponsableToolStripMenuItem,
            this.gestionarOMAToolStripMenuItem});
            this.oMAToolStripMenuItem.Name = "oMAToolStripMenuItem";
            this.oMAToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.oMAToolStripMenuItem.Text = "OMA";
            // 
            // gestionarResponsableToolStripMenuItem
            // 
            this.gestionarResponsableToolStripMenuItem.Name = "gestionarResponsableToolStripMenuItem";
            this.gestionarResponsableToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.gestionarResponsableToolStripMenuItem.Text = "Gestionar Responsable";
            // 
            // gestionarOMAToolStripMenuItem
            // 
            this.gestionarOMAToolStripMenuItem.Name = "gestionarOMAToolStripMenuItem";
            this.gestionarOMAToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.gestionarOMAToolStripMenuItem.Text = "Gestionar OMA";
            // 
            // servicioToolStripMenuItem
            // 
            this.servicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarServicioToolStripMenuItem,
            this.gestionarEstacionToolStripMenuItem1});
            this.servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            this.servicioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.servicioToolStripMenuItem.Text = "Servicio";
            // 
            // gestionarServicioToolStripMenuItem
            // 
            this.gestionarServicioToolStripMenuItem.Name = "gestionarServicioToolStripMenuItem";
            this.gestionarServicioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gestionarServicioToolStripMenuItem.Text = "Gestionar Servicio";
            // 
            // gestionarEstacionToolStripMenuItem1
            // 
            this.gestionarEstacionToolStripMenuItem1.Name = "gestionarEstacionToolStripMenuItem1";
            this.gestionarEstacionToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.gestionarEstacionToolStripMenuItem1.Text = "Gestionar Estacion";
            // 
            // controlDeServicioToolStripMenuItem
            // 
            this.controlDeServicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarSolicitudDeServicioToolStripMenuItem});
            this.controlDeServicioToolStripMenuItem.Name = "controlDeServicioToolStripMenuItem";
            this.controlDeServicioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlDeServicioToolStripMenuItem.Text = "Control";
            // 
            // gestionarSolicitudDeServicioToolStripMenuItem
            // 
            this.gestionarSolicitudDeServicioToolStripMenuItem.Name = "gestionarSolicitudDeServicioToolStripMenuItem";
            this.gestionarSolicitudDeServicioToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gestionarSolicitudDeServicioToolStripMenuItem.Text = "Gestionar Solicitud de Servicio";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 512);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMarcaModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarRegistroAeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarAeronaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarResponsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarOMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEstacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controlDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarSolicitudDeServicioToolStripMenuItem;
    }
}

