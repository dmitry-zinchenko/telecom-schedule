namespace telecom_schedule
{
    partial class Form1
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
            this.buttonUniform = new System.Windows.Forms.Button();
            this.buttonIrregular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUniform
            // 
            this.buttonUniform.Location = new System.Drawing.Point(59, 51);
            this.buttonUniform.Name = "buttonUniform";
            this.buttonUniform.Size = new System.Drawing.Size(162, 23);
            this.buttonUniform.TabIndex = 0;
            this.buttonUniform.Text = "Равномерное расписание";
            this.buttonUniform.UseVisualStyleBackColor = true;
            this.buttonUniform.Click += new System.EventHandler(this.buttonUniform_Click);
            // 
            // buttonIrregular
            // 
            this.buttonIrregular.Location = new System.Drawing.Point(59, 108);
            this.buttonIrregular.Name = "buttonIrregular";
            this.buttonIrregular.Size = new System.Drawing.Size(162, 23);
            this.buttonIrregular.TabIndex = 0;
            this.buttonIrregular.Text = "Неравномерное расписание";
            this.buttonIrregular.UseVisualStyleBackColor = true;
            this.buttonIrregular.Click += new System.EventHandler(this.buttonIrregular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.buttonIrregular);
            this.Controls.Add(this.buttonUniform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Выберите проект";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUniform;
        private System.Windows.Forms.Button buttonIrregular;
    }
}

