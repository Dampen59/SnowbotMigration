namespace SnowbotMigration
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sbDataFolderPath = new System.Windows.Forms.TextBox();
            this.btn_generateList = new System.Windows.Forms.Button();
            this.rich_exportedData = new System.Windows.Forms.RichTextBox();
            this.lbl_credits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chemin vers le répertoire de données d\'application de Snowbot";
            // 
            // txt_sbDataFolderPath
            // 
            this.txt_sbDataFolderPath.Location = new System.Drawing.Point(14, 25);
            this.txt_sbDataFolderPath.Name = "txt_sbDataFolderPath";
            this.txt_sbDataFolderPath.ReadOnly = true;
            this.txt_sbDataFolderPath.Size = new System.Drawing.Size(581, 20);
            this.txt_sbDataFolderPath.TabIndex = 1;
            // 
            // btn_generateList
            // 
            this.btn_generateList.Location = new System.Drawing.Point(14, 51);
            this.btn_generateList.Name = "btn_generateList";
            this.btn_generateList.Size = new System.Drawing.Size(581, 23);
            this.btn_generateList.TabIndex = 2;
            this.btn_generateList.Text = "Générer la liste";
            this.btn_generateList.UseVisualStyleBackColor = true;
            this.btn_generateList.Click += new System.EventHandler(this.btn_generateList_Click);
            // 
            // rich_exportedData
            // 
            this.rich_exportedData.Location = new System.Drawing.Point(14, 80);
            this.rich_exportedData.Name = "rich_exportedData";
            this.rich_exportedData.Size = new System.Drawing.Size(581, 328);
            this.rich_exportedData.TabIndex = 3;
            this.rich_exportedData.Text = "";
            // 
            // lbl_credits
            // 
            this.lbl_credits.AutoSize = true;
            this.lbl_credits.Location = new System.Drawing.Point(212, 413);
            this.lbl_credits.Name = "lbl_credits";
            this.lbl_credits.Size = new System.Drawing.Size(184, 13);
            this.lbl_credits.TabIndex = 4;
            this.lbl_credits.Text = "Dampen59#4187 - SnowbotMigration";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 431);
            this.Controls.Add(this.lbl_credits);
            this.Controls.Add(this.rich_exportedData);
            this.Controls.Add(this.btn_generateList);
            this.Controls.Add(this.txt_sbDataFolderPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnowbotMigration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sbDataFolderPath;
        private System.Windows.Forms.Button btn_generateList;
        private System.Windows.Forms.RichTextBox rich_exportedData;
        private System.Windows.Forms.Label lbl_credits;
    }
}

