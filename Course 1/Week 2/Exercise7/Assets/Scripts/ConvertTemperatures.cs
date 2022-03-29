using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exercise 7 Solution
/// </summary>
public class ConvertTemperatures : MonoBehaviour
{
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
	{
        // declare int variables
        int originalFahrenheit;
        int celsius;
        int calculatedFahrenheit;

        // calculate and display for 0 degrees
        originalFahrenheit = 0;
        print("Original Fahrenheit: " + originalFahrenheit);
        celsius = (originalFahrenheit - 32) / 9 * 5;
        print("Calculated Celsius: " + celsius);
        calculatedFahrenheit = (celsius * 9) / 5 + 32;
        print("Calculated Fahrenheit: " + calculatedFahrenheit);

        // calculate and display for 32 degrees
        originalFahrenheit = 32;
        print("Original Fahrenheit: " + originalFahrenheit);
        celsius = (originalFahrenheit - 32) / 9 * 5;
        print("Calculated Celsius: " + celsius);
        calculatedFahrenheit = (celsius * 9) / 5 + 32;
        print("Calculated Fahrenheit: " + calculatedFahrenheit);

        // calculate and display for 212 degrees
        originalFahrenheit = 212;
        print("Original Fahrenheit: " + originalFahrenheit);
        celsius = (originalFahrenheit - 32) / 9 * 5;
        print("Calculated Celsius: " + celsius);
        calculatedFahrenheit = (celsius * 9) / 5 + 32;
        print("Calculated Fahrenheit: " + calculatedFahrenheit);

        // declare float variables
        float floatOriginalFahrenheit;
        float floatCelsius;
        float floatCalculatedFahrenheit;

        // calculate and display for 0 degrees using float
        floatOriginalFahrenheit = 0;
        print("Float Original Fahrenheit: " + floatOriginalFahrenheit);
        floatCelsius = (floatOriginalFahrenheit - 32) / 9 * 5;
        print("Float Calculated Celsius: " + floatCelsius);
        floatCalculatedFahrenheit = (floatCelsius * 9) / 5 + 32;
        print("Float Calculated Fahrenheit: " + floatCalculatedFahrenheit);

        // declare double variables
        double doubleOriginalFahrenheit;
        double doubleCelsius;
        double doubleCalculatedFahrenheit;

        // calculate and display for 0 degrees using double
        doubleOriginalFahrenheit = 0;
        print("Double Original Fahrenheit: " + doubleOriginalFahrenheit);
        doubleCelsius = (doubleOriginalFahrenheit - 32) / 9 * 5;
        print("Double Calculated Celsius: " + doubleCelsius);
        doubleCalculatedFahrenheit = (doubleCelsius * 9) / 5 + 32;
        print("Double Calculated Fahrenheit: " + doubleCalculatedFahrenheit);

    }
}
