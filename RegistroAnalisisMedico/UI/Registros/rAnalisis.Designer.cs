namespace RegistroAnalisisMedico.UI.Registros
{
    partial class rAnalisis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnalisisIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UsuarioIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.AnalisisIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AnalisisId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UsuarioId";
            // 
            // AnalisisIdnumericUpDown
            // 
            this.AnalisisIdnumericUpDown.Location = new System.Drawing.Point(83, 28);
            this.AnalisisIdnumericUpDown.Name = "AnalisisIdnumericUpDown";
            this.AnalisisIdnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.AnalisisIdnumericUpDown.TabIndex = 3;
            // 
            // UsuarioIdnumericUpDown
            // 
            this.UsuarioIdnumericUpDown.Location = new System.Drawing.Point(83, 93);
            this.UsuarioIdnumericUpDown.Name = "UsuarioIdnumericUpDown";
            this.UsuarioIdnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.UsuarioIdnumericUpDown.TabIndex = 4;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(83, 60);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(88, 20);
            this.FechadateTimePicker.TabIndex = 5;
            // 
            // rAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 209);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.UsuarioIdnumericUpDown);
            this.Controls.Add(this.AnalisisIdnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rAnalisis";
            this.Text = "rAnalisis";
            ((System.ComponentModel.ISupportInitialize)(this.AnalisisIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AnalisisIdnumericUpDown;
        private System.Windows.Forms.NumericUpDown UsuarioIdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
    }
}