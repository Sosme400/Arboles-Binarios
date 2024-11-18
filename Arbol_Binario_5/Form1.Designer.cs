namespace ArbolBinarioApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnInorden;
        private System.Windows.Forms.Button btnPostorden;
        private System.Windows.Forms.TextBox textBoxResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnInorden = new System.Windows.Forms.Button();
            this.btnPostorden = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(20, 20);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultado.Size = new System.Drawing.Size(460, 100);
            this.textBoxResultado.TabIndex = 4;

            // 
            // btnAmplitud
            // 
            this.btnAmplitud.BackColor = System.Drawing.Color.LightBlue;
            this.btnAmplitud.Location = new System.Drawing.Point(20, 140);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(100, 40);
            this.btnAmplitud.TabIndex = 0;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = false;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);

            // 
            // btnPreorden
            // 
            this.btnPreorden.BackColor = System.Drawing.Color.LightGreen;
            this.btnPreorden.Location = new System.Drawing.Point(130, 140);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(100, 40);
            this.btnPreorden.TabIndex = 1;
            this.btnPreorden.Text = "Preorden";
            this.btnPreorden.UseVisualStyleBackColor = false;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);

            // 
            // btnInorden
            // 
            this.btnInorden.BackColor = System.Drawing.Color.LightCoral;
            this.btnInorden.Location = new System.Drawing.Point(240, 140);
            this.btnInorden.Name = "btnInorden";
            this.btnInorden.Size = new System.Drawing.Size(100, 40);
            this.btnInorden.TabIndex = 2;
            this.btnInorden.Text = "Inorden";
            this.btnInorden.UseVisualStyleBackColor = false;
            this.btnInorden.Click += new System.EventHandler(this.btnInorden_Click);

            // 
            // btnPostorden
            // 
            this.btnPostorden.BackColor = System.Drawing.Color.Khaki;
            this.btnPostorden.Location = new System.Drawing.Point(350, 140);
            this.btnPostorden.Name = "btnPostorden";
            this.btnPostorden.Size = new System.Drawing.Size(100, 40);
            this.btnPostorden.TabIndex = 3;
            this.btnPostorden.Text = "Postorden";
            this.btnPostorden.UseVisualStyleBackColor = false;
            this.btnPostorden.Click += new System.EventHandler(this.btnPostorden_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.btnPostorden);
            this.Controls.Add(this.btnInorden);
            this.Controls.Add(this.btnPreorden);
            this.Controls.Add(this.btnAmplitud);
            this.Name = "Form1";
            this.Text = "Árbol Binario - Recorridos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
