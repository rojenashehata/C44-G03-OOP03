using Demo_OOP03.Inheritance;

namespace Demo_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Indexer
            // PhoneBook phoneBook= new PhoneBook(3);
            //// phoneBook.AddPerson("Ahmed", 1234,0);
            // phoneBook.AddPerson("Ali", 234,1);
            // phoneBook.AddPerson("Aya", 34,2);
            // long number = phoneBook.GetNumber("Ahmed");
            // Console.WriteLine(number);

            #region After using indexer

            // //Indexer : made class act like array
            // //special property

            // ////normal property have a name
            // ////Indexer doesn't
            // ///
            // phoneBook["Ahmed"] = 3321;
            // Console.WriteLine(phoneBook["Ahmed"]);
            // Console.WriteLine(phoneBook[2]);
            #endregion


            #endregion



            #region Part02 Class & Constructor Chaining

            ////inside class => data +behaviors
            ////In Class: Creating Constructor will cancel the deault while in reverse for struct
            // Car car = new Car();

            /////Constructor chains
            ////Two types of chains
            ////Internal Chain=> inside the Class
            ////External chain=> with class which was inherited from
            /////In chains,debugging begin with the last end of chain


            #endregion


            #region Part03 Inheritance
            ////C# doesn't support multiple Inheritance
            ///
            ////to use override the method must be
            //non private +virtual
            Child child = new Child(10,20,30);
            Console.WriteLine(child.product());

            ////Diamond problem
            #endregion


            #region Part 04 Relationships Between Classes
            //inheritance 
                 // is a
            //Association
                //can't be independent


            #endregion

        }
    }
}
