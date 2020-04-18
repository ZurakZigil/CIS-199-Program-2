namespace Program2
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
            this.tBoxHours = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.displayYear = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.tBoxLastName = new System.Windows.Forms.TextBox();
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe = new System.Windows.Forms.Label();
            this.displayRegTime = new System.Windows.Forms.Label();
            this.buttEnter = new System.Windows.Forms.Button();
            this.cBoxGraduate = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayRegDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxHours
            // 
            this.tBoxHours.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxHours.Location = new System.Drawing.Point(337, 67);
            this.tBoxHours.Name = "tBoxHours";
            this.tBoxHours.Size = new System.Drawing.Size(149, 33);
            this.tBoxHours.TabIndex = 0;
            // 
            // labelHours
            // 
            this.labelHours.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(197, 72);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(123, 26);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Hours: ";
            // 
            // displayYear
            // 
            this.displayYear.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayYear.Location = new System.Drawing.Point(197, 298);
            this.displayYear.Name = "displayYear";
            this.displayYear.Size = new System.Drawing.Size(183, 34);
            this.displayYear.TabIndex = 2;
            this.displayYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastName
            // 
            this.labelLastName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(197, 196);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(134, 26);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name:";
            // 
            // tBoxLastName
            // 
            this.tBoxLastName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLastName.Location = new System.Drawing.Point(337, 193);
            this.tBoxLastName.Name = "tBoxLastName";
            this.tBoxLastName.Size = new System.Drawing.Size(320, 33);
            this.tBoxLastName.TabIndex = 3;
            // 
            // labelComeOnWhyYouEvenCheckingThisBetterNotBe
            // 
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe.Location = new System.Drawing.Point(492, 70);
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe.Name = "labelComeOnWhyYouEvenCheckingThisBetterNotBe";
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe.Size = new System.Drawing.Size(178, 30);
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe.TabIndex = 5;
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe.Text = "(Without Spring 2018)";
            this.labelComeOnWhyYouEvenCheckingThisBetterNotBe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayRegTime
            // 
            this.displayRegTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayRegTime.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayRegTime.Location = new System.Drawing.Point(197, 405);
            this.displayRegTime.Name = "displayRegTime";
            this.displayRegTime.Size = new System.Drawing.Size(460, 73);
            this.displayRegTime.TabIndex = 6;
            this.displayRegTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttEnter
            // 
            this.buttEnter.Location = new System.Drawing.Point(496, 242);
            this.buttEnter.Name = "buttEnter";
            this.buttEnter.Size = new System.Drawing.Size(161, 37);
            this.buttEnter.TabIndex = 7;
            this.buttEnter.Text = "Enter";
            this.buttEnter.UseVisualStyleBackColor = true;
            this.buttEnter.Click += new System.EventHandler(this.buttEnter_Click);
            // 
            // cBoxGraduate
            // 
            this.cBoxGraduate.AutoSize = true;
            this.cBoxGraduate.Location = new System.Drawing.Point(337, 106);
            this.cBoxGraduate.Name = "cBoxGraduate";
            this.cBoxGraduate.Size = new System.Drawing.Size(103, 24);
            this.cBoxGraduate.TabIndex = 8;
            this.cBoxGraduate.Text = "Graduate";
            this.cBoxGraduate.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // displayRegDate
            // 
            this.displayRegDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayRegDate.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayRegDate.Location = new System.Drawing.Point(197, 332);
            this.displayRegDate.Name = "displayRegDate";
            this.displayRegDate.Size = new System.Drawing.Size(460, 73);
            this.displayRegDate.TabIndex = 10;
            this.displayRegDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 520);
            this.Controls.Add(this.displayRegDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cBoxGraduate);
            this.Controls.Add(this.buttEnter);
            this.Controls.Add(this.displayRegTime);
            this.Controls.Add(this.labelComeOnWhyYouEvenCheckingThisBetterNotBe);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.tBoxLastName);
            this.Controls.Add(this.displayYear);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.tBoxHours);
            this.Name = "Form1";
            this.Text = "Registration Time";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxHours;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label displayYear;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox tBoxLastName;
        private System.Windows.Forms.Label labelComeOnWhyYouEvenCheckingThisBetterNotBe;
        private System.Windows.Forms.Label displayRegTime;
        private System.Windows.Forms.Button buttEnter;
        private System.Windows.Forms.CheckBox cBoxGraduate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label displayRegDate;
    }
}

