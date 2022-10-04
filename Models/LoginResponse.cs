/*
####################################################################################################################
####                                            class LoginResponse                                             ####
####    contains the definition for the JSON response sent by the pr0gramm API when performing login            ####
####    Response fields:                                                                                        ####
####        - error state => string, only shows on unsuccessful login                                           ####
####        - login success => boolean. On unsuccessful login, will be preceeded by "error" field               ####
####        - Info on user's "banned" state => string                                                           ####
####        - login identifier => string, used for further processing of login. Only shows on successful login  ####
####        - "ts" value (probably for internal use) => long integer                                            ####
####        - cache => string, only used when requesting profile info without being logged in.                  ####
####          Assumed usage: info if profile has been accessed before.                                          ####
####        - "rt" value (probably for internal use) => long integer                                            ####
####        - "qc" value (probably for internal use) => long integer                                            ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class LoginResponse
    {

        public string Error {get; set;}
        public bool Success {get; set;}
        public string Ban {get; set;}
        public string Identifier {get; set;}
        public long Ts {get; set;}
        public string Cache {get; set;}
        public long Rt {get; set;}
        public long Qc {get; set;}

    }

}