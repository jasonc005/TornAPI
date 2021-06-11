using System;
using System.Collections.Generic;
using TornAPI.Responses.User;
using TornAPI.Responses.User.BaseClasses;
using TornAPI.Responses.User.Selections;
using TornAPI.SelectionEnums;


namespace TornAPI
{
    public static class TornApi
    {
        private static readonly string BASE_URL = "https://api.torn.com/";

        public static List<IUserSelection> GetUser(int? userId, List<UserSelections> selections, string apiKey)
        {
            throw new NotImplementedException();
        }
    }
}
