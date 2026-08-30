namespace RomanNumerals;

public static class RomanNumeralConverter
{
    private static readonly (int Value, string Symbol)[] StandardNumerals =
    {
        (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
        (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
        (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
    };

    private static readonly Dictionary<char, int> Values = new()
    {
        ['I'] = 1,
        ['V'] = 5,
        ['X'] = 10,
        ['L'] = 50,
        ['C'] = 100,
        ['D'] = 500,
        ['M'] = 1000
    };

    public static int ToDecimal(string roman)
    {
        if (string.IsNullOrWhiteSpace(roman))
            throw new ArgumentException("A Roman numeral is required.", nameof(roman));

        var total = 0;

        for (var index = 0; index < roman.Length; index++)
        {
            if (!Values.TryGetValue(roman[index], out var value))
                throw new ArgumentException("Invalid Roman numeral.", nameof(roman));

            var nextValue = index + 1 < roman.Length && Values.TryGetValue(roman[index + 1], out var next)
                ? next
                : 0;

            // a smaller numeral before a larger numeral is subtracted: IV = 5 - 1
            total += value < nextValue ? -value : value;
        }

        // recreate the numeral in its standard form to validate repetitions,
        // allowed subtraction pairs, and the maximum value of 3999
        if (total > 3999 || ToRoman(total) != roman)
            throw new ArgumentException("Invalid Roman numeral.", nameof(roman));

        return total;
    }

    private static string ToRoman(int number)
    {
        var result = "";

        foreach (var (value, symbol) in StandardNumerals)
        {
            while (number >= value)
            {
                result += symbol;
                number -= value;
            }
        }

        return result;
    }
}
