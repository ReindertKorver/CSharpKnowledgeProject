using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.ReferenceTypes
{
    internal class Trouble
    {
        public static void Main()
        {
            //Now I'll show an example of trouble with reference types
            //below this method there are a few classes Order, Item and Customer
            //Lets create a Customer
            Customer customer = new Customer();
            customer.Name = "Jim";
            //Lets create some Order Items
            Item itemCoffee = new Item();
            itemCoffee.Description = "Coffee";
            itemCoffee.Price = 1.20M;
            Item itemTea = new Item();
            itemTea.Description = "Tea";
            itemTea.Price = 1.10M;
            //lets create an Order
            Order order = new Order();
            order.Items = new List<Item>();
            //first instanciate a new List otherwise it would be null and you cant Add to null
            order.Items.Add(itemCoffee);
            order.Items.Add(itemTea);
            order.OrderedBy = customer;
            //Now we have an Order filled with data
            //Now what if we want to edit this Order
            //You could change the order itself but then you lose the old data
            //we want to keep the old data because there could be going something wrong
            //so lets copy the order variable in a new variable oldorder
            var oldOrder = order;
            //lets take a look at the problem now
            //what does oldOrder contain? a value or a reference
            //oldOrder and order both contain a reference to the object in memmory
            //so the reference inside oldOrder will now be the same as order
            //if we change oldOrder we will change the object to which it references in other words we will also change order
            //so what do we do now?
            //there is only one solution: create a new intance
            oldOrder = new Order() { Items = order.Items, OrderedBy = order.OrderedBy };
            //when there is a lot of data sometimes people choose to serialize and deserialize the data
            //which will be a significant improvement in amount of code
            //but will be less performant because everything needs to be converted to string and some data structure like json or xml
            //A obvious problem a lot of people dont take into account
        }

        internal class Order
        {
            public List<Item> Items { get; set; }
            public Customer OrderedBy { get; set; }
        }

        internal class Item
        {
            public string Description { get; set; }
            public decimal Price { get; set; }
        }

        internal class Customer
        {
            public string Name { get; set; }
        }
    }
}