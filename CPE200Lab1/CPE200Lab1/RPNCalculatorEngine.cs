using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CPE200Lab1
{
    class RPNCalculatorEngine:CalculatorEngine
    {
        public string Process(string str)
        {
            string result;
            string operate, firstoprand, secondoprand;
            Stack x = new Stack();

            List<string> parts = str.Split(' ').ToList<string>();
            for(int i = 0; i < parts.Count; i++)
            {
                if (parts[i] == "+" || parts[i] == "-" || parts[i] == "X" || parts[i] == "÷")
                {

                    operate = parts[i];
                    secondoprand = x.Pop().ToString();
                    firstoprand = x.Pop().ToString();
                    result = calculate(operate,firstoprand,secondoprand);
                    x.Push(result);
                }
                else
                {
                    x.Push(parts[i]);
                }
            }
            return x.Pop().ToString();
        }
    }
}
