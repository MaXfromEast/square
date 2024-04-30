
namespace Calculation
{
    public  class  Figures
    {  
            public static class Circle
            {
                public static double CalcCircleSq(double radius)
                {
                    double sq = Math.Pow(radius, 2) * Math.PI;
                    return sq;
                }
            }

            public static class Triangle
            {
                public static bool IsRectangular(double a, double b, double c)
                {
                    if ((Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) || (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) || (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                public static double CalcTriangleSq(double a, double b, double c)
                {
                    double p = (a + b + c) / 2;
                    double sq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return sq;
                }
            }
    }
    
}
