using System.Drawing;

namespace Lucraft.Utilities
{
    public class R
    {

        public static Strings Strings { get; }
        public static Colors Colors { get; }

        static R()
        {
            Strings = null;
            Colors = null;
        }

        private R() { }

    }

    public class Strings : Resource<string>
    {

    }

    public class Colors : Resource<Color>
    {

    }

    public abstract class Resource<T>
    {

    }

    class Tester
    {
        void Test()
        {
            
        }
    }

}
