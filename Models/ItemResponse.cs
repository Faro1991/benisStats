/*
####################################################################################################################
####                                             class itemResponse                                             ####
####    contains the definition for the JSON response sent by the pr0gramm API when calling upload info after   ####
####    login.                                                                                                  ####
####    Response fields:                                                                                        ####
####        - reached end of possible uploads within filter? => bool                                            ####
####        - reached start of possible uploads within filter? => bool                                          ####
####        - error message => string                                                                           ####
####        - uploads within filter criterium => array of detailed upload objects (see uploadDetailObjects.cs)  ####
####        - "ts" value (probably for internal use) => long integer                                            ####
####        - cache => string, contains info on filter                                                          ####
####        - "rt" value (probably for internal use) => long integer                                            ####
####        - "qc" value (probably for internal use) => long integer                                            ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class ItemResponse
    {

        public bool AtEnd {get; set;}
        public bool AtStart {get; set;}
        public string Error {get; set;}
        public UploadDetailObject[] Items {get; set;}
        public long Ts {get; set;}
        public string Cache {get; set;}
        public long Rt {get; set;}
        public long Qc {get; set;}

    }

}