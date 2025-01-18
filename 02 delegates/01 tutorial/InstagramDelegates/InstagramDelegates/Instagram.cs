namespace InstagramDelegates
{
    internal class Instagram
    {
        // Výber filtrov je ponechaný na klientovi, čo umožňuje väčšiu flexibilitu, ale zároveň vyžaduje správne používanie na strane klienta.
        internal void ProcessPhoto(Photo photo, Action<Photo> filterHandler) 
        {
            filterHandler(photo);
        }
    }
}
