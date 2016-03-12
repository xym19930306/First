using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CalculateApplication
{
    class CalculatorExpressionUtil
    {
      /**
	 * 该方法只适合随机产生有4个操作数的四则运算表达式
         *
	 * 4个操作数的表达式形式主要有以下7种
	 * 1： (6+5)*2-1
	 * 2： (6+5*2)-1
	 * 3： 6+（5*2）-1
	 * 4： 6+（5*2-1）
	 * 5： 6+5*（2-1）
	 * 6： （6+5）*（2-1）
	 * 7： 6+5*2-1
	 * 
	 * 
	 * 
	 */
	public static String create4Exp(int minValue,int maxValue, Dictionary<String, bool> dictionary){

		Random ran = new Random();
		StringBuilder result = new StringBuilder();
		// 产生随机操作数
		int ranOpt = ran.Next(minValue,maxValue);
		// 随机产生 +,-,*,/
		int ranO = ran.Next(5);
		// 随机产生表达式基本模式
		int i = ran.Next(7) + 1;
		if (i == 1) {
            //i=1   (6+5)*2-1
            //i=2   (6+5*2)-1
			result.Append("(");
			result.Append(ranOpt);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
            if(i==1){
			result.Append(")");
            }
			ranO = ran.Next(3);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
            if(i==2){
			result.Append(")");
            }
			ranO = ran.Next(3);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);

		} else if (i == 3 || i == 4) {
			result.Append(ranOpt);
			result.Append(conver2operator(ranO));
			result.Append("(");
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
            ranO = ran.Next(3);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
			if (i == 3) {
				result.Append(")");
			}
            ranO = ran.Next(3);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
			if (i == 4) {
				result.Append(")");
			}
		} else if (i == 5 || i == 6) {
			if (i == 6) {
				result.Append("(");
			}
			result.Append(ranOpt);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
			if (i == 6) {
				result.Append(")");
			}
            ranO = ran.Next(3);
			result.Append(conver2operator(ranO));

			result.Append("(");
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
            ranO = ran.Next(3);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
			result.Append(")");

		} else {
			// 1+2-3*5
			result.Append(ranOpt);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);

            ranO = ran.Next(3);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);

            ranO = ran.Next(3);
			result.Append(conver2operator(ranO));
            ranOpt = ran.Next(minValue, maxValue);
			result.Append(ranOpt);
		}
		
            String resultExpression = result.ToString();
            if (dictionary.ContainsKey(resultExpression) && dictionary[resultExpression])
            {
                // 出现答对的重复题，重新生成exp
                resultExpression  = create4Exp(minValue,maxValue,dictionary);
             }

		return resultExpression ;

	}

    public static String create2Exp(int minValue, int maxValue, String oprator, Dictionary<String, bool> dictionary)
    {
        StringBuilder expression = new StringBuilder();
        Random ran = new Random();
        int ran1 = ran.Next(minValue, maxValue);
        int ran2 = ran.Next(minValue, maxValue);

        if (oprator.Equals("-") && ran1 < ran2)
        {
            // 处理减法结果是负数
            int temp = ran1;
            ran1 = ran2;
            ran2 = temp;
        }
        else if (oprator.Equals("/"))
        {
            ran1 = ran2 * ran1;
        }

        expression.Append(ran1);
        expression.Append("  ");
        expression.Append(oprator);
        expression.Append("  ");
        expression.Append(ran2);
        expression.Append("  ");

        String resultExpression = result.ToString();
        if (dictionary.ContainsKey(resultExpression) && dictionary[resultExpression])
        {
            //出现答对的重复题，重新生成exp
            resultExpression  = create2Exp(minValue,maxValue,dictionary);
         }

         return resultExpression ;
    }

	public static String conver2operator(int ranOperator) {
		switch (ranOperator) {
		case 1:
			return "+";
		case 2:
			return "-";
		case 3:
			return "*";
		case 4:
			return "/";
		default:
			return "+";
		}
	}


    }
}
