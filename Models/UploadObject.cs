/*
####################################################################################################################
####                                             class UploadObject                                             ####
####    contains the definition of upload objects used by the pr0gramm API when returning profile info          ####
####    object properties:                                                                                      ####
####        - upload ID => long integer, internal ID of upload                                                  ####
####        - Thumbnail info on upload => string                                                                ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class UploadObject
    {

        public long Id {get; set;}
        public string Thumb {get; set;}

    }

}