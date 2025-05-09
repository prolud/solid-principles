using System;

namespace _4_InterfaceSegregation.Violation;

internal interface IRead
{
    object Read();
    void Write(object obj);
}

internal class Repository : IRead
{
    public object Read()
    {
        return DataBase.Select();
    }

    public void Write(object obj)
    {
        DataBase.Insert(obj);
    }
}
