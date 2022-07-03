
namespace DemoWindowsFormApp
{
    partial class Forminfo
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.ShowOutput = new System.Windows.Forms.Label();
            this.chkBangla = new System.Windows.Forms.CheckBox();
            this.chkEnglish = new System.Windows.Forms.CheckBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lBoxInfo = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cBoxCountry = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(267, 136);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 50);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(181, 151);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 35);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(348, 461);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 30);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(181, 232);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 15);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(279, 232);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(60, 19);
            this.rbtnMale.TabIndex = 4;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(279, 273);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(74, 19);
            this.rbtnFemale.TabIndex = 5;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // ShowOutput
            // 
            this.ShowOutput.AutoSize = true;
            this.ShowOutput.Location = new System.Drawing.Point(532, 302);
            this.ShowOutput.Name = "ShowOutput";
            this.ShowOutput.Size = new System.Drawing.Size(61, 15);
            this.ShowOutput.TabIndex = 6;
            this.ShowOutput.Text = "Output";
            this.ShowOutput.Visible = false;
            // 
            // chkBangla
            // 
            this.chkBangla.AutoSize = true;
            this.chkBangla.Location = new System.Drawing.Point(279, 333);
            this.chkBangla.Name = "chkBangla";
            this.chkBangla.Size = new System.Drawing.Size(79, 19);
            this.chkBangla.TabIndex = 7;
            this.chkBangla.Text = "Bangla";
            this.chkBangla.UseVisualStyleBackColor = true;
            // 
            // chkEnglish
            // 
            this.chkEnglish.AutoSize = true;
            this.chkEnglish.Location = new System.Drawing.Point(279, 370);
            this.chkEnglish.Name = "chkEnglish";
            this.chkEnglish.Size = new System.Drawing.Size(79, 19);
            this.chkEnglish.TabIndex = 8;
            this.chkEnglish.Text = "English";
            this.chkEnglish.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(140, 337);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(117, 15);
            this.lblLanguage.TabIndex = 9;
            this.lblLanguage.Text = "Language Skill";
            // 
            // lBoxInfo
            // 
            this.lBoxInfo.FormattingEnabled = true;
            this.lBoxInfo.ItemHeight = 15;
            this.lBoxInfo.Location = new System.Drawing.Point(630, 370);
            this.lBoxInfo.Name = "lBoxInfo";
            this.lBoxInfo.Size = new System.Drawing.Size(169, 124);
            this.lBoxInfo.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bangladesh",
            "Australia",
            "India"});
            this.comboBox1.Location = new System.Drawing.Point(279, 413);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // cBoxCountry
            // 
            this.cBoxCountry.AutoSize = true;
            this.cBoxCountry.Location = new System.Drawing.Point(170, 421);
            this.cBoxCountry.Name = "cBoxCountry";
            this.cBoxCountry.Size = new System.Drawing.Size(73, 15);
            this.cBoxCountry.TabIndex = 12;
            this.cBoxCountry.Text = "Country";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(507, 496);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sample";
            // 
            // Forminfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 529);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cBoxCountry);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lBoxInfo);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.chkEnglish);
            this.Controls.Add(this.chkBangla);
            this.Controls.Add(this.ShowOutput);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Forminfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label ShowOutput;
        private System.Windows.Forms.CheckBox chkBangla;
        private System.Windows.Forms.CheckBox chkEnglish;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ListBox lBoxInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cBoxCountry;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

