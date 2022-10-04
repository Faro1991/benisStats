/*
####################################################################################################################
####                                          class commentsResponse                                            ####
####    contains the definition for the JSON response sent by the pr0gramm API when calling profile info        ####
####    without being logged in.                                                                                ####
####    Response fields:                                                                                        ####                                                      ####
####        - comments => array of comment objects (see commentObject.cs)                                       ####
####        - older comments available? => boolean                                                              ####
####        - newer comments available? => boolean                                                              ####
####        - user who made comment => incomplete user object (see userObject.cs): id, name, "fag" state        ####
####        - "ts" value (probably for internal use) => long integer                                            ####
####        - cache => string, only used when requesting profile info without being logged in.                  ####
####          Assumed usage: info if profile has been accessed before.                                          ####
####        - "rt" value (probably for internal use) => long integer                                            ####
####        - "qc" value (probably for internal use) => long integer                                            ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class CommentsResponse
    {

        public CommentObject[] Comments {get; set;} = new CommentObject[1];
        public bool HasOlder {get; set;}
        public bool HasNewer {get; set;}
        public UserObject User {get; set;} = new UserObject();
        public long Ts {get; set;}
        public string Cache {get; set;} = "";
        public long Rt {get; set;}
        public long Qc {get; set;}

    }

}