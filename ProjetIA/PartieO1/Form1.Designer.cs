namespace PartieO1
{
    partial class qcm
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
            System.Windows.Forms.Button buttonStart;
            this.BigTitle = new System.Windows.Forms.Label();
            buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(295, 220);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(141, 33);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Get me started";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // BigTitle
            // 
            this.BigTitle.AutoSize = true;
            this.BigTitle.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigTitle.Location = new System.Drawing.Point(44, 28);
            this.BigTitle.Name = "BigTitle";
            this.BigTitle.Size = new System.Drawing.Size(676, 57);
            this.BigTitle.TabIndex = 0;
            this.BigTitle.Text = "LE QCM DE SES MORTS";
            // 
            // qcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 486);
            this.Controls.Add(buttonStart);
            this.Controls.Add(this.BigTitle);
            this.Name = "qcm";
            this.Text = "QCM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BigTitle;
    }
}

