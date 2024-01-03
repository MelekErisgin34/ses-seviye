namespace Ses_Seviye_Kontrol
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
            this.tBarSes = new System.Windows.Forms.TrackBar();
            this.lblSesseviyesi1 = new System.Windows.Forms.Label();
            this.lblSeviyedeger = new System.Windows.Forms.Label();
            this.lblSesseviyesi2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSes)).BeginInit();
            this.SuspendLayout();
            // 
            // tBarSes
            // 
            this.tBarSes.Location = new System.Drawing.Point(115, 34);
            this.tBarSes.Maximum = 100;
            this.tBarSes.Name = "tBarSes";
            this.tBarSes.Size = new System.Drawing.Size(373, 45);
            this.tBarSes.TabIndex = 0;
            this.tBarSes.Scroll += new System.EventHandler(this.tbBarSes_Scroll);
            // 
            // lblSesseviyesi1
            // 
            this.lblSesseviyesi1.AutoSize = true;
            this.lblSesseviyesi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesseviyesi1.Location = new System.Drawing.Point(130, 134);
            this.lblSesseviyesi1.Name = "lblSesseviyesi1";
            this.lblSesseviyesi1.Size = new System.Drawing.Size(98, 16);
            this.lblSesseviyesi1.TabIndex = 1;
            this.lblSesseviyesi1.Text = "Ses Seviyesi";
            // 
            // lblSeviyedeger
            // 
            this.lblSeviyedeger.AutoSize = true;
            this.lblSeviyedeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeviyedeger.Location = new System.Drawing.Point(494, 43);
            this.lblSeviyedeger.Name = "lblSeviyedeger";
            this.lblSeviyedeger.Size = new System.Drawing.Size(15, 16);
            this.lblSeviyedeger.TabIndex = 2;
            this.lblSeviyedeger.Text = "0";
            // 
            // lblSesseviyesi2
            // 
            this.lblSesseviyesi2.AutoSize = true;
            this.lblSesseviyesi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesseviyesi2.Location = new System.Drawing.Point(7, 43);
            this.lblSesseviyesi2.Name = "lblSesseviyesi2";
            this.lblSesseviyesi2.Size = new System.Drawing.Size(102, 16);
            this.lblSesseviyesi2.TabIndex = 3;
            this.lblSesseviyesi2.Text = "Ses Seviyesi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSesseviyesi2);
            this.Controls.Add(this.lblSeviyedeger);
            this.Controls.Add(this.lblSesseviyesi1);
            this.Controls.Add(this.tBarSes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBarSes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tBarSes;
        private System.Windows.Forms.Label lblSesseviyesi1;
        private System.Windows.Forms.Label lblSeviyedeger;
        private System.Windows.Forms.Label lblSesseviyesi2;
    }
}

