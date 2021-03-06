﻿using System.Collections.Generic;

namespace InstaSharper.Classes.Models
{
    public class InstaUser : InstaUserShort
    {
        public InstaUser(InstaUserShort instaUserShort)
        {
            Pk = instaUserShort.Pk;
            UserName = instaUserShort.UserName;
            FullName = instaUserShort.FullName;
            IsPrivate = instaUserShort.IsPrivate;
            ProfilePicture = instaUserShort.ProfilePicture;
            ProfilePictureId = instaUserShort.ProfilePictureId;
            IsVerified = instaUserShort.IsVerified;
        }

        public bool HasAnonymousProfilePicture { get; set; }
        public string Biography { get; set; }
        public string ExternalUrl { get; set; }
        public List<MediaImage> HdProfileImages { get; set; } = new List<MediaImage>();
        public MediaImage HdProfilePicture { get; set; }
        public bool ShowConversionEditEntry { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public int CountryCode { get; set; }
        public long NationalNumber { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
    }
}
