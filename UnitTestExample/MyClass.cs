using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class MyClass
    {
        /// <summary>
        /// 加總數值
        /// </summary>
        /// <param name="Num1">數值1</param>
        /// <param name="Num2">數值2</param>
        /// <returns></returns>
        public int Sum(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        /// <summary>
        /// 驗證字串中是否有特殊字元
        /// </summary>
        /// <param name="validString">驗證字串</param>
        /// <returns></returns>
        public bool hasSpecialCharacter(string validString)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[^~!@#$%^&*()_?\s+]+$");
            return !reg.IsMatch(validString);
        }
    }
}
