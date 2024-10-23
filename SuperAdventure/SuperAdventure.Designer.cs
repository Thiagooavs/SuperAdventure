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
            this.lbl_Gold = new System.Windows.Forms.Label();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbWeapons = new System.Windows.Forms.ComboBox();
            this.cmbPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWeast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMensages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
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
            this.lblHitPoints.Text = "0";
            // 
            // lbl_Gold
            // 
            this.lbl_Gold.AutoSize = true;
            this.lbl_Gold.Location = new System.Drawing.Point(110, 45);
            this.lbl_Gold.Name = "lbl_Gold";
            this.lbl_Gold.Size = new System.Drawing.Size(13, 13);
            this.lbl_Gold.TabIndex = 5;
            this.lbl_Gold.Text = "0";
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.AutoSize = true;
            this.lbl_Experience.Location = new System.Drawing.Point(110, 73);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(13, 13);
            this.lbl_Experience.TabIndex = 6;
            this.lbl_Experience.Text = "0";
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Location = new System.Drawing.Point(110, 99);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(13, 13);
            this.lbl_Level.TabIndex = 7;
            this.lbl_Level.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Action:";
            // 
            // cmbWeapons
            // 
            this.cmbWeapons.FormattingEnabled = true;
            this.cmbWeapons.Location = new System.Drawing.Point(369, 559);
            this.cmbWeapons.Name = "cmbWeapons";
            this.cmbWeapons.Size = new System.Drawing.Size(121, 21);
            this.cmbWeapons.TabIndex = 9;
            // 
            // cmbPotions
            // 
            this.cmbPotions.FormattingEnabled = true;
            this.cmbPotions.Location = new System.Drawing.Point(369, 593);
            this.cmbPotions.Name = "cmbPotions";
            this.cmbPotions.Size = new System.Drawing.Size(121, 21);
            this.cmbPotions.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 11;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(620, 593);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 12;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 13;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(573, 457);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 14;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            // 
            // btnWeast
            // 
            this.btnWeast.Location = new System.Drawing.Point(412, 457);
            this.btnWeast.Name = "btnWeast";
            this.btnWeast.Size = new System.Drawing.Size(75, 23);
            this.btnWeast.TabIndex = 15;
            this.btnWeast.Text = "Weast";
            this.btnWeast.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 16;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(365, 105);
            this.rtbLocation.TabIndex = 17;
            this.rtbLocation.Text = "";
            // 
            // rtbMensages
            // 
            this.rtbMensages.Location = new System.Drawing.Point(347, 130);
            this.rtbMensages.Name = "rtbMensages";
            this.rtbMensages.ReadOnly = true;
            this.rtbMensages.Size = new System.Drawing.Size(360, 286);
            this.rtbMensages.TabIndex = 18;
            this.rtbMensages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 20;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMensages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnWeast);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cmbPotions);
            this.Controls.Add(this.cmbWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.lbl_Experience);
            this.Controls.Add(this.lbl_Gold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperAdventure";
            this.Text = "Meu jogo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lbl_Gold;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.Label lbl_Level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbWeapons;
        private System.Windows.Forms.ComboBox cmbPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWeast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMensages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
    }
}

