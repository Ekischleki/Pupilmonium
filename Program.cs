using PupilmoniumFights;

public static class Base
{
    private static void Main(string[] args)
    {
        var result = AttackTranslate.SaveCurrentTranslationRegion("en");
        AttackTranslate.InitTranslate(result);
    }
}