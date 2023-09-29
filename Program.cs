using PupilmoniumFights;
using System.Diagnostics;

public static class Base
{
    private static void Main(string[] args)
    {
#if DEBUG
        string currentPath = "C:\\Users\\ewolf\\source\\repos\\PupilmoniumBase";
        string translationPath = Path.Combine(currentPath, "recourses\\translation\\Translation_en");
        File.WriteAllText(translationPath, Translation.AttackTranslate.SaveCurrentTranslationRegion("en").RegionSaveString);
        Translation.AttackTranslate.InitTranslate(translationPath);

#endif

        Console.WriteLine("Pupilmonium - Pupil (student) (pande)monium (wild and noisy disorder or confusion) ");
        Console.WriteLine(Translation.AttackTranslate.Credits);
        Console.ReadKey();


    }
}