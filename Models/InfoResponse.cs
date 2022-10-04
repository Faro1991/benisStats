/*
####################################################################################################################
####                                             class infoResponse                                             ####
####    contains the definition for the JSON response sent by the pr0gramm API when calling user info after     ####
####    login.                                                                                                  ####
####    Response fields:                                                                                        ####
####        - requested account => account object (see accountObject.cs)                                        ####
####################################################################################################################
*/

namespace BenisStatsAvalonia.Models
{

    public class InfoResponse
    {
        
        public AccountObject Account {get; set;} = new AccountObject();

    }

}