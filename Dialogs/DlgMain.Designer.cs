namespace Distic.Employability.Calculator.Dialogs
{
    partial class DlgMain
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.ecBtnResult = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnSubtract = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnAdd = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnArabic = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnNational = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnPrivate = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnRich = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnForeignLanguage = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnRefugee = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnPublic = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecBtnPoor = new Distic.Employability.Calculator.CustomControls.ECButton();
            this.ecOutputFrame1 = new Distic.Employability.Calculator.CustomControls.ECOutputFrame();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem9,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem7,
            this.menuItem6});
            this.menuItem1.Text = "&File";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "&Reload";
            this.menuItem8.Click += new System.EventHandler(this.MenuItem8_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "&Exit to Windows";
            this.menuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10});
            this.menuItem9.Text = "&Window";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Text = "Set Size...";
            this.menuItem10.Click += new System.EventHandler(this.MenuItem10_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem3});
            this.menuItem2.Text = "&Help";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Show Help...";
            this.menuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "About Employability Calculator...";
            this.menuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // ecBtnResult
            // 
            this.ecBtnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnResult.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Result;
            this.ecBtnResult.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnResult.ForeColor = System.Drawing.Color.White;
            this.ecBtnResult.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnResult.Location = new System.Drawing.Point(388, 277);
            this.ecBtnResult.Name = "ecBtnResult";
            this.ecBtnResult.Size = new System.Drawing.Size(87, 162);
            this.ecBtnResult.TabIndex = 15;
            this.ecBtnResult.Text = "=";
            this.ecBtnResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnResult.Click += new System.EventHandler(this.EcBtnResult_Click);
            // 
            // ecBtnSubtract
            // 
            this.ecBtnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnSubtract.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Subtraction;
            this.ecBtnSubtract.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnSubtract.ForeColor = System.Drawing.Color.White;
            this.ecBtnSubtract.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnSubtract.Location = new System.Drawing.Point(388, 193);
            this.ecBtnSubtract.Name = "ecBtnSubtract";
            this.ecBtnSubtract.Size = new System.Drawing.Size(87, 78);
            this.ecBtnSubtract.TabIndex = 14;
            this.ecBtnSubtract.Text = "AC";
            this.ecBtnSubtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnSubtract.Click += new System.EventHandler(this.EcBtnSubtract_Click);
            // 
            // ecBtnAdd
            // 
            this.ecBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnAdd.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Addition;
            this.ecBtnAdd.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnAdd.ForeColor = System.Drawing.Color.White;
            this.ecBtnAdd.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnAdd.Location = new System.Drawing.Point(388, 109);
            this.ecBtnAdd.Name = "ecBtnAdd";
            this.ecBtnAdd.Size = new System.Drawing.Size(87, 78);
            this.ecBtnAdd.TabIndex = 13;
            this.ecBtnAdd.Text = "+";
            this.ecBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnAdd.Click += new System.EventHandler(this.EcBtnAdd_Click);
            // 
            // ecBtnArabic
            // 
            this.ecBtnArabic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnArabic.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Arabic;
            this.ecBtnArabic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnArabic.ForeColor = System.Drawing.Color.White;
            this.ecBtnArabic.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnArabic.Location = new System.Drawing.Point(273, 8);
            this.ecBtnArabic.Name = "ecBtnArabic";
            this.ecBtnArabic.Size = new System.Drawing.Size(87, 63);
            this.ecBtnArabic.TabIndex = 12;
            this.ecBtnArabic.Text = "Arabic";
            this.ecBtnArabic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnArabic.Click += new System.EventHandler(this.EcBtnArabic_Click);
            // 
            // ecBtnNational
            // 
            this.ecBtnNational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnNational.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.National;
            this.ecBtnNational.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnNational.ForeColor = System.Drawing.Color.White;
            this.ecBtnNational.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnNational.Location = new System.Drawing.Point(273, 8);
            this.ecBtnNational.Name = "ecBtnNational";
            this.ecBtnNational.Size = new System.Drawing.Size(87, 63);
            this.ecBtnNational.TabIndex = 11;
            this.ecBtnNational.Text = "National";
            this.ecBtnNational.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnNational.Click += new System.EventHandler(this.EcBtnNational_Click);
            // 
            // ecBtnPrivate
            // 
            this.ecBtnPrivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnPrivate.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Private;
            this.ecBtnPrivate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnPrivate.ForeColor = System.Drawing.Color.White;
            this.ecBtnPrivate.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnPrivate.Location = new System.Drawing.Point(273, 8);
            this.ecBtnPrivate.Name = "ecBtnPrivate";
            this.ecBtnPrivate.Size = new System.Drawing.Size(87, 63);
            this.ecBtnPrivate.TabIndex = 10;
            this.ecBtnPrivate.Text = "Private";
            this.ecBtnPrivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnPrivate.Click += new System.EventHandler(this.EcBtnPrivate_Click);
            // 
            // ecBtnRich
            // 
            this.ecBtnRich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnRich.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Rich;
            this.ecBtnRich.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnRich.ForeColor = System.Drawing.Color.White;
            this.ecBtnRich.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnRich.Location = new System.Drawing.Point(273, 8);
            this.ecBtnRich.Name = "ecBtnRich";
            this.ecBtnRich.Size = new System.Drawing.Size(87, 63);
            this.ecBtnRich.TabIndex = 9;
            this.ecBtnRich.Text = "Rich";
            this.ecBtnRich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnRich.Click += new System.EventHandler(this.EcBtnRich_Click);
            // 
            // ecBtnForeignLanguage
            // 
            this.ecBtnForeignLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnForeignLanguage.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.ForeignLanguage;
            this.ecBtnForeignLanguage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnForeignLanguage.ForeColor = System.Drawing.Color.White;
            this.ecBtnForeignLanguage.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnForeignLanguage.Location = new System.Drawing.Point(180, 8);
            this.ecBtnForeignLanguage.Name = "ecBtnForeignLanguage";
            this.ecBtnForeignLanguage.Size = new System.Drawing.Size(87, 63);
            this.ecBtnForeignLanguage.TabIndex = 8;
            this.ecBtnForeignLanguage.Text = "Foreign Language";
            this.ecBtnForeignLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnForeignLanguage.Click += new System.EventHandler(this.EcBtnForeignLanguage_Click);
            // 
            // ecBtnRefugee
            // 
            this.ecBtnRefugee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnRefugee.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Refugee;
            this.ecBtnRefugee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnRefugee.ForeColor = System.Drawing.Color.White;
            this.ecBtnRefugee.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnRefugee.Location = new System.Drawing.Point(180, 8);
            this.ecBtnRefugee.Name = "ecBtnRefugee";
            this.ecBtnRefugee.Size = new System.Drawing.Size(87, 63);
            this.ecBtnRefugee.TabIndex = 7;
            this.ecBtnRefugee.Text = "Refugee";
            this.ecBtnRefugee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnRefugee.Click += new System.EventHandler(this.EcBtnRefugee_Click);
            // 
            // ecBtnPublic
            // 
            this.ecBtnPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnPublic.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Public;
            this.ecBtnPublic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnPublic.ForeColor = System.Drawing.Color.White;
            this.ecBtnPublic.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnPublic.Location = new System.Drawing.Point(180, 8);
            this.ecBtnPublic.Name = "ecBtnPublic";
            this.ecBtnPublic.Size = new System.Drawing.Size(87, 63);
            this.ecBtnPublic.TabIndex = 6;
            this.ecBtnPublic.Text = "Public";
            this.ecBtnPublic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnPublic.Click += new System.EventHandler(this.EcBtnPublic_Click);
            // 
            // ecBtnPoor
            // 
            this.ecBtnPoor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(127)))), ((int)(((byte)(42)))));
            this.ecBtnPoor.ECValue = Distic.Employability.Calculator.Utilities.ECCPU.ECValues.Poor;
            this.ecBtnPoor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecBtnPoor.ForeColor = System.Drawing.Color.White;
            this.ecBtnPoor.LabelForeColor = Distic.Employability.Calculator.CustomControls.ECButton.ForeColorInvert.Black;
            this.ecBtnPoor.Location = new System.Drawing.Point(180, 8);
            this.ecBtnPoor.Name = "ecBtnPoor";
            this.ecBtnPoor.Size = new System.Drawing.Size(87, 63);
            this.ecBtnPoor.TabIndex = 5;
            this.ecBtnPoor.Text = "Poor";
            this.ecBtnPoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecBtnPoor.Click += new System.EventHandler(this.EcBtnPoor_Click);
            // 
            // ecOutputFrame1
            // 
            this.ecOutputFrame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(143)))));
            this.ecOutputFrame1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ecOutputFrame1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecOutputFrame1.Location = new System.Drawing.Point(12, 12);
            this.ecOutputFrame1.Name = "ecOutputFrame1";
            this.ecOutputFrame1.Size = new System.Drawing.Size(463, 84);
            this.ecOutputFrame1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "SES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ecBtnRich);
            this.panel1.Controls.Add(this.ecBtnPoor);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 78);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ecBtnPublic);
            this.panel2.Controls.Add(this.ecBtnPrivate);
            this.panel2.Location = new System.Drawing.Point(12, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 78);
            this.panel2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 63);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sector";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ecBtnRefugee);
            this.panel3.Controls.Add(this.ecBtnNational);
            this.panel3.Location = new System.Drawing.Point(12, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 78);
            this.panel3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 63);
            this.label2.TabIndex = 16;
            this.label2.Text = "Legal Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ecBtnArabic);
            this.panel4.Controls.Add(this.ecBtnForeignLanguage);
            this.panel4.Location = new System.Drawing.Point(12, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 78);
            this.panel4.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 63);
            this.label3.TabIndex = 16;
            this.label3.Text = "LOI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DlgMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(174)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(487, 451);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ecBtnResult);
            this.Controls.Add(this.ecBtnSubtract);
            this.Controls.Add(this.ecBtnAdd);
            this.Controls.Add(this.ecOutputFrame1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "DlgMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employability Calculator by Distic";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ECOutputFrame ecOutputFrame1;
        private CustomControls.ECButton ecBtnPoor;
        private CustomControls.ECButton ecBtnPublic;
        private CustomControls.ECButton ecBtnRefugee;
        private CustomControls.ECButton ecBtnForeignLanguage;
        private CustomControls.ECButton ecBtnArabic;
        private CustomControls.ECButton ecBtnNational;
        private CustomControls.ECButton ecBtnPrivate;
        private CustomControls.ECButton ecBtnRich;
        private CustomControls.ECButton ecBtnSubtract;
        private CustomControls.ECButton ecBtnAdd;
        private CustomControls.ECButton ecBtnResult;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
    }
}