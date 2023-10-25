namespace VISTA
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
            txtNombreGrupo = new TextBox();
            txtDescGrupo = new TextBox();
            cbHabilitado = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btnAgregarGrupo = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreGrupo
            // 
            txtNombreGrupo.Location = new Point(88, 41);
            txtNombreGrupo.Name = "txtNombreGrupo";
            txtNombreGrupo.Size = new Size(100, 23);
            txtNombreGrupo.TabIndex = 0;
            // 
            // txtDescGrupo
            // 
            txtDescGrupo.Location = new Point(88, 79);
            txtDescGrupo.Name = "txtDescGrupo";
            txtDescGrupo.Size = new Size(100, 23);
            txtDescGrupo.TabIndex = 1;
            // 
            // cbHabilitado
            // 
            cbHabilitado.AutoSize = true;
            cbHabilitado.Location = new Point(88, 116);
            cbHabilitado.Name = "cbHabilitado";
            cbHabilitado.Size = new Size(108, 19);
            cbHabilitado.TabIndex = 2;
            cbHabilitado.Text = "Esta habilitado?";
            cbHabilitado.UseVisualStyleBackColor = true;
            cbHabilitado.CheckedChanged += cbHabilitado_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 82);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // btnAgregarGrupo
            // 
            btnAgregarGrupo.Location = new Point(57, 150);
            btnAgregarGrupo.Name = "btnAgregarGrupo";
            btnAgregarGrupo.Size = new Size(75, 23);
            btnAgregarGrupo.TabIndex = 5;
            btnAgregarGrupo.Text = "Agregar";
            btnAgregarGrupo.UseVisualStyleBackColor = true;
            btnAgregarGrupo.Click += btnAgregarGrupo_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregarGrupo);
            groupBox1.Controls.Add(txtNombreGrupo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescGrupo);
            groupBox1.Controls.Add(cbHabilitado);
            groupBox1.Location = new Point(22, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 202);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grupo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreGrupo;
        private TextBox txtDescGrupo;
        private CheckBox cbHabilitado;
        private Label label1;
        private Label label2;
        private Button btnAgregarGrupo;
        private GroupBox groupBox1;
    }
}