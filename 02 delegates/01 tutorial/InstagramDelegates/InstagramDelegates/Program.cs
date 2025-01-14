using InstagramDelegates;

Instagram instagram = new Instagram();

InstagramFilter filter = new InstagramFilter();

Instagram.InstagramFilterHandler handler = filter.RemoveRedEyes;
handler += filter.Beautify;
handler += filter.Retouch;

instagram.ProcessPhoto(new Photo(), handler);