/*
####################################################################################################################
####                                            class Pr0Captcha                                                ####
####    contains the definition for captcha objects returned by the pr0gramm APIduring login process            ####
####    object properties:                                                                                      ####
####        - captcha token => string, identifies captcha processed for login                                   ####
####        - encrypted captcha string => string, captcha image, encrypted by BASE64 algorithm                  ####
####        - "ts" value (probably for internal use) => long integer                                            ####
####        - cache => string, only used when requesting profile info without being logged in.                  ####
####          Assumed usage: info if profile has been accessed before.                                          ####
####        - "rt" value (probably for internal use) => long integer                                            ####
####        - "qc" value (probably for internal use) => long integer                                            ####
####################################################################################################################
*/
namespace BenisStatsAvalonia.Models
{

    public class Pr0Captcha
    {
        public string Token {get;set;} = "";
        public string Captcha {get;set;} = "";
        public long Ts {get; set;}
        public string Cache {get;set;} = "";
        public long Rt {get;set;}
        public long Qc {get;set;}

    }

}