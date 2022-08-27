using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    /* We can use this class to create a Person class and view
     * its properties and methods.
     * 
     * We can also use it to view the StaticClass.
     */
    public class Class2
    {
        public Class2()
        {
            //We'll create a person object in the constuctor of Class2

            //Person1 is created using the parameter-less constructor
            var person1 = new Person();

            /* Person2 is created using one of the constructors with
             * parameters.
             */
            var person2 = new Person("John");

            /* Person 3 is created using the parameter-less constructor
             * and the Age property is initialized in a separate
             * statement.
             */
            var person3 = new Person();
            person3.Age = 32;

            /* Person 4 is created using the parameter-less constructor
             * and the Age property is initialized in-line.
             */
            var person4 = new Person()
            {
                Age = 22
            };

            /* Static objects (or classes in this case) are accessed
             * using the object name. They don't need to be created
             * using the new keyword.
             * 
             * In the statements below, we are accessing the City
             * property of the StaticClass and storing it in a variable
             * and then we're calling the static GetCity() method and
             * storing the result in a second variable.
             */
            var city = StaticClass.City;
            var city2 = StaticClass.GetCity();
        }
    }
}
