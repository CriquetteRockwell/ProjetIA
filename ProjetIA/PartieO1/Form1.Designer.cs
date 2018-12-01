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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qcm));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            buttonStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(438, 455);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(141, 33);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "COMMENCER ";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // BigTitle
            // 
            this.BigTitle.BackColor = System.Drawing.SystemColors.Control;
            this.BigTitle.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigTitle.Location = new System.Drawing.Point(217, 79);
            this.BigTitle.Name = "BigTitle";
            this.BigTitle.Size = new System.Drawing.Size(641, 192);
            this.BigTitle.TabIndex = 0;
            this.BigTitle.Text = "Testez vos connaissances en Intelligence Artificielle  !";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nextBttn);
            this.panel1.Controls.Add(this.numQuestion);
            this.panel1.Controls.Add(this.rbD);
            this.panel1.Controls.Add(this.rbC);
            this.panel1.Controls.Add(this.rbB);
            this.panel1.Controls.Add(this.rbA);
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 631);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.homeBttn);
            this.panel2.Controls.Add(this.scoreLabel);
            this.panel2.Controls.Add(this.finLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 631);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // homeBttn
            // 
            this.homeBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBttn.Location = new System.Drawing.Point(474, 389);
            this.homeBttn.Name = "homeBttn";
            this.homeBttn.Size = new System.Drawing.Size(108, 38);
            this.homeBttn.TabIndex = 2;
            this.homeBttn.Text = "Accueil";
            this.homeBttn.UseVisualStyleBackColor = true;
            this.homeBttn.Click += new System.EventHandler(this.homeBttn_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(506, 319);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(54, 25);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0/20";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // finLabel
            // 
            this.finLabel.AutoSize = true;
            this.finLabel.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finLabel.Location = new System.Drawing.Point(362, 188);
            this.finLabel.Name = "finLabel";
            this.finLabel.Size = new System.Drawing.Size(349, 65);
            this.finLabel.TabIndex = 0;
            this.finLabel.Text = "Fin du QCM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "H:\\IA\\Projet\\ProjetIA\\ProjetIA\\PartieO1\\images\\seeulater.jpeg";
            this.pictureBox1.Location = new System.Drawing.Point(350, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 569);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // nextBttn
            // 
            this.nextBttn.Location = new System.Drawing.Point(138, 491);
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
            this.numQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuestion.Location = new System.Drawing.Point(557, 9);
            this.numQuestion.Name = "numQuestion";
            this.numQuestion.Size = new System.Drawing.Size(58, 25);
            this.numQuestion.TabIndex = 9;
            this.numQuestion.Text = "1/20";
            // 
            // rbD
            // 
            this.rbD.Location = new System.Drawing.Point(52, 388);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(259, 75);
            this.rbD.TabIndex = 8;
            this.rbD.TabStop = true;
            this.rbD.Text = "radioButton4";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.Location = new System.Drawing.Point(52, 299);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(213, 75);
            this.rbC.TabIndex = 7;
            this.rbC.TabStop = true;
            this.rbC.Text = "radioButton3";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.Location = new System.Drawing.Point(52, 207);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(200, 75);
            this.rbB.TabIndex = 6;
            this.rbB.TabStop = true;
            this.rbB.Text = "radioButton2";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.Location = new System.Drawing.Point(52, 114);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(200, 75);
            this.rbA.TabIndex = 5;
            this.rbA.TabStop = true;
            this.rbA.Text = "radioButton1";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(11, 49);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(333, 115);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Mais que voilà si ce n\'est la question suivanteqfq\r\nretezte\r\nzerrtze\r\n\r\nrsdg";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Votre note :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Question n°";
            // 
            // qcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(buttonStart);
            this.Controls.Add(this.BigTitle);
            this.Name = "qcm";
            this.Text = "QCM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button homeBttn;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label finLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

