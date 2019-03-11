namespace NsWF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jsonTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.friendListBox = new System.Windows.Forms.ListBox();
            this.desirialiseBtn = new System.Windows.Forms.Button();
            this.createJsonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Json";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // jsonTxt
            // 
            this.jsonTxt.Location = new System.Drawing.Point(90, 47);
            this.jsonTxt.Name = "jsonTxt";
            this.jsonTxt.Size = new System.Drawing.Size(733, 22);
            this.jsonTxt.TabIndex = 5;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(126, 102);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(309, 22);
            this.firstNameTxt.TabIndex = 6;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(126, 170);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(309, 22);
            this.lastNameTxt.TabIndex = 7;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(126, 241);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(309, 22);
            this.emailTxt.TabIndex = 8;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(126, 311);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(309, 22);
            this.phoneTxt.TabIndex = 9;
            // 
            // friendListBox
            // 
            this.friendListBox.FormattingEnabled = true;
            this.friendListBox.ItemHeight = 16;
            this.friendListBox.Location = new System.Drawing.Point(483, 99);
            this.friendListBox.Name = "friendListBox";
            this.friendListBox.Size = new System.Drawing.Size(340, 244);
            this.friendListBox.TabIndex = 10;
            // 
            // desirialiseBtn
            // 
            this.desirialiseBtn.Location = new System.Drawing.Point(483, 367);
            this.desirialiseBtn.Name = "desirialiseBtn";
            this.desirialiseBtn.Size = new System.Drawing.Size(160, 33);
            this.desirialiseBtn.TabIndex = 11;
            this.desirialiseBtn.Text = "Desirialise";
            this.desirialiseBtn.UseVisualStyleBackColor = true;
            this.desirialiseBtn.Click += new System.EventHandler(this.desirialiseBtn_Click);
            // 
            // createJsonBtn
            // 
            this.createJsonBtn.Location = new System.Drawing.Point(663, 367);
            this.createJsonBtn.Name = "createJsonBtn";
            this.createJsonBtn.Size = new System.Drawing.Size(160, 33);
            this.createJsonBtn.TabIndex = 12;
            this.createJsonBtn.Text = "Create Json";
            this.createJsonBtn.UseVisualStyleBackColor = true;
            this.createJsonBtn.Click += new System.EventHandler(this.createJsonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.createJsonBtn);
            this.Controls.Add(this.desirialiseBtn);
            this.Controls.Add(this.friendListBox);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.jsonTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jsonTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.ListBox friendListBox;
        private System.Windows.Forms.Button desirialiseBtn;
        private System.Windows.Forms.Button createJsonBtn;
    }
}

