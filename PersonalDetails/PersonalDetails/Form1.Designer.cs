namespace PersonalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDate = new System.Windows.Forms.DateTimePicker();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpHobbies = new System.Windows.Forms.GroupBox();
            this.chkbBall = new System.Windows.Forms.CheckBox();
            this.chkCrafting = new System.Windows.Forms.CheckBox();
            this.chkGuitar = new System.Windows.Forms.CheckBox();
            this.chkPiano = new System.Windows.Forms.CheckBox();
            this.chkMovies = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpHobbies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BirthDate";
            // 
            // bDate
            // 
            this.bDate.Location = new System.Drawing.Point(70, 50);
            this.bDate.Name = "bDate";
            this.bDate.Size = new System.Drawing.Size(200, 20);
            this.bDate.TabIndex = 3;
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Location = new System.Drawing.Point(6, 39);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(48, 17);
            this.rMale.TabIndex = 4;
            this.rMale.TabStop = true;
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            // 
            // rFemale
            // 
            this.rFemale.AutoSize = true;
            this.rFemale.Location = new System.Drawing.Point(97, 39);
            this.rFemale.Name = "rFemale";
            this.rFemale.Size = new System.Drawing.Size(59, 17);
            this.rFemale.TabIndex = 5;
            this.rFemale.TabStop = true;
            this.rFemale.Text = "Female";
            this.rFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rMale);
            this.groupBox1.Controls.Add(this.rFemale);
            this.groupBox1.Location = new System.Drawing.Point(70, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // grpHobbies
            // 
            this.grpHobbies.Controls.Add(this.chkbBall);
            this.grpHobbies.Controls.Add(this.chkCrafting);
            this.grpHobbies.Controls.Add(this.chkGuitar);
            this.grpHobbies.Controls.Add(this.chkPiano);
            this.grpHobbies.Controls.Add(this.chkMovies);
            this.grpHobbies.Controls.Add(this.chkMusic);
            this.grpHobbies.Location = new System.Drawing.Point(70, 209);
            this.grpHobbies.Name = "grpHobbies";
            this.grpHobbies.Size = new System.Drawing.Size(200, 169);
            this.grpHobbies.TabIndex = 7;
            this.grpHobbies.TabStop = false;
            this.grpHobbies.Text = "Hobbies";
            // 
            // chkbBall
            // 
            this.chkbBall.AutoSize = true;
            this.chkbBall.Location = new System.Drawing.Point(20, 139);
            this.chkbBall.Name = "chkbBall";
            this.chkbBall.Size = new System.Drawing.Size(112, 17);
            this.chkbBall.TabIndex = 5;
            this.chkbBall.Text = "Playing Basketball";
            this.chkbBall.UseVisualStyleBackColor = true;
            // 
            // chkCrafting
            // 
            this.chkCrafting.AutoSize = true;
            this.chkCrafting.Location = new System.Drawing.Point(20, 116);
            this.chkCrafting.Name = "chkCrafting";
            this.chkCrafting.Size = new System.Drawing.Size(62, 17);
            this.chkCrafting.TabIndex = 4;
            this.chkCrafting.Text = "Crafting";
            this.chkCrafting.UseVisualStyleBackColor = true;
            // 
            // chkGuitar
            // 
            this.chkGuitar.AutoSize = true;
            this.chkGuitar.Location = new System.Drawing.Point(20, 92);
            this.chkGuitar.Name = "chkGuitar";
            this.chkGuitar.Size = new System.Drawing.Size(91, 17);
            this.chkGuitar.TabIndex = 3;
            this.chkGuitar.Text = "Playing Guitar";
            this.chkGuitar.UseVisualStyleBackColor = true;
            // 
            // chkPiano
            // 
            this.chkPiano.AutoSize = true;
            this.chkPiano.Location = new System.Drawing.Point(20, 69);
            this.chkPiano.Name = "chkPiano";
            this.chkPiano.Size = new System.Drawing.Size(90, 17);
            this.chkPiano.TabIndex = 2;
            this.chkPiano.Text = "Playing Piano";
            this.chkPiano.UseVisualStyleBackColor = true;
            // 
            // chkMovies
            // 
            this.chkMovies.AutoSize = true;
            this.chkMovies.Location = new System.Drawing.Point(20, 44);
            this.chkMovies.Name = "chkMovies";
            this.chkMovies.Size = new System.Drawing.Size(109, 17);
            this.chkMovies.TabIndex = 1;
            this.chkMovies.Text = "Watching Movies";
            this.chkMovies.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(20, 20);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(99, 17);
            this.chkMusic.TabIndex = 0;
            this.chkMusic.Text = "Listening Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(586, 22);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(202, 160);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(106, 397);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(652, 188);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.grpHobbies);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpHobbies.ResumeLayout(false);
            this.grpHobbies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker bDate;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpHobbies;
        private System.Windows.Forms.CheckBox chkbBall;
        private System.Windows.Forms.CheckBox chkCrafting;
        private System.Windows.Forms.CheckBox chkGuitar;
        private System.Windows.Forms.CheckBox chkPiano;
        private System.Windows.Forms.CheckBox chkMovies;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnBrowse;
    }
}

