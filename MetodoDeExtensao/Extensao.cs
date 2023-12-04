namespace MetodoDeExtensao;

public static class Extensao
{
    public static int DateToInt(this DateTime date)
    {
        var dataString = date.Year.ToString("D4") + date.Month.ToString("D2");
        return Convert.ToInt32(dataString);
    }
}
