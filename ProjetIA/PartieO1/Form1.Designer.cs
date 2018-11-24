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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeBttn = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.finLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextBttn = new System.Windows.Forms.Button();
            this.numQuestion = new System.Windows.Forms.Label();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            buttonStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(121, 347);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(141, 33);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Get me started";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // BigTitle
            // 
            this.BigTitle.AutoSize = true;
            this.BigTitle.BackColor = System.Drawing.SystemColors.Control;
            this.BigTitle.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigTitle.Location = new System.Drawing.Point(49, 134);
            this.BigTitle.Name = "BigTitle";
            this.BigTitle.Size = new System.Drawing.Size(290, 33);
            this.BigTitle.TabIndex = 0;
            this.BigTitle.Text = "LE QCM DE SES MORTS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nextBttn);
            this.panel1.Controls.Add(this.numQuestion);
            this.panel1.Controls.Add(this.rbD);
            this.panel1.Controls.Add(this.rbC);
            this.panel1.Controls.Add(this.rbB);
            this.panel1.Controls.Add(this.rbA);
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 645);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homeBttn);
            this.panel2.Controls.Add(this.scoreLabel);
            this.panel2.Controls.Add(this.finLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 645);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // homeBttn
            // 
            this.homeBttn.Location = new System.Drawing.Point(137, 272);
            this.homeBttn.Name = "homeBttn";
            this.homeBttn.Size = new System.Drawing.Size(75, 23);
            this.homeBttn.TabIndex = 2;
            this.homeBttn.Text = "Accueil";
            this.homeBttn.UseVisualStyleBackColor = true;
            this.homeBttn.Click += new System.EventHandler(this.homeBttn_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(166, 171);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(30, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0/20";
            // 
            // finLabel
            // 
            this.finLabel.AutoSize = true;
            this.finLabel.Location = new System.Drawing.Point(149, 134);
            this.finLabel.Name = "finLabel";
            this.finLabel.Size = new System.Drawing.Size(63, 13);
            this.finLabel.TabIndex = 0;
            this.finLabel.Text = "Fin du QCM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "H:\\IA\\Projet\\ProjetIA\\ProjetIA\\PartieO1\\images\\seeulater.jpeg";
            this.pictureBox1.Location = new System.Drawing.Point(590, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 552);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // nextBttn
            // 
            this.nextBttn.Location = new System.Drawing.Point(137, 574);
            this.nextBttn.Name = "nextBttn";
            this.nextBttn.Size = new System.Drawing.Size(75, 23);
            this.nextBttn.TabIndex = 10;
            this.nextBttn.Text = "Suivant";
            this.nextBttn.UseVisualStyleBackColor = true;
            this.nextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // numQuestion
            // 
            this.numQuestion.AutoSize = true;
            this.numQuestion.Location = new System.Drawing.Point(163, 49);
            this.numQuestion.Name = "numQuestion";
            this.numQuestion.Size = new System.Drawing.Size(30, 13);
            this.numQuestion.TabIndex = 9;
            this.numQuestion.Text = "1/20";
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(137, 441);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(85, 17);
            this.rbD.TabIndex = 8;
            this.rbD.TabStop = true;
            this.rbD.Text = "radioButton4";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(137, 355);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(85, 17);
            this.rbC.TabIndex = 7;
            this.rbC.TabStop = true;
            this.rbC.Text = "radioButton3";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(137, 278);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(85, 17);
            this.rbB.TabIndex = 6;
            this.rbB.TabStop = true;
            this.rbB.Text = "radioButton2";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(137, 203);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(85, 17);
            this.rbA.TabIndex = 5;
            this.rbA.TabStop = true;
            this.rbA.Text = "radioButton1";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(75, 80);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(500, 70);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Mais que voilà si ce n\'est la question suivanteqfq\r\nretezte\r\nzerrtze\r\n\r\nrsdg";
            // 
            // qcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(buttonStart);
            this.Controls.Add(this.BigTitle);
            this.Name = "qcm";
            this.Text = "QCM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BigTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numQuestion;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button nextBttn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homeBttn;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label finLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

