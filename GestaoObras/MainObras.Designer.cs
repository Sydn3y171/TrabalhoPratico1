namespace GestaoObras
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            monthCalendar1 = new MonthCalendar();
            toolStrip1 = new ToolStrip();
            ClientesButton = new ToolStripButton();
            DocumentosButton = new ToolStripButton();
            ObrasButton = new ToolStripButton();
            Armazem = new ToolStripButton();
            FuncionariosButton = new ToolStripButton();
            panel1 = new Panel();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.WindowFrame;
            monthCalendar1.ForeColor = SystemColors.WindowFrame;
            monthCalendar1.Location = new Point(885, 36);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ClientesButton, DocumentosButton, ObrasButton, Armazem, FuncionariosButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1172, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // ClientesButton
            // 
            ClientesButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ClientesButton.Image = (Image)resources.GetObject("ClientesButton.Image");
            ClientesButton.ImageTransparentColor = Color.Magenta;
            ClientesButton.Name = "ClientesButton";
            ClientesButton.Size = new Size(29, 24);
            ClientesButton.Text = "Clientes";
            ClientesButton.Click += ClientesButton_Click;
            // 
            // DocumentosButton
            // 
            DocumentosButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DocumentosButton.Image = (Image)resources.GetObject("DocumentosButton.Image");
            DocumentosButton.ImageTransparentColor = Color.Magenta;
            DocumentosButton.Name = "DocumentosButton";
            DocumentosButton.Size = new Size(29, 24);
            DocumentosButton.Text = "Documentos";
            DocumentosButton.ToolTipText = "Documentos";
            // 
            // ObrasButton
            // 
            ObrasButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ObrasButton.Image = (Image)resources.GetObject("ObrasButton.Image");
            ObrasButton.ImageTransparentColor = Color.Magenta;
            ObrasButton.Name = "ObrasButton";
            ObrasButton.Size = new Size(29, 24);
            ObrasButton.Text = "Obras";
            // 
            // Armazem
            // 
            Armazem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Armazem.Image = (Image)resources.GetObject("Armazem.Image");
            Armazem.ImageTransparentColor = Color.Magenta;
            Armazem.Name = "Armazem";
            Armazem.Size = new Size(29, 24);
            Armazem.Text = "Armazem";
            // 
            // FuncionariosButton
            // 
            FuncionariosButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FuncionariosButton.Image = (Image)resources.GetObject("FuncionariosButton.Image");
            FuncionariosButton.ImageTransparentColor = Color.Magenta;
            FuncionariosButton.Name = "FuncionariosButton";
            FuncionariosButton.Size = new Size(29, 24);
            FuncionariosButton.Text = "Funcionarios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 481);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 36);
            label1.Name = "label1";
            label1.Size = new Size(234, 34);
            label1.TabIndex = 0;
            label1.Text = "Obras em Curso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1172, 641);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(monthCalendar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Constructly";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ToolStrip toolStrip1;
        private ToolStripButton ClientesButton;
        private ToolStripButton DocumentosButton;
        private ToolStripButton ObrasButton;
        private ToolStripButton Armazem;
        private Panel panel1;
        private Label label1;
        private ToolStripButton FuncionariosButton;
    }
}
