using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    /* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
     * 
     * Static classes are classes which are created automatically
     * when the program runs.
     * 
     * Only one instance of a static object can exist at once.
     * 
     * You cannot create another instance of a static class.
     * 
     * Remember when I said that classes can be thought of as
     * instructions for creating an object and is not the object
     * itself? That is true for non-static classes.
     * 
     * For static classes, the class is the object itself.
     */
    public static class StaticClass
    {
        public static string City { get; set; } = "New York";

        public static string GetCity()
        {
            return City;
        }
    }
}
