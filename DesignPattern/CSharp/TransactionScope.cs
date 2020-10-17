using System;

namespace DesignPattern.CSharp
{
    class TransactionScope
    {
        public void ProtectWithTransaction(Action action)
        {
            action.Invoke();
        }

        public int ProtectWithTransaction1(Func<int> action)
        {
            return action.Invoke();
        }

        public void Add2InputWithNoReturnType(int a, int b)
        {
        }
        public void AddWithNoInputNoReturnType()
        {
        }

        public int AddReturnIntNoInput()
        {
            return 5;
        }
    }

    class TestDemo
    {
        public static void Main1(string[] args)
        {
            TransactionScope ts = new TransactionScope();
            ts.ProtectWithTransaction(() => ts.Add2InputWithNoReturnType(1, 3));
            ts.ProtectWithTransaction(() => ts.AddWithNoInputNoReturnType());
            var x = ts.ProtectWithTransaction1(ts.AddReturnIntNoInput);
        }
    }
}
