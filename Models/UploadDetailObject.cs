/*
####################################################################################################################
####                                       class UploadDetailObject                                             ####
####    contains the definition of upload objects used by the pr0gramm API when returning upload info           ####
####    object properties:                                                                                      ####
####        - upload ID => long integer, internal ID of upload                                                  ####
####        - "promoted"/"beliebt" id ? => long integer                                                         ####
####        - ID of uploader => long integer                                                                    ####
####        - number of upvotes => long integer                                                                 ####
####        - number of downvotes => long integer                                                               ####
####        - creation timestamp => long integer                                                                ####
####        - image link => string                                                                              ####
####        - thumbnail info on upload => string                                                                ####
####        - link for full size image (if too large for standard display) => string                            ####
####        - image width => long integer                                                                       ####
####        - image height => long integer                                                                      ####
####        - has audio? => bool                                                                                ####
####        - source link (if available) => string                                                              ####
####        - flags:                                                                                            ####
####            - SFW -> 1                                                                                      ####
####            - NSFW -> 2                                                                                     ####
####            - SFW + NSFW -> 3                                                                               ####
####            - NSFL -> 4                                                                                     ####
####            - SFW + NSFL -> 5                                                                               ####
####            - NSFW + NSFL -> 6                                                                              ####
####            - SFW + NSFW + NSFL -> 7                                                                        ####
####            - NSFP -> 8                                                                                     ####
####            - SFW + NSFP -> 9                                                                               ####
####            - NSFW + NSFP -> 10                                                                             ####
####            - SFW + NSFW + NSFP -> 11                                                                       ####
####            - NSFL + NSFP -> 12                                                                             ####
####            - SFW + NSFL + NSFP -> 13                                                                       ####
####            - NSFW + NSFL + NSFP -> 14                                                                      ####
####            - All filters ->15                                                                              ####
####        - username of uploader => string                                                                    ####
####        - user mark ("fag" state) => long integer                                                           ####
####        - "gift" state => long integer                                                                      ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class UploadDetailObject
    {

        public long Id {get; set;}
        public long Promoted {get; set;}
        public long UserId {get; set;}
        public long Up {get; set;}
        public long Down {get; set;}
        public long Created {get; set;}
        public string Image {get; set;} = "";
        public string Thumb {get; set;} = "";
        public string Fullsize {get; set;} = "";
        public long Width {get; set;}
        public long Height {get; set;}
        public bool Audio {get; set;}
        public string Source {get; set;} = "";
        public long Flags {get; set;}
        public string User {get; set;} = "";
        public long Mark {get; set;}
        public long Gift {get; set;}

    }

}