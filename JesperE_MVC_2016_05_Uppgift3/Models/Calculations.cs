namespace JesperE_MVC_2016_05_Uppgift3.Models
{
    public static class Calculations
    {
        public static double GetCurrentSpeed(int distanceCovered, int time)
        {
            return distanceCovered/time;
        }
    }
}