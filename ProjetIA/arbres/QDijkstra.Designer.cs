namespace arbres
{
    partial class QDijkstra
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ouverts = new System.Windows.Forms.Label();
            this.Fermes = new System.Windows.Forms.Label();
            this.checkedListBoxO = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxF = new System.Windows.Forms.CheckedListBox();
            this.listBoxO = new System.Windows.Forms.ListBox();
            this.listBoxF = new System.Windows.Forms.ListBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_verif_arbre = new System.Windows.Forms.Button();
            this.lbl_verif_arbre = new System.Windows.Forms.Label();
            this.arbreJuste = new System.Windows.Forms.TreeView();
            this.lbl_verif_suivant = new System.Windows.Forms.Label();
            this.lbl_cons = new System.Windows.Forms.Label();
            this.btn_5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(913, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(88, 179);
            this.treeView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "H:\\IA\\arbres\\arbres\\arbres\\graphe.png";
            this.pictureBox1.Location = new System.Drawing.Point(72, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 498);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ouverts
            // 
            this.Ouverts.AutoSize = true;
            this.Ouverts.Location = new System.Drawing.Point(900, 210);
            this.Ouverts.Name = "Ouverts";
            this.Ouverts.Size = new System.Drawing.Size(44, 13);
            this.Ouverts.TabIndex = 6;
            this.Ouverts.Text = "Ouverts";
            // 
            // Fermes
            // 
            this.Fermes.AutoSize = true;
            this.Fermes.Location = new System.Drawing.Point(1104, 210);
            this.Fermes.Name = "Fermes";
            this.Fermes.Size = new System.Drawing.Size(41, 13);
            this.Fermes.TabIndex = 7;
            this.Fermes.Text = "Fermés";
            // 
            // checkedListBoxO
            // 
            this.checkedListBoxO.FormattingEnabled = true;
            this.checkedListBoxO.Location = new System.Drawing.Point(903, 236);
            this.checkedListBoxO.Name = "checkedListBoxO";
            this.checkedListBoxO.Size = new System.Drawing.Size(113, 154);
            this.checkedListBoxO.TabIndex = 12;
            // 
            // checkedListBoxF
            // 
            this.checkedListBoxF.FormattingEnabled = true;
            this.checkedListBoxF.Location = new System.Drawing.Point(1107, 236);
            this.checkedListBoxF.Name = "checkedListBoxF";
            this.checkedListBoxF.Size = new System.Drawing.Size(116, 154);
            this.checkedListBoxF.TabIndex = 13;
            // 
            // listBoxO
            // 
            this.listBoxO.FormattingEnabled = true;
            this.listBoxO.Location = new System.Drawing.Point(913, 444);
            this.listBoxO.Name = "listBoxO";
            this.listBoxO.Size = new System.Drawing.Size(102, 147);
            this.listBoxO.TabIndex = 14;
            // 
            // listBoxF
            // 
            this.listBoxF.FormattingEnabled = true;
            this.listBoxF.Location = new System.Drawing.Point(1107, 444);
            this.listBoxF.Name = "listBoxF";
            this.listBoxF.Size = new System.Drawing.Size(106, 147);
            this.listBoxF.TabIndex = 15;
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(1019, 408);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(75, 23);
            this.btn_suivant.TabIndex = 16;
            this.btn_suivant.Text = "Suivant";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_verif_arbre
            // 
            this.btn_verif_arbre.Location = new System.Drawing.Point(1019, 57);
            this.btn_verif_arbre.Name = "btn_verif_arbre";
            this.btn_verif_arbre.Size = new System.Drawing.Size(75, 23);
            this.btn_verif_arbre.TabIndex = 17;
            this.btn_verif_arbre.Text = "Vérifier";
            this.btn_verif_arbre.UseVisualStyleBackColor = true;
            this.btn_verif_arbre.Click += new System.EventHandler(this.btn_verif_arbre_Click);
            // 
            // lbl_verif_arbre
            // 
            this.lbl_verif_arbre.AutoSize = true;
            this.lbl_verif_arbre.Location = new System.Drawing.Point(1034, 109);
            this.lbl_verif_arbre.Name = "lbl_verif_arbre";
            this.lbl_verif_arbre.Size = new System.Drawing.Size(35, 13);
            this.lbl_verif_arbre.TabIndex = 18;
            this.lbl_verif_arbre.Text = "label1";
            // 
            // arbreJuste
            // 
            this.arbreJuste.LabelEdit = true;
            this.arbreJuste.Location = new System.Drawing.Point(1107, 22);
            this.arbreJuste.Name = "arbreJuste";
            this.arbreJuste.Size = new System.Drawing.Size(88, 169);
            this.arbreJuste.TabIndex = 19;
            // 
            // lbl_verif_suivant
            // 
            this.lbl_verif_suivant.AutoSize = true;
            this.lbl_verif_suivant.Location = new System.Drawing.Point(1034, 468);
            this.lbl_verif_suivant.Name = "lbl_verif_suivant";
            this.lbl_verif_suivant.Size = new System.Drawing.Size(35, 13);
            this.lbl_verif_suivant.TabIndex = 21;
            this.lbl_verif_suivant.Text = "label2";
            // 
            // lbl_cons
            // 
            this.lbl_cons.AutoSize = true;
            this.lbl_cons.Location = new System.Drawing.Point(258, 57);
            this.lbl_cons.Name = "lbl_cons";
            this.lbl_cons.Size = new System.Drawing.Size(128, 13);
            this.lbl_cons.TabIndex = 22;
            this.lbl_cons.Text = "Aller du point A au point F";
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(664, 46);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 23);
            this.btn_5.TabIndex = 23;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // QDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 635);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.lbl_cons);
            this.Controls.Add(this.lbl_verif_suivant);
            this.Controls.Add(this.arbreJuste);
            this.Controls.Add(this.lbl_verif_arbre);
            this.Controls.Add(this.btn_verif_arbre);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.listBoxF);
            this.Controls.Add(this.listBoxO);
            this.Controls.Add(this.checkedListBoxF);
            this.Controls.Add(this.checkedListBoxO);
            this.Controls.Add(this.Fermes);
            this.Controls.Add(this.Ouverts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "QDijkstra";
            this.Text = "QDijksta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Ouverts;
        private System.Windows.Forms.Label Fermes;
        private System.Windows.Forms.CheckedListBox checkedListBoxO;
        private System.Windows.Forms.CheckedListBox checkedListBoxF;
        private System.Windows.Forms.ListBox listBoxO;
        private System.Windows.Forms.ListBox listBoxF;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_verif_arbre;
        private System.Windows.Forms.Label lbl_verif_arbre;
        private System.Windows.Forms.TreeView arbreJuste;
        private System.Windows.Forms.Label lbl_verif_suivant;
        private System.Windows.Forms.Label lbl_cons;
        private System.Windows.Forms.Button btn_5;
    }
}

