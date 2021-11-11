namespace Despertador
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.selectorHora = new System.Windows.Forms.DateTimePicker();
            this.textoStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(268, 66);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(94, 29);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(424, 66);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(94, 29);
            this.btnPausar.TabIndex = 1;
            this.btnPausar.Text = "PAUSAR";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // selectorHora
            // 
            this.selectorHora.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.selectorHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.selectorHora.Location = new System.Drawing.Point(268, 120);
            this.selectorHora.Name = "selectorHora";
            this.selectorHora.Size = new System.Drawing.Size(250, 27);
            this.selectorHora.TabIndex = 2;
            // 
            // textoStatus
            // 
            this.textoStatus.AutoSize = true;
            this.textoStatus.BackColor = System.Drawing.Color.Black;
            this.textoStatus.ForeColor = System.Drawing.Color.White;
            this.textoStatus.Location = new System.Drawing.Point(366, 186);
            this.textoStatus.Name = "textoStatus";
            this.textoStatus.Size = new System.Drawing.Size(41, 20);
            this.textoStatus.TabIndex = 3;
            this.textoStatus.Text = "        ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textoStatus);
            this.Controls.Add(this.selectorHora);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIniciar;
        private Button btnPausar;
        private DateTimePicker selectorHora;
        private Label textoStatus;
    }
}