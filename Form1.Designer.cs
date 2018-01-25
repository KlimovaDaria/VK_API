namespace vk_api_wf
{
    partial class main_Form
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
            this.pictureBoxUserPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelUserBirthDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUserCountry = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelUserCity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUserSurname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUser1ID = new System.Windows.Forms.TextBox();
            this.textBoxUser2ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFindFriends = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxUserPhoto
            // 
            this.pictureBoxUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserPhoto.Location = new System.Drawing.Point(8, 7);
            this.pictureBoxUserPhoto.Name = "pictureBoxUserPhoto";
            this.pictureBoxUserPhoto.Size = new System.Drawing.Size(262, 160);
            this.pictureBoxUserPhoto.TabIndex = 0;
            this.pictureBoxUserPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLeft);
            this.panel1.Controls.Add(this.buttonRight);
            this.panel1.Controls.Add(this.labelUserBirthDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelUserCountry);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelUserCity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelUserSurname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Controls.Add(this.pictureBoxUserPhoto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 236);
            this.panel1.TabIndex = 2;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(83, 184);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(48, 40);
            this.buttonLeft.TabIndex = 12;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(156, 183);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(48, 40);
            this.buttonRight.TabIndex = 11;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // labelUserBirthDate
            // 
            this.labelUserBirthDate.AutoSize = true;
            this.labelUserBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserBirthDate.Location = new System.Drawing.Point(376, 147);
            this.labelUserBirthDate.Name = "labelUserBirthDate";
            this.labelUserBirthDate.Size = new System.Drawing.Size(18, 20);
            this.labelUserBirthDate.TabIndex = 10;
            this.labelUserBirthDate.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(296, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "BirthDay:";
            // 
            // labelUserCountry
            // 
            this.labelUserCountry.AutoSize = true;
            this.labelUserCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserCountry.Location = new System.Drawing.Point(376, 110);
            this.labelUserCountry.Name = "labelUserCountry";
            this.labelUserCountry.Size = new System.Drawing.Size(18, 20);
            this.labelUserCountry.TabIndex = 8;
            this.labelUserCountry.Text = "_";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(296, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country:";
            // 
            // labelUserCity
            // 
            this.labelUserCity.AutoSize = true;
            this.labelUserCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserCity.Location = new System.Drawing.Point(376, 75);
            this.labelUserCity.Name = "labelUserCity";
            this.labelUserCity.Size = new System.Drawing.Size(18, 20);
            this.labelUserCity.TabIndex = 6;
            this.labelUserCity.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(296, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "City:";
            // 
            // labelUserSurname
            // 
            this.labelUserSurname.AutoSize = true;
            this.labelUserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserSurname.Location = new System.Drawing.Point(376, 41);
            this.labelUserSurname.Name = "labelUserSurname";
            this.labelUserSurname.Size = new System.Drawing.Size(18, 20);
            this.labelUserSurname.TabIndex = 4;
            this.labelUserSurname.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(296, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.Location = new System.Drawing.Point(376, 7);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(18, 20);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "First User ID:";
            // 
            // textBoxUser1ID
            // 
            this.textBoxUser1ID.Location = new System.Drawing.Point(149, 267);
            this.textBoxUser1ID.Name = "textBoxUser1ID";
            this.textBoxUser1ID.Size = new System.Drawing.Size(174, 20);
            this.textBoxUser1ID.TabIndex = 4;
            // 
            // textBoxUser2ID
            // 
            this.textBoxUser2ID.Location = new System.Drawing.Point(148, 300);
            this.textBoxUser2ID.Name = "textBoxUser2ID";
            this.textBoxUser2ID.Size = new System.Drawing.Size(174, 20);
            this.textBoxUser2ID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second User ID:";
            // 
            // buttonFindFriends
            // 
            this.buttonFindFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindFriends.Location = new System.Drawing.Point(342, 271);
            this.buttonFindFriends.Name = "buttonFindFriends";
            this.buttonFindFriends.Size = new System.Drawing.Size(141, 40);
            this.buttonFindFriends.TabIndex = 11;
            this.buttonFindFriends.Text = "Find Friends";
            this.buttonFindFriends.UseVisualStyleBackColor = true;
            this.buttonFindFriends.Click += new System.EventHandler(this.button_Find_Friends_Click);
            // 
            // main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 345);
            this.Controls.Add(this.buttonFindFriends);
            this.Controls.Add(this.textBoxUser2ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUser1ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "main_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vk API";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUserPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelUserCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUserSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUser1ID;
        private System.Windows.Forms.Label labelUserBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUser2ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFindFriends;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
    }
}

