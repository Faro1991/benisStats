/*
####################################################################################################################
####                                             class commentObject                                            ####
####    contains the definition of comment objects used by the pr0gramm API when returning profile info         ####
####    object properties:                                                                                      ####
####        - comment ID => long integer, internal ID of commment                                               ####
####        - upvotes on comment => long integer                                                                ####
####        - downvotes on comment => long integer                                                              ####
####        - comment text => string                                                                            ####
####        - timestamp of comment creation => long integer                                                     ####
####        - ID of upload comment was made on => long integer                                                  ####
####        - Thumbnail info on commented upload => string                                                      ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class CommentObject
    {
        public long Id  {get; set;}
        public long Up {get; set;}
        public long Down {get; set;}
        public string Content {get; set;}
        public long Created {get; set;}
        public long ItemId {get; set;}
        public string Thumb {get; set;}
    }

}