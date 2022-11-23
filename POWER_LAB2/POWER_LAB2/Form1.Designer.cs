namespace POWER_LAB2
{
    partial class Lab2_Power
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2_Power));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.answerBox = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.picDestiny = new System.Windows.Forms.PictureBox();
            this.infBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDestiny)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(69, 47);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(109, 22);
            this.txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(69, 103);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(109, 22);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number:";
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.answerBox);
            this.grpBox1.Controls.Add(this.btnCalculate);
            this.grpBox1.Controls.Add(this.btnReset);
            this.grpBox1.Controls.Add(this.label3);
            this.grpBox1.Controls.Add(this.label2);
            this.grpBox1.Controls.Add(this.txtBox2);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.txtBox1);
            this.grpBox1.Location = new System.Drawing.Point(13, 16);
            this.grpBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBox1.Size = new System.Drawing.Size(218, 302);
            this.grpBox1.TabIndex = 3;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Multiplier";
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.answerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerBox.ForeColor = System.Drawing.Color.Black;
            this.answerBox.Location = new System.Drawing.Point(69, 160);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(109, 25);
            this.answerBox.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 232);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 48);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(107, 232);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 48);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Multiplier:";
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.btnExit);
            this.grpBox2.Controls.Add(this.btnHide);
            this.grpBox2.Controls.Add(this.btnData);
            this.grpBox2.Controls.Add(this.btnPicture);
            this.grpBox2.Controls.Add(this.picDestiny);
            this.grpBox2.Controls.Add(this.infBox);
            this.grpBox2.Location = new System.Drawing.Point(248, 16);
            this.grpBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBox2.Size = new System.Drawing.Size(459, 302);
            this.grpBox2.TabIndex = 4;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Information";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(351, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(236, 232);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(95, 48);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(123, 232);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(95, 48);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPicture.Location = new System.Drawing.Point(9, 232);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(95, 48);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // picDestiny
            // 
            this.picDestiny.Image = ((System.Drawing.Image)(resources.GetObject("picDestiny.Image")));
            this.picDestiny.Location = new System.Drawing.Point(0, 22);
            this.picDestiny.Name = "picDestiny";
            this.picDestiny.Size = new System.Drawing.Size(459, 191);
            this.picDestiny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDestiny.TabIndex = 5;
            this.picDestiny.TabStop = false;
            this.picDestiny.Visible = false;
            this.picDestiny.Click += new System.EventHandler(this.picDestiny_Click);
            // 
            // infBox
            // 
            this.infBox.Location = new System.Drawing.Point(0, 19);
            this.infBox.Name = "infBox";
            this.infBox.Size = new System.Drawing.Size(459, 194);
            this.infBox.TabIndex = 6;
            this.infBox.Text = resources.GetString("infBox.Text");
            this.infBox.Visible = false;
            this.infBox.Click += new System.EventHandler(this.infBox_Click);
            // 
            // Lab2_Power
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.grpBox2);
            this.Controls.Add(this.grpBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lab2_Power";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 By Tony Power";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDestiny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.Label answerBox;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label infBox;
        private System.Windows.Forms.PictureBox picDestiny;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnPicture;
    }
}

