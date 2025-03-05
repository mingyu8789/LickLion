﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study32
{
    //base 호출하기

    class Parent
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("부모클래스의 메시지");
        }
    }


    class Child : Parent
    {
        public override void ShowMessage()
        {
            Console.WriteLine("자식 클래스의 메시지");
            base.ShowMessage(); //부모함수 실행       부모핢수를 실행시킬수 있는 명령어 base
        }
    }








    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();

            child.ShowMessage();
        }
    }
}
