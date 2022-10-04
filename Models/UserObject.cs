/*
####################################################################################################################
####                                             class UserObject                                               ####
####    contains the definition of user objects used by the pr0gramm API when returning profile info            ####
####    object properties:                                                                                      ####
####        - user ID => long integer, internal ID of user                                                      ####
####        - username => string                                                                                ####
####        - registration timestamp => long integer                                                            ####
####        - "benis" score => long integer                                                                     ####
####        - user mark ("fag" state) => long integer                                                           ####
####        - Info if user is admin => long integer                                                             ####
####        - info on user's "banned" state => long integer                                                     ####
####        - amount of comments deleted => long integer                                                        ####
####        - amount of uploadsDeleted => long integer                                                          ####
####        - info if user is considered "inactive => long integer                                              ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class UserObject
    {
        
        public long Id {get; set;}
        public string Name {get; set;}
        public long Registered {get; set;}
        public long Score {get; set;}
        public long Mark {get; set;}
        public long Admin {get; set;}
        public long Banned {get; set;}
        public long CommentDelete {get; set;}
        public long ItemDelete {get; set;}
        public long Inactive {get; set;}

    }

}