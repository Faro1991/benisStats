/*
####################################################################################################################
####                                       class loginCookieObject                                              ####
####    contains the definition for cookie objects used by the pr0gramm API when answering login calls          ####
####    object properties:                                                                                      ####
####        - Username "n" => string, contains username of logged in profile                                    ####
####        - login id => string, identifies login to server                                                    ####
####        - "a" value => long integer, unknown, assumedly for internal usage                                  ####
####        - "pp" value => string, unknown, assumedly for internal usage                                       ####
####        - info on pr0mium payment status => boolean                                                         ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class LoginCookieObject
    {

        public string N {get; set;} = "";
        public string Id {get; set;} = "";
        public long A {get; set;}
        public string Pp {get; set;} = "";
        public bool Payment {get; set;}

    }

}