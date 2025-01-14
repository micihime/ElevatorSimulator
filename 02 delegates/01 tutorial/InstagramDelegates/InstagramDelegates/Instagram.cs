namespace InstagramDelegates
{
    internal class Instagram
    {
        // Tieto tri filtre sú natvrdo nakódované - bez možnosti dynamického prispôsobenia.
        internal void ProcessPhoto(Photo photo) 
        { 
            InstagramFilter filter = new InstagramFilter();
            filter.RemoveRedEyes(photo);
            filter.Beautify(photo);
            filter.Retouch(photo);
        }
    }
}
