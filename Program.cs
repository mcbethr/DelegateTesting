using System;

namespace DelegateTesting{

class Program{

    static void Main()
    {
        Examples Ex = new Examples();

    Console.WriteLine(Ex.ReadOnlyNumber);

        Examples EX2 = new Examples(2);
        Console.WriteLine(EX2.ReadOnlyNumber);

    }

}


}