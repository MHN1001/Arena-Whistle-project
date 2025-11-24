using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsPaymentMethod
    {
        public static Dictionary<string, int> GetPaymentMethods()
        {
            return ClsPaymentMethodDA.GetPaymentMethods();
        }

        public static string GetMethodName(int paymentMethodID)
        {
            return ClsPaymentMethodDA.GetPaymentMethodNameByID(paymentMethodID);
        }
    }
}
