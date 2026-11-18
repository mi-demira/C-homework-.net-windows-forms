namespace Калкулатор_куриерски_пратки
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.rButtonIconomic = new System.Windows.Forms.RadioButton();
            this.rBtnStandart = new System.Windows.Forms.RadioButton();
            this.rBtnExpress = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxFragile = new System.Windows.Forms.CheckBox();
            this.cBoxAdress = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblFullSum = new System.Windows.Forms.Label();
            this.lblAvgW = new System.Windows.Forms.Label();
            this.lBox = new System.Windows.Forms.ListBox();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(54, 58);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "First name:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(54, 125);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(152, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Second name:";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl3.Location = new System.Drawing.Point(54, 192);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(221, 25);
            this.Lbl3.TabIndex = 2;
            this.Lbl3.Text = "Weight of parcel (kg):";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl4.Location = new System.Drawing.Point(54, 259);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(288, 25);
            this.Lbl4.TabIndex = 3;
            this.Lbl4.Text = "Distance it has to travel(km):";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(423, 70);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 30);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecondName.Location = new System.Drawing.Point(423, 134);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(168, 30);
            this.txtSecondName.TabIndex = 5;
            this.txtSecondName.TextChanged += new System.EventHandler(this.txtSecondName_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWeight.Location = new System.Drawing.Point(423, 198);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(168, 30);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDistance.Location = new System.Drawing.Point(423, 262);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(168, 30);
            this.txtDistance.TabIndex = 7;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // rButtonIconomic
            // 
            this.rButtonIconomic.AutoSize = true;
            this.rButtonIconomic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rButtonIconomic.Location = new System.Drawing.Point(5, 14);
            this.rButtonIconomic.Name = "rButtonIconomic";
            this.rButtonIconomic.Size = new System.Drawing.Size(281, 29);
            this.rButtonIconomic.TabIndex = 8;
            this.rButtonIconomic.TabStop = true;
            this.rButtonIconomic.Text = "Iconomic delivery - 2 euro";
            this.rButtonIconomic.UseVisualStyleBackColor = true;
            // 
            // rBtnStandart
            // 
            this.rBtnStandart.AutoSize = true;
            this.rBtnStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtnStandart.Location = new System.Drawing.Point(5, 78);
            this.rBtnStandart.Name = "rBtnStandart";
            this.rBtnStandart.Size = new System.Drawing.Size(278, 29);
            this.rBtnStandart.TabIndex = 9;
            this.rBtnStandart.TabStop = true;
            this.rBtnStandart.Text = "standart delivery = 3 euro";
            this.rBtnStandart.UseVisualStyleBackColor = true;
            // 
            // rBtnExpress
            // 
            this.rBtnExpress.AutoSize = true;
            this.rBtnExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtnExpress.Location = new System.Drawing.Point(5, 142);
            this.rBtnExpress.Name = "rBtnExpress";
            this.rBtnExpress.Size = new System.Drawing.Size(273, 29);
            this.rBtnExpress.TabIndex = 10;
            this.rBtnExpress.TabStop = true;
            this.rBtnExpress.Text = "Express delivery - 5 euro";
            this.rBtnExpress.UseVisualStyleBackColor = true;
            this.rBtnExpress.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(677, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type of delivery:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(54, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Specifics (if needed):";
            // 
            // cBoxFragile
            // 
            this.cBoxFragile.AutoSize = true;
            this.cBoxFragile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxFragile.Location = new System.Drawing.Point(59, 373);
            this.cBoxFragile.Name = "cBoxFragile";
            this.cBoxFragile.Size = new System.Drawing.Size(344, 29);
            this.cBoxFragile.TabIndex = 13;
            this.cBoxFragile.Text = "Fragile - +30% of the whole sum";
            this.cBoxFragile.UseVisualStyleBackColor = true;
            // 
            // cBoxAdress
            // 
            this.cBoxAdress.AutoSize = true;
            this.cBoxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxAdress.Location = new System.Drawing.Point(59, 420);
            this.cBoxAdress.Name = "cBoxAdress";
            this.cBoxAdress.Size = new System.Drawing.Size(463, 29);
            this.cBoxAdress.TabIndex = 14;
            this.cBoxAdress.Text = "Delivery to adress - +2.50 euro to whole sum";
            this.cBoxAdress.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(12, 539);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 46);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccept.Location = new System.Drawing.Point(145, 541);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(197, 43);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Accept parcel";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblFullSum
            // 
            this.lblFullSum.AutoSize = true;
            this.lblFullSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullSum.Location = new System.Drawing.Point(95, 462);
            this.lblFullSum.Name = "lblFullSum";
            this.lblFullSum.Size = new System.Drawing.Size(203, 20);
            this.lblFullSum.TabIndex = 17;
            this.lblFullSum.Text = "Full sum of all parcels:";
            // 
            // lblAvgW
            // 
            this.lblAvgW.AutoSize = true;
            this.lblAvgW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvgW.Location = new System.Drawing.Point(95, 498);
            this.lblAvgW.Name = "lblAvgW";
            this.lblAvgW.Size = new System.Drawing.Size(256, 20);
            this.lblAvgW.TabIndex = 18;
            this.lblAvgW.Text = "Average weight of a package:";
            // 
            // lBox
            // 
            this.lBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBox.FormattingEnabled = true;
            this.lBox.ItemHeight = 20;
            this.lBox.Location = new System.Drawing.Point(587, 318);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(367, 244);
            this.lBox.TabIndex = 19;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.rBtnExpress);
            this.gBox.Controls.Add(this.rBtnStandart);
            this.gBox.Controls.Add(this.rButtonIconomic);
            this.gBox.Location = new System.Drawing.Point(623, 82);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(308, 201);
            this.gBox.TabIndex = 20;
            this.gBox.TabStop = false;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearForm.Location = new System.Drawing.Point(374, 545);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(196, 34);
            this.btnClearForm.TabIndex = 21;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 597);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.lblAvgW);
            this.Controls.Add(this.lblFullSum);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cBoxAdress);
            this.Controls.Add(this.cBoxFragile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Калкулатор за доставки - F117510, Демира Милушева";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.RadioButton rButtonIconomic;
        private System.Windows.Forms.RadioButton rBtnStandart;
        private System.Windows.Forms.RadioButton rBtnExpress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBoxFragile;
        private System.Windows.Forms.CheckBox cBoxAdress;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblFullSum;
        private System.Windows.Forms.Label lblAvgW;
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.Button btnClearForm;
    }
}

