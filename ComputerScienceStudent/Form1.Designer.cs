
namespace ComputerScienceStudent
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
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.softwareRadio = new System.Windows.Forms.RadioButton();
            this.infoSysRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.studentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.studentGroupBox.Controls.Add(this.hoursLabel);
            this.studentGroupBox.Controls.Add(this.label4);
            this.studentGroupBox.Controls.Add(this.softwareRadio);
            this.studentGroupBox.Controls.Add(this.infoSysRadio);
            this.studentGroupBox.Controls.Add(this.label3);
            this.studentGroupBox.Controls.Add(this.idBox);
            this.studentGroupBox.Controls.Add(this.label2);
            this.studentGroupBox.Controls.Add(this.nameBox);
            this.studentGroupBox.Controls.Add(this.label1);
            this.studentGroupBox.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupBox.Location = new System.Drawing.Point(71, 24);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(732, 460);
            this.studentGroupBox.TabIndex = 0;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student Data";
            // 
            // hoursLabel
            // 
            this.hoursLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursLabel.Location = new System.Drawing.Point(324, 369);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(327, 51);
            this.hoursLabel.TabIndex = 8;
            this.hoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Required Hours:";
            // 
            // softwareRadio
            // 
            this.softwareRadio.AutoSize = true;
            this.softwareRadio.Location = new System.Drawing.Point(324, 280);
            this.softwareRadio.Name = "softwareRadio";
            this.softwareRadio.Size = new System.Drawing.Size(332, 38);
            this.softwareRadio.TabIndex = 6;
            this.softwareRadio.TabStop = true;
            this.softwareRadio.Text = "Software Engineering";
            this.softwareRadio.UseVisualStyleBackColor = true;
            // 
            // infoSysRadio
            // 
            this.infoSysRadio.AutoSize = true;
            this.infoSysRadio.Location = new System.Drawing.Point(324, 218);
            this.infoSysRadio.Name = "infoSysRadio";
            this.infoSysRadio.Size = new System.Drawing.Size(327, 38);
            this.infoSysRadio.TabIndex = 5;
            this.infoSysRadio.TabStop = true;
            this.infoSysRadio.Text = "Information Systems";
            this.infoSysRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Academic Track:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(324, 125);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(327, 51);
            this.idBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Number:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(324, 50);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(327, 51);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // hoursBtn
            // 
            this.hoursBtn.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursBtn.Location = new System.Drawing.Point(182, 500);
            this.hoursBtn.Name = "hoursBtn";
            this.hoursBtn.Size = new System.Drawing.Size(245, 100);
            this.hoursBtn.TabIndex = 1;
            this.hoursBtn.Text = "Get Required Hours";
            this.hoursBtn.UseVisualStyleBackColor = true;
            this.hoursBtn.Click += new System.EventHandler(this.hoursBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(445, 500);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(245, 100);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.hoursBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(876, 630);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.hoursBtn);
            this.Controls.Add(this.studentGroupBox);
            this.Name = "Form1";
            this.Text = "Computer Science Student";
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton softwareRadio;
        private System.Windows.Forms.RadioButton infoSysRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hoursBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

