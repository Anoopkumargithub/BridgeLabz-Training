using System;
class Aadhar
{
    public long AadharNumber;
    public string Name;
    public Aadhar(long aadharNumber,string name )
    {
        AadharNumber = aadharNumber;        
        Name = name;
    }

    public override string ToString()
    {
        return AadharNumber+"  "+Name;
    }
}