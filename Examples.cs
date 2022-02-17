using System;

namespace DelegateTesting
{

    public class Examples{

    readonly int _ReadonlyNumber = 1;
    const int _ConstantNumber = 0;

    public int ReadOnlyNumber{ get {return _ReadonlyNumber;}}

    public int ConstantNumber {get {return _ConstantNumber;}}
        
        public Examples(){

        }

        public Examples(int MyNewNumber)
        {

        _ReadonlyNumber = MyNewNumber;


        }

        public void ChangeReadonly(int Number)
        {

            //_ReadonlyNumber = Number;
            //_ConstantNumber = Number;

        }

    }

}