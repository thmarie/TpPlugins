using Newtonsoft.Json;
using PluginBase;
using System;
using System.Collections;
using System.Windows.Input;

namespace HelloPlugin
{
    public class HelloCommand : PluginBase.ICommand
    {
        public string[] jSon { get => System.IO.File.ReadAllLines(@"../Users/EchTest.json"); }

        public ArrayList Execute()
        {
            ArrayList listUser = new ArrayList();
            foreach(string line in jSon)
            {
                User utilisateur = new PluginBase.User();
                utilisateur = JsonConvert.DeserializeObject<User>(line);
                listUser.Add(utilisateur);
            }
            return listUser;
        }
    }
}
