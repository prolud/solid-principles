using System;

namespace _4_InterfaceSegregation.CorrectAplication;

internal interface IRead
{
    object Read();
}

internal interface IWrite
{
    void Write(object obj);
}

internal class Repository : IRead, IWrite
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

internal class OtherRepository: IRead
{
    public object Read()
    {
        return DataBase.Select();
    }
}
