/*
####################################################################################################################
####                                             class userResponse                                             ####
####    contains the definition for the JSON response sent by the pr0gramm API when calling profile info        ####
####    without being logged in.                                                                                ####
####    Response fields:                                                                                        ####
####        - user => user object (see userObject.cs)                                                           ####
####        - comments => array of comment objects (see commentObject.cs)                                       ####
####        - comment count => long integer                                                                     ####
####        - "public likes" setting => boolean                                                                 ####
####        - comment favourites => array of comment objects (see commentObject.cs)                             ####
####        - comment favourite count => long integer                                                           ####
####        - uploads by user => array of user uploads (see uploadObject.cs)                                    ####
####        - amount of uploads => long integer                                                                 ####
####        - user favourites => array of upload objects (see uploadObject.cs)                                  ####
####        - amount of favourites => long integer                                                              ####
####        - amount of tags set by user => long integer                                                        ####
####        - user bages => array of badge objects (see badgeObject.cs)                                         ####
####        - amount of followed profiles ("stelzen") => long integer                                           ####
####        - amount of linked apps(?) => string array until I can find a profile returning a value,            ####
####          returned empty array for all accounts checked for testing                                         ####
####        - info on pr0mium subscription => boolean                                                           ####
####        - "ts" value (probably for internal use) => long integer                                            ####
####        - cache => string, only used when requesting profile info without being logged in.                  ####
####          Assumed usage: info if profile has been accessed before.                                          ####
####        - "rt" value (probably for internal use) => long integer                                            ####
####        - "qc" value (probably for internal use) => long integer                                            ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class UserResponse
    {

        public UserObject User {get; set;}
        public CommentObject[] Comments {get; set;}
        public long CommentCount {get; set;}
        public bool LikesArePublic {get; set;}
        public CommentObject[] Comments_likes {get; set;}
        public long CommentLikesCount {get; set;}
        public UploadObject[] Uploads {get; set;}
        public long UploadCount {get; set;}
        public UploadObject[] Likes {get; set;}
        public long LikeCount {get; set;}
        public long TagCount {get; set;}
        public BadgeObject[] Badges {get; set;}
        public long FollowCount {get; set;}
        public string[] AppLinks {get; set;}
        public bool Following {get; set;}
        public bool Subscribed {get; set;}
        public long Ts {get; set;}
        public string Cache {get; set;}
        public long Rt {get; set;}
        public long Qc {get; set;}

    }


}