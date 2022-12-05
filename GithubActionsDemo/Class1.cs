using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://gist.github.com/CalvinAllen/701695399e5966845a206954820c329e
namespace GithubActionsDemo
{
    class Person
    {
        string name;
        int age;
    }

    public class Class1
    {

        void Test()
        {
            Person aPerson = new Person();
            string json = JsonConvert.SerializeObject(aPerson);
        }

    }
}
