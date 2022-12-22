//Shortcut control k + e to remove un used namespaces


internal static class DateUtil
{
    public static int YearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }
    public static int YearOfBirth(DateTime dateOfBirth)
    {
        if (dateOfBirth == null) return 0; // shorthand no braces needed

        return dateOfBirth.Year;
    }
    public static int Age(DateTime dateOfBirth)
    {
        if (dateOfBirth == null) return 0;

        return DateTime.Now.Year - dateOfBirth.Year;
    }
}

