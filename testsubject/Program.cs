using System;

namespace testsubject
{
    class MainClass
    {
        public static void Main (string[] args)
        {          

            for (int i = 0; i < 12; i++){
                var x = new SplineFinder();
                x.Reticulate();
                GetCount ();

            }

#if FALSE
            for (int i = 0; i < 22; i++)
                GetCount ();
#endif

        }

        public static void Foo ()
        {
            throw new NotImplementedException ();
        }

        static int count = 0;
        public static int GetCount ()
        {
            Console.WriteLine (count);


            if (count > 100) 
                Foo ();

            if (count > 8) 
                throw new InvalidOperationException ("bang");

            return ++count;
        }
    }
}
