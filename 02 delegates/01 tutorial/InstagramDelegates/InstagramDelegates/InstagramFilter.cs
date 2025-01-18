
namespace InstagramDelegates
{
    // Táto trieda nemá implementovaný mechanizmus na rozšírenie filtrov bez priamej modifikácie,
    // čo obmedzuje jej flexibilitu.
    internal class InstagramFilter
    {
        internal void Beautify(Photo photo)
        {
            Console.WriteLine("Beautifying...");
        }

        internal void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Removing red eyes...");
        }

        internal void Retouch(Photo photo)
        {
            Console.WriteLine("Retouching...");
        }
    }
}
