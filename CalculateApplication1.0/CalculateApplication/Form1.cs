using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculateApplication
{
    public partial class CalculatorForm : Form
    {
        // 累计答题结果：正确数
        private int rightNum = 0;

        // 累计答题结果：错误数
        private int falseNum = 0;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /**
       * 
       * 开始答题
       * 
       * */
        private void start_Click(object sender, EventArgs e)
        {
            // 根据用户选择设置题目的操作数
            setSubjectOpt();

            // 根据用户选择的难易程度产生2个随机数作为操作数
            setCalculateLevel();

            // 页面初始时等号和结果输入框设置为不可见，开始答题后设置为可见
            equal.Visible = true;
            answer.Visible = true;
            answer.Text = null;
        }

        /**
       * 
       * 提交答题
       * 
       * */
        private void submit_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (add.Checked)
            {
                result = Convert.ToInt16(opt1.Text) + Convert.ToInt16(opt2.Text);
            }
            else if (sub.Checked)
            {
                result = Convert.ToInt16(opt1.Text) - Convert.ToInt16(opt2.Text);
            }
            else if (mul.Checked)
            {
                result = Convert.ToInt16(opt1.Text) * Convert.ToInt16(opt2.Text);
            }
            else if (div.Checked)
            {
                result = Convert.ToInt16(opt1.Text) / Convert.ToInt16(opt2.Text);
            }

            if (Convert.ToString(result).Equals(answer.Text))
            {
                // 累计答题结果：正确数
                rightNum++;
            }
            else
            {
                // 累计答题结果：错误数
                falseNum++;
            }

            totalNumber.Text = Convert.ToString(rightNum + falseNum);
            rightNumber.Text = Convert.ToString(rightNum);
            falseNumber.Text = Convert.ToString(falseNum);

            // 提交一道题后，自动开始出新题（开始答题）
            start_Click(sender, e);
        }

        /**
        * 
        * 结束答题
        * 
        * */
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否结束此次答题？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //"确定"，结束答题
                rightNumber.Text = null;
                falseNumber.Text = null;
                totalNumber.Text = null;
                opt.Text = null;
                opt1.Text = null;
                opt2.Text = null;
                equal.Visible = false;
                answer.Visible = false;
                rightNum = 0;
                falseNum = 0;
            }
            else
            {
                //"取消"，继续答题
                return;
            }
        }

        /**
       * 
       * 当给出答案时，用户按回车，则自动提交答案，开始下一道题
       * 
       * */
        private void answer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit_Click(sender, e);
            }

        }

        /**
        * 
        * 设置操作符
        * 
        * */
        private void setSubjectOpt()
        {
            if (add.Checked)
            {
                opt.Text = "+";
            }
            else if (sub.Checked)
            {
                opt.Text = "-";
            }
            else if (mul.Checked)
            {
                opt.Text = "*";
            }
            else if (div.Checked)
            {
                opt.Text = "/";
            }
        }

        /**
         * 
         * 根据题目的难易程度，产生随机操作数，并设置给界面
         * 
         * */
        private void setCalculateLevel()
        {
            if (level1.Checked)
            {
                // 简单
                setRandonOperand(1, 9);
            }
            else if (level2.Checked)
            {
                // 适中
                setRandonOperand(10, 50);
            }
            else if (level3.Checked)
            {
                // 偏难
                setRandonOperand(51, 100);
            }
        }

        /**
         * 
         * 根据指定的范围产生随机的2个操作数，并设置给界面
         * 
         * */
        private void setRandonOperand(int minValue, int maxValue)
        {
            Random ran = new Random();
            int ran1 = ran.Next(minValue, maxValue);
            int ran2 = ran.Next(minValue, maxValue);

            if (sub.Checked && ran1 < ran2)
            {
                // 处理减法结果是负数
                int temp = ran1;
                ran1 = ran2;
                ran2 = temp;
            }
            else if (div.Checked)
            {
                ran1 = ran2 * ran1;
            }

            opt1.Text = Convert.ToString(ran1);
            opt2.Text = Convert.ToString(ran2);
        }
   
    }
}
