/*
####################################################################################################################
####                                          class accountObject                                               ####
####    contains the definition for the accoutn object sent by the pr0gramm API when calling user info after    ####
####    login.                                                                                                  ####
####    object properties:                                                                                      ####
####        - Info on "public likes" setting => bool                                                            ####
####        - mail address known for user? => bool                                                              ####
####        - user mail address => string                                                                       ####
####        - user mark ("fag" state) => long integer                                                           ####
####        - default mark (in case of pr0mium user can choose mark) => long integer                            ####
####        - info on pr0mium payment => long integer                                                           ####
####        - list of invited users => array of invite objects (see inviteobject.cs)                            ####
####        - "ts" value (probably for internal use) => long integer                                            ####
####        - cache => string, only used when requesting profile info without being logged in.                  ####
####          Assumed usage: info if profile has been accessed before.                                          ####
####        - "rt" value (probably for internal use) => long integer                                            ####
####        - "qc" value (probably for internal use) => long integer                                            ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class AccountObject
    {
        
        public bool LikesArePublic {get; set;}
        public bool DeviceMail {get; set;}
        public string Email {get; set;}
        public long Invites {get; set;}
        public long Mark {get; set;}
        public long MarkDefault {get; set;}
        public long PaidUntil {get; set;}
        public InviteObject[] Invited {get; set;}
        public long Ts {get; set;}
        public string Cache {get; set;}
        public long Rt {get; set;}
        public long Qc {get; set;}

    }

}