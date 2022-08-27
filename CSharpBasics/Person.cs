namespace CSharpBasics
{
    /* https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
     * 
     * C# classes can be thought of as instructions for creating
     * an object. The class is not an object itself.
     */
    public class Person
    {
        #region Comments
        /* In C#, comments can be made multi-line by starting with
         * the slash followed by an asterisk.
         * The comment is terminated by an asterisk followed by
         * a slash.
         */

        //Single line comments are created by two consecutive slashes
        #endregion

        #region Types
        /* https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
         * 
         * C# is a strongly-typed language. That means that almost every
         * object has a very specific type.
         * 
         * Built-in types include
         *      int
         *      string
         *      double
         *      decimal
         */
        #endregion

        #region Access Modifiers
        /* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
         * 
         * C# access modifiers determine which objects and processes
         * can access other objects.
         * 
         * public: The type or member can be accessed by any other code
         * in the same assembly or another assembly that references it.
         * The accessibility level of public members of a type is
         * controlled by the accessibility level of the type itself.
         * 
         * private: The type or member can be accessed only by code
         * in the same class or struct.
         * 
         * protected: The type or member can be accessed only by code
         * in the same class, or in a class that is derived from that
         * class.
         * 
         * internal: The type or member can be accessed by any code
         * in the same assembly, but not from another assembly.
         * In other words, internal types or members can be accessed
         * from code that is part of the same compilation.
         * 
         * protected internal: The type or member can be accessed by
         * any code in the assembly in which it's declared, or from
         * within a derived class in another assembly.
         * 
         * private protected: The type or member can be accessed by
         * types derived from the class that are declared within its
         * containing assembly.
         */
        #endregion

        #region Fields
        /* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields
         * 
         * Fields are objects that should only be accesible within
         * the class that they are contained in.
         * 
         * Because of this, they are usually marked with the private
         * access modifier.
         * 
         * C# naming conventions state that fields should be lowercase
         * and start with an underscore character.
         */

        private string _name;

        /* The _age field below is initialized to a value of 40.
         * 
         * If you don't initialize a field, it will initialize to its
         * default value.
         * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values
         * 
         * For example, the int type has a default value of 0.
         */
        private int _age = 40;
        #endregion

        #region Properties
        /* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
         * 
         * Properties enable a class to expose a public way of
         * getting and setting values, while hiding implementation
         * or verification code.
         * 
         * The 'get' property accessor is used to return the property
         * value.
         * 
         * The 'set' property accessor is used to assign a new value.
         * 
         * Properties have access modifiers which expose them to other
         * classes including:
         *      public
         *      protected
         *      internal
         */


        /* There are multiple ways of formatting properties:
         *      Single-line
         *      Multi-line
         * 
         * The two properties below expose the fields
         * that we created above: _name and _age.
         * 
         * The value keyword in the setter represents the new
         * value being assigned to the property.
         */
        public string Name { get { return _name; } set { _name = value; } }

        public int Age 
        { 
            get 
            { 
                return _age; 
            } 
            set 
            { 
                _age = value; 
            } 
        }


        /* Auto-implemented properties:
         * 
         * When properties are only exposing a field and don't contain
         * any extra logic (which is often the case), auto-implemented
         * properties can be declared using the syntax below.
         * 
         * The C# compiler will automaticaly create a backing field
         * for the property.
         */

        public int ShoeSize { get; set; }


        /* Get and set accessors can be different than the accessor
         * for the property.
         * 
         * In the example below, the property is public, the get
         * accessor is internal, and the set accessor is private.
         * 
         * That means that other classes can "see" and get the property
         * value but the property value can only be 
         * modified (i.e. set) by the class which declared it.
         * 
         * Note: The HatSize is initialized to a value of 10;
         */

        public int HatSize { get; private set; } = 10;
        #endregion

        #region Constructors
        /* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
         * 
         * Whenever a class is created in C#, a constructor is called.
         * 
         * The constructor is a specialized method which is used to
         * create and initialize a class.
         * 
         * A class can have multiple constructors which have different
         * parameters. They can be used to initialize values in the
         * class.
         * 
         * If no constructor is defined, the compiler will auto-generate
         * a paramaterless constructor.
         * 
         * Constructor declaration includes an access modifier
         * (e.g. public or internal) followed by the class name.
         */

        public Person()
        {
            //This is an example of a parameter-less constructor

            //The code can do something here
        }

        public Person(string name, int age)
        {
            /* This class contains two parameters which are used
             * to initialize the values of the Name and Age properties.
             */

            Name = name;
            Age = age;
        }

        public Person(string name)
        {
            /* This class contains only one parameter which is used
             * to initialize the value of the Name property.
             */

            Name = name;
        }
        #endregion

        #region Methods
        /* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
         * 
         * A method is a code block that has a series of statements
         * which are executed when the method is called.
         * 
         * Methods can have parameters (like constructors do) and always
         * have a return type (e.g. int, string, etc.).
         * 
         * If the method should not return any value(s), the void
         * keyword is used.
         */

        public void DoSomething(string sentence)
        {
            /* This is an example of a public method with a single
             * parameter which doesn't return any value(s).
             */

            /* The code can do something here and can use the
             * parameter value provided.
             */
        }

        private string DoSomethingElse(string sentence1, string sentence2)
        {
            /* This is an example of a private method with two
             * parameters which returns a string.
             */

            return sentence1 + sentence2;
        }
        #endregion
    }
}