using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using linq_class.Entities;
using linq_class.Services;

namespace AutomatedTest
{
    public class TestRunner
    {
        public int Points {get; private set;}

        public void Run()
        {
            MockData.Dataset1 dataset = new MockData.Dataset1();
            Points = 0;
        }

        private void TestCustomerService(Context ctx)
        {
            CustomerService srv = new CustomerService(ctx);

        }



        #region Testing tools
        private static bool ResultEquals<T>(Func<T> func, T value)
        {
            T testValue = func();
            return testValue.Equals(value);
        }

        private static bool ExcpectException<T>(Func<T> func)
        {
            try
            {
                T values = func();
            }
            catch (Exception)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
