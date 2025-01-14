namespace InstagramDelegates
{
    internal class Instagram
    {
        public delegate void InstagramFilterHandler(Photo photo);

        // Výber filtrov je ponechaný na klientovi, čo umožňuje väčšiu flexibilitu, ale zároveň vyžaduje správne používanie na strane klienta.
        internal void ProcessPhoto(Photo photo, InstagramFilterHandler filterHandler) 
        {
            filterHandler(photo);
        }
    }
}
