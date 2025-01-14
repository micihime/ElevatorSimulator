using InstagramDelegates;

internal class Program
{
    private static void Main(string[] args)
    {
        Instagram instagram = new Instagram();

        InstagramFilter filter = new InstagramFilter();

        Instagram.InstagramFilterHandler handler = filter.RemoveRedEyes;
        handler += filter.Beautify;
        handler += filter.Retouch;
        handler += Program.NewCustomFilter;

        instagram.ProcessPhoto(new Photo(), handler);
    }

    internal static void NewCustomFilter(Photo photo)
    {
        Console.WriteLine("Applying New Custom Filter...");
    }
}