using System;

namespace Generic_Concept2
{
    class gen
    {
        public void check<T>(T a,T b)
        {
            bool x = a.Equals(b); // (A==B) COMPARSION OF DATA TYPE ID,INT AND A.EQUALS(); FOR OBJECT TYPE COMPARISION 
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            gen riccc = new gen();
            riccc.check(22, 22);

            riccc.check(22, 20);
            riccc.check("RAM","RAM");



        }
    }
}
