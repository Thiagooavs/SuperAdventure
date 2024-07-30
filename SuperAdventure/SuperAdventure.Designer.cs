namespace SuperAdventure
{
    partial class SuperAdventure
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.IbIGold = new System.Windows.Forms.Label();
            this.IbIExperience = new System.Windows.Forms.Label();
            this.IbILevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(110, 19);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(13, 13);
            this.lblHitPoints.TabIndex = 4;
            this.lblHitPoints.Text = "a";
            // 
            // IbIGold
            // 
            this.IbIGold.AutoSize = true;
            this.IbIGold.Location = new System.Drawing.Point(110, 45);
            this.IbIGold.Name = "IbIGold";
            this.IbIGold.Size = new System.Drawing.Size(35, 13);
            this.IbIGold.TabIndex = 5;
            this.IbIGold.Text = "label6";
            // 
            // IbIExperience
            // 
            this.IbIExperience.AutoSize = true;
            this.IbIExperience.Location = new System.Drawing.Point(110, 73);
            this.IbIExperience.Name = "IbIExperience";
            this.IbIExperience.Size = new System.Drawing.Size(35, 13);
            this.IbIExperience.TabIndex = 6;
            this.IbIExperience.Text = "label7";
            // 
            // IbILevel
            // 
            this.IbILevel.AutoSize = true;
            this.IbILevel.Location = new System.Drawing.Point(110, 99);
            this.IbILevel.Name = "IbILevel";
            this.IbILevel.Size = new System.Drawing.Size(35, 13);
            this.IbILevel.TabIndex = 7;
            this.IbILevel.Text = "label8";
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.IbILevel);
            this.Controls.Add(this.IbIExperience);
            this.Controls.Add(this.IbIGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperAdventure";
            this.Text = "Meu jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label IbIGold;
        private System.Windows.Forms.Label IbIExperience;
        private System.Windows.Forms.Label IbILevel;
    }
}

