using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class CalculatorEngine
    {
        public string Calculate(string operate, string firstOperand, string secondOperand, int maxOutputSize = 8)
        {
            double result;
            switch (operate)
            {
                case "+":
                    return (Convert.ToDouble(firstOperand) + Convert.ToDouble(secondOperand)).ToString();
                case "-":
                    return (Convert.ToDouble(firstOperand) - Convert.ToDouble(secondOperand)).ToString();
                case "X":
                    return (Convert.ToDouble(firstOperand) * Convert.ToDouble(secondOperand)).ToString();
                case "÷":
                    // Not allow devide be zero
                    if (secondOperand != "0")
                    {
                       
                        string[] parts;
                        int remainLength;

                        result = (Convert.ToDouble(firstOperand) / Convert.ToDouble(secondOperand));
                        // split between integer part and fractional part
                        parts = result.ToString().Split('.');
                        // if integer part length is already break max output, return error
                        if (parts[0].Length > maxOutputSize)
                        {
                            return "E";
                        }
                        // calculate remaining space for fractional part.
                        remainLength = maxOutputSize - parts[0].Length - 1;
                        // trim the fractional part gracefully. =
                        return result.ToString("N" + remainLength);
                    }
                    break;
                case "1/X":
                    result = Convert.ToDouble(firstOperand);
                    result = 1.0 / result;
                    
                    if (result.ToString() is "E" || result.ToString().Length > 8)
                    {
                        return result.ToString().Substring(0,8);
                    }
                     else return result.ToString();

                   
                   
                  
                                   
                    break;
                case "SQRT":
                    result = Convert.ToDouble(firstOperand);
                    result = Math.Sqrt(result);
                    Console.WriteLine(result);
                    if (result.ToString() is "E" || result.ToString().Length > 8)
                    {
                        return result.ToString().Substring(0, 8);
                    }
                    else return result.ToString();


                    return result.ToString();
                    break;
                    
                    //else return "E";
                    break;
                    
                case "%":
               /*     result = (Convert.ToDouble(secondOperand) / 100) * Convert.ToDouble(firstOperand);
                    return result.ToString();*/
                    break;
                   
                    //your code here
                    
            }
            return "E";
        }

    }
}
