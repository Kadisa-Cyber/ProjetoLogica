namespace frm_maiormenos
{
    partial class frm_menu
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
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Image = global::frm_maiormenos.Properties.Resources.vitoria;
            this.btn3.Location = new System.Drawing.Point(547, 166);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(203, 102);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Atividade 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Image = global::frm_maiormenos.Properties.Resources.peso;
            this.btn2.Location = new System.Drawing.Point(297, 166);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(203, 102);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Atividade 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Image = global::frm_maiormenos.Properties.Resources.maior;
            this.btn1.Location = new System.Drawing.Point(40, 166);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(203, 102);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Atividade 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::frm_maiormenos.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "frm_menu";
            this.Text = "frm_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}