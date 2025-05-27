using OOP2;

namespace OOP4
{
    public static class Utils
    {
        public static int Tuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year;
        }

        public static bool CheckSinhNhat(this Employee emp)
        {
            // Lấy tháng hiện tại
            int currentMonth = DateTime.Now.Month;
            // Lấy tháng sinh của nhân viên
            int birthMonth = emp.Birthday.Month;

            // So sánh tháng hiện tại với tháng sinh
            return currentMonth == birthMonth;
        }
    }
    
}
