using System.Collections.Generic;
using denemeewebui.Models;

namespace denemeewebui.Data
{
    public class PersonRepository
    {
       private static List<Person> _person=null;
        

       public static List<Person> Persons{
            get{
                return _person;
            }
        }

        public static void AddProduct(Person product)
        {
            using (var db = new ShopContext())//using içine aldımki işim bitince bellekten gitsin
            {
                    db.products.Add(product);
                db.SaveChanges();
                // db.products.AddRange(products); bu foreachın yaptığı işlemi yapar
            }
        }

    }
}