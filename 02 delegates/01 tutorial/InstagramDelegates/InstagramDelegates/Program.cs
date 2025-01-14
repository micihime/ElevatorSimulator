using InstagramDelegates;

Instagram instagram = new Instagram();

InstagramFilter filter = new InstagramFilter();

Instagram.InstagramFilterHandler handler = filter.Beautify;

instagram.ProcessPhoto(new Photo(), handler);