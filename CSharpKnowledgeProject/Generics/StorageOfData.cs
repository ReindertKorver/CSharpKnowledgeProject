using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpKnowledgeProject.Generics
{
    internal class StorageOfData
    {
        public static void Main()
        {
            //Lets create an example of saving objects genericly in one class
            //first create an instance of the DataStorage class
            DataStorage<User> dataStorage = new DataStorage<User>();
            User user = new User();
            user.Age = 21;
            user.Name = "Jim";
            var res = user.Identifier;
            //res will contain the identifier of the user
            //now save the user
            dataStorage.SaveData(user);
            //now try and get it back
            User user1 = dataStorage.GetData(user.Identifier);
            //to check if they have the reference to the same object
            if (user == user1)
            {
                //they are the same
            }
            //to get more data from the DataStorage
            DataStorage<Document> documentStorage = new DataStorage<Document>();
            var guids = documentStorage.GetGuids();
            //get all the guids
            //GetGuids only gets the guids where the object matches the generic parameter (<Document> in this case)
            var doc = guids[0];
            //var doc = guids.First(); //with Linq
            //get the first
            Document document = documentStorage.GetData(doc);
        }
    }

    /// <summary>
    /// A Datastorage class with the generic parameter T which must extend from IData
    /// </summary>
    internal class DataStorage<T> where T : IData
    {
        //simulate data in files
        private List<IData> data = new List<IData>() {
                new Document() { Description = "A file", URL = "C:/tmp/txt.txt" },
                new User() { Name = "Someone", Age = 20 } };

        public bool SaveData(T obj)
        {
            data.Add(obj);
            //save to file and do more specific things
            return true;
        }

        public List<Guid> GetGuids()
        {
            List<Guid> guids = new List<Guid>();
            foreach (var item in data)
            {
                if (item is T)
                {
                    guids.Add(item.Identifier);
                }
            }
            return guids;
        }

        public T GetData(Guid guid)
        {
            //Get from file and do more specific things
            foreach (var item in data)
            {
                //item is T is needed because otherwise we conflict Documents with Users
                //as the generic parameter is of a specific type
                if (item.Identifier == guid && item is T)
                {
                    //this is also why we cast is here (with item as T or (T)item)
                    return item as T;
                }
            }
            return null;
        }
    }

    /// <summary>
    /// A document class which extends from IData
    /// </summary>
    internal class Document : IData
    {
        public string Description { get; set; }
        public string URL { get; set; }
    }

    /// <summary>
    /// A user class which extends from IData
    /// </summary>
    internal class User : IData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// The IData class from which classes can extend so they can be used inside the DataStorage class
    /// </summary>
    internal abstract class IData
    {
        private Guid indentifier;
        public Guid Identifier { get => indentifier; }

        public IData()
        {
            //create a random guid when the object is instanciated
            indentifier = Guid.NewGuid();
        }
    }
}