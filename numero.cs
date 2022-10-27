using System;

public class Class1
{
	private int num1;
	private int num2;
	public Class1()
	{
		
	}

    public int Num1 { get => num1; set => num1 = value; }
    public int Num2 { get => num2; set => num2 = value; }

	public int suma()
	{
		return num1 * num2;
	}
}
