using System.Data;

namespace CoffeeSoft.App.General
{
    public class Validator
    {
        public static bool IsNull(string inputString)
        {
            inputString=inputString.Trim();
            if (inputString.Length > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static string TrimAll(string inputString)
        {
            string result = inputString.Replace(" ","");
            return result;
        }
        public static bool IsNull(string inputString,int minCharacter,int maxCharacter)
        {
            if (inputString.Trim().Length > minCharacter&&inputString.Trim().Length<maxCharacter)
            {
                return true;
            }
            else
                return false;
        }
        public static string IsExists(DataTable dtSource, string colNameCheck, string valueCheck)
        {
            string flag="";
            for (int i = 0; i < dtSource.Rows.Count; i++)
            {
                if (dtSource.Rows[i][colNameCheck].ToString().Trim().ToLower() == valueCheck.Trim().ToLower())
                {
                    flag = valueCheck + " đã có hãy chọn " + valueCheck + "mới";
                    break;
                }
                
            }
            return flag;
        }

        public static string IsExists(DataTable dtSource, string col1NameCheck, string value1Check, string col2NameCheck, string value2Check)
        {
            string flag = "";
            for (int i = 0; i < dtSource.Rows.Count; i++)
            {
                if (dtSource.Rows[i][col1NameCheck].ToString().Trim() == value1Check.Trim())
                {
                    flag = value1Check+" đã có hãy chọn "+ value1Check +"mới";
                    break;
                }
                if (dtSource.Rows[i][col2NameCheck].ToString().Trim() == value2Check.Trim())
                {
                    flag = value2Check + " đã có hãy chọn " + value2Check + "mới";
                    break;
                }
            }
            return flag;
        }
    }
}
