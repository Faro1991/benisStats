/*
####################################################################################################################
####                                          class accountObject                                               ####
####    contains the definition for the accoutn object sent by the pr0gramm API when calling user info after    ####
####    login.                                                                                                  ####
####    object properties:                                                                                      ####
####        - username of invited user => string                                                                ####
####        - user mark ("fag" state) => long integer                                                           ####
####        - email of invited user => string                                                                   ####
####        - date of invitation => long integer                                                                ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class InviteObject
    {

        public string Name {get; set;} = "";
        public long Mark  {get; set;}
        public string Email {get; set;} = "";
        public long Created {get; set;}

    }

}