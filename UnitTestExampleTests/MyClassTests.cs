using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Tests
{
    [TestClass()]
    public class MyClassTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //3A Pattern

            /* Arrange:
             * 初始化環境
             * 建立測試行為
             * 設定預期結果
             */
            #region Arrange
            var myClass = new MyClass();
            //初始化變數
            int a = 1;
            int b = 2;
            //預期數值
            var expected = 3;
            #endregion

            /*
             * Action: 執行測試
             */
            #region Action
            //執行Sum方法
            var actual = myClass.Sum(a, b);
            #endregion

            /*
             * Assert: 驗證是否如預期結果
             */
            #region Assert
            //驗證是否為空值，這裡其實可以不用做
            Assert.IsNotNull(actual);
            //驗證結果是否如預期
            Assert.AreEqual(expected, actual);
            #endregion
        }

        [TestMethod()]
        public void hasSpecialCharacterTest()
        {
            #region Arrange
            var myClass = new MyClass();
            string s = "Hello, how are you?";
            var expected = true;
            #endregion

            #region Action
            var actual = myClass.hasSpecialCharacter(s);
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
    }
}