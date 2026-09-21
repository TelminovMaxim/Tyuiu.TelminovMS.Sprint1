using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TelminovMS.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            return int.TryParse(value, out int number) && number > 0;
        }
    }
}
