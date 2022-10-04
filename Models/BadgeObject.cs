/*
####################################################################################################################
####                                             class badgeObject                                              ####
####    contains the definition for badge objects used by the pr0gramm API when returning profile info          ####
####    object properties:                                                                                      ####
####        - badge link => string, contains link to additional info on badge (event posts, ...)                ####
####        - badge image => string, name of image used for badge                                               ####
####        - badge description => string, explains why badge was rewarded                                      ####
####        - timestamp of badge/event date => long integer                                                     ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class BadgeObject
    {

        public string Link {get; set;} = "";
        public string Image {get; set;} = "";
        public string Description {get; set;} = "";
        public long Created {get; set;}

    }

}