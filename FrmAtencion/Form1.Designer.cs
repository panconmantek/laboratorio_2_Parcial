namespace FrmAtencion
{
    partial class FrmAtencion
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
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            btnAtender = new Button();
            btnSalir = new Button();
            lblMedicos = new Label();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 27);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(299, 214);
            lstMedicos.TabIndex = 0;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(348, 27);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(299, 214);
            lstPacientes.TabIndex = 1;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 260);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(635, 178);
            rtbInfoMedico.TabIndex = 2;
            rtbInfoMedico.Text = "";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(667, 12);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(204, 78);
            btnAtender.TabIndex = 4;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(667, 360);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(204, 78);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 6);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 6;
            lblMedicos.Text = "Personal Medico";
            lblMedicos.Click += label1_Click;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(348, 6);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 7;
            lblPacientes.Text = "Pacientes";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "FrmAtencion";
            Text = "Micaela Paz Acuna";
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
        private Button btnAtender;
        private Button btnSalir;
        private Label lblMedicos;
        private Label lblPacientes;
    }
}
