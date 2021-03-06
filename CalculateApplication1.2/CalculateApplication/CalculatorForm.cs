﻿using System;
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

        // 存储答过的题：key-题目表达式  value-true:答对，false:答错
        private Dictionary<String, bool> dictionary = new Dictionary<String, bool>();

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
            mixAnswer.Text = null;
            subjectPanel.Visible = true;
            int minValue = 1;
            int maxValue = 9;
            if (level1.Checked)
            {
                // 简单
                minValue = 1;
                maxValue = 9;
            }
            else if (level2.Checked)
            {
                // 适中
                minValue = 10;
                maxValue = 50;
            }
            else if (level3.Checked)
            {
                // 偏难
                minValue = 51;
                maxValue = 100;
            }

            String resultExpression = null;
            if (mix.Checked)
            {
                // 选择混合运算场合：随机生成4个随机数，3个随机操作符
               // resultExpression = creatExpression(minValue, maxValue, 7, null);
                resultExpression = CalculatorExpressionUtil.create4Exp(minValue, maxValue,dictionary);
            }
            else
            {
                // 选择除混合运算之外的
                resultExpression = CalculatorExpressionUtil.create2Exp(minValue, maxValue, getSubjectOpt(),dictionary);
                // 注释：        先CTRL+K，然后CTRL+C
                // 取消注释： 先CTRL+K，然后CTRL+U
                //// 根据用户选择设置题目的操作数
                //setSubjectOpt();

                //// 根据用户选择的难易程度产生2个随机数作为操作数
                //setCalculateLevel();

                //// 页面初始时等号和结果输入框设置为不可见，开始答题后设置为可见
                //equal.Visible = true;
                //answer.Visible = true;
                //subjectPanel1.Visible = true;
                //answer.Text = null;
            }

           

            exp.Text = resultExpression;
        }
        /**
       * 
       * 提交答题
       * 
       * */
        private void submit_Click(object sender, EventArgs e)
        {
            Object result = new DataTable().Compute(exp.Text, null);
            
            // TODO: "1+2/0-1" 重新生成表达式
            
            String resultStr = result.ToString();
            if (resultStr.Equals(mixAnswer.Text))
            {
                // 累计答题结果：正确数
                rightNum++;
                dictionary.Add(exp.Text,true);
                     
            }
            else
            {
                // 累计答题结果：错误数
                falseNum++;
                dictionary.Add(exp.Text, false);
             
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
                subjectPanel.Visible = false;
                rightNum = 0;
                falseNum = 0;
                dictionary.Clear();
            }
            else
            {
                //"取消"，继续答题
                return;
            }
        }


        private String getSubjectOpt()
        {
            if (add.Checked)
            {
                return "+";
            }
            else if (sub.Checked)
            {
                return  "-";
            }
            else if (mul.Checked)
            {
                return  "*";
            }
            else if (div.Checked)
            {
                return "/";
            }
            else
            {
                return "+";
            }
        }

        private String creatExpression(int minValue, int maxValue, int num)
        {
            StringBuilder expression = new StringBuilder();
            Random ran = new Random();
     
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {

                    int ranOperand = ran.Next(minValue, maxValue);
                    expression.Append(ranOperand);
                    expression.Append("  ");
                }
                else 
                {
                    int ranOperator = ran.Next(1, 5);
                    expression.Append(CalculatorExpressionUtil.conver2operator(ranOperator));
                    expression.Append("  ");
                }
            }

            return expression.ToString();
        }

        /**
         * 
         * 当给出答案时，用户按回车，则自动提交答案，开始下一道题
         * 
         * */
        private void mixAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit_Click(sender, e);
            }
        }
    }
}
