namespace PryFrancosp1Ejercicio
{
    partial class frmBIENVENIDO
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblSintepart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInicio.Location = new System.Drawing.Point(317, 223);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(170, 104);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "&INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSintepart
            // 
            this.lblSintepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSintepart.AutoSize = true;
            this.lblSintepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepart.ForeColor = System.Drawing.Color.Black;
            this.lblSintepart.Location = new System.Drawing.Point(103, 61);
            this.lblSintepart.Name = "lblSintepart";
            this.lblSintepart.Size = new System.Drawing.Size(631, 42);
            this.lblSintepart.TabIndex = 1;
            this.lblSintepart.Text = "BIENVENIDO A SINTEPART S.R.L";
            this.lblSintepart.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBIENVENIDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSintepart);
            this.Controls.Add(this.btnInicio);
            this.Name = "frmBIENVENIDO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIENVENIDO  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblSintepart;
    }
}