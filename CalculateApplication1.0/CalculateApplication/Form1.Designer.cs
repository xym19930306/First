namespace CalculateApplication
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.div = new System.Windows.Forms.RadioButton();
            this.mul = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.sub = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.RadioButton();
            this.level2 = new System.Windows.Forms.RadioButton();
            this.level3 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.opt = new System.Windows.Forms.Label();
            this.opt2 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.falseNumber = new System.Windows.Forms.Label();
            this.rightNumber = new System.Windows.Forms.Label();
            this.totalNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.div);
            this.panel1.Controls.Add(this.mul);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.sub);
            this.panel1.Location = new System.Drawing.Point(29, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 140);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "选择运算";
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(18, 112);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(29, 16);
            this.div.TabIndex = 8;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            // 
            // mul
            // 
            this.mul.AutoSize = true;
            this.mul.Location = new System.Drawing.Point(18, 90);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(29, 16);
            this.mul.TabIndex = 6;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Checked = true;
            this.add.Location = new System.Drawing.Point(18, 42);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(29, 16);
            this.add.TabIndex = 2;
            this.add.TabStop = true;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            // 
            // sub
            // 
            this.sub.AutoSize = true;
            this.sub.Location = new System.Drawing.Point(18, 64);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(29, 16);
            this.sub.TabIndex = 4;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "选择难易";
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Checked = true;
            this.level1.Location = new System.Drawing.Point(19, 42);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(47, 16);
            this.level1.TabIndex = 11;
            this.level1.TabStop = true;
            this.level1.Text = "简单";
            this.level1.UseVisualStyleBackColor = true;
            // 
            // level2
            // 
            this.level2.AutoSize = true;
            this.level2.Location = new System.Drawing.Point(19, 74);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(47, 16);
            this.level2.TabIndex = 12;
            this.level2.Text = "适中";
            this.level2.UseVisualStyleBackColor = true;
            // 
            // level3
            // 
            this.level3.AutoSize = true;
            this.level3.Location = new System.Drawing.Point(19, 112);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(47, 16);
            this.level3.TabIndex = 13;
            this.level3.Text = "偏难";
            this.level3.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.BackColor = System.Drawing.SystemColors.Control;
            this.opt1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opt1.Location = new System.Drawing.Point(45, 204);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(0, 12);
            this.opt1.TabIndex = 8;
            this.opt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(200, 201);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(59, 21);
            this.answer.TabIndex = 9;
            this.answer.Visible = false;
            this.answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answer_KeyDown_1);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(51, 305);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(89, 36);
            this.start.TabIndex = 10;
            this.start.Text = "开始答题";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(179, 305);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(89, 36);
            this.submit.TabIndex = 11;
            this.submit.Text = "提交答案";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.level3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.level2);
            this.panel2.Controls.Add(this.level1);
            this.panel2.Location = new System.Drawing.Point(137, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 140);
            this.panel2.TabIndex = 12;
            // 
            // opt
            // 
            this.opt.AutoSize = true;
            this.opt.Location = new System.Drawing.Point(87, 204);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(0, 12);
            this.opt.TabIndex = 13;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(123, 204);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(0, 12);
            this.opt2.TabIndex = 14;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(161, 204);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(11, 12);
            this.equal.TabIndex = 15;
            this.equal.Text = "=";
            this.equal.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.falseNumber);
            this.panel3.Controls.Add(this.rightNumber);
            this.panel3.Controls.Add(this.totalNumber);
            this.panel3.Location = new System.Drawing.Point(288, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 140);
            this.panel3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "错误题数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "正确题数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "总答题数：";
            // 
            // falseNumber
            // 
            this.falseNumber.AutoSize = true;
            this.falseNumber.Location = new System.Drawing.Point(84, 94);
            this.falseNumber.Name = "falseNumber";
            this.falseNumber.Size = new System.Drawing.Size(0, 12);
            this.falseNumber.TabIndex = 2;
            // 
            // rightNumber
            // 
            this.rightNumber.AutoSize = true;
            this.rightNumber.Location = new System.Drawing.Point(84, 64);
            this.rightNumber.Name = "rightNumber";
            this.rightNumber.Size = new System.Drawing.Size(0, 12);
            this.rightNumber.TabIndex = 1;
            // 
            // totalNumber
            // 
            this.totalNumber.AutoSize = true;
            this.totalNumber.Location = new System.Drawing.Point(84, 33);
            this.totalNumber.Name = "totalNumber";
            this.totalNumber.Size = new System.Drawing.Size(0, 12);
            this.totalNumber.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "结束答题";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.opt1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton level3;
        private System.Windows.Forms.RadioButton level2;
        private System.Windows.Forms.RadioButton level1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton div;
        private System.Windows.Forms.RadioButton mul;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.RadioButton sub;
        private System.Windows.Forms.Label opt1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label opt;
        private System.Windows.Forms.Label opt2;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalNumber;
        private System.Windows.Forms.Label falseNumber;
        private System.Windows.Forms.Label rightNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

