using System; 

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count=10;
            // declare float by adding an f
            float totalPrice = 20.95f;
            // declare a char by using single quote
            char character = 'A'
            // declare a string by using double quote
            string firstName = "Mosh";
            //
            bool is Working = false;
            // cw is the shortcut for console.writeLine
            Console.WriteLine(number);
            Console.WriteLine(count);
        }
        // By using the var keyword c# recognize the data type and we don't have to set is specific
        // Is safe to use int for numbers instead the rest of data types
        {
            var number = 2;
            var count=10;
            var totalPrice = 20.95f;
            var character = 'A'
            var firstName = "Mosh";
            var is Working = false;
        }
    }
}

// in different scenarios we want to compile types of data that are not compatible so we have to use a different method 

string s = "1";
int i = (int)s; // wont compile

// string > number
string s = "1";
 // using convert method
int i = Convert.ToInt32(s) // int32  is a thing and represent the 32Bytes

-- Convert types

toByte()
toInt16() - float
toInt32() - int
toInt64() - long

// parse method
// takes a string and convert to any primitive type.
int j = int.Parse(s);


// Compatible types
namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b; // int is 4 bytes
            Console.WriteLine(i);
            // returns 1
        }
        //reverse it 
        {
            int i = 1; // int is 4 bytes
            byte b = i; // doesnt work
            byte b = (byte) i; // works
            Console.WriteLine(i);
        }
    }
}

// None compatible types
namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           var number = "1234"
           int i = (int) number; // we cant cast an expression to a string
           int i = Convert.ToInt32(number) // works -> returns 1234
           Console.WriteLine(i);
        } 
    }
}

// Storing a value that is larger from the current type we trying to store and gives us an error in the console with the name "EXCEPTION" system.OverFlowException

// Write way to Convert None compatible types \
// using try /catch (prevent crashing the app)

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
           var number = "1234"
           int i = (int) number; // we cant cast an expression to a string
           int i = Convert.toByte(number) // works -> returns 1234
           Console.WriteLine(i);
            }
            catch (System.Exception)
            {
                Console.WriteLine("the number can be converted to a byte")
                // throw;
            }
        } 
    }
}