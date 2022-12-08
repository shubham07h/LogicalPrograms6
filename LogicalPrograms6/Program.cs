using System;


class Program
{
    public  double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = celsius * 9 / 5 + 32;
        return fahrenheit;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return celsius;
    }
}
