using System;
using System.Collections;
using System.Collections.Generic;

public class BitMulti
{
	public BitMulti()
	{
	}

    public Int64 Multiply(int op, int mul)
    {
        Int64 val = 0;
        List<int> ops = new List<int>() { 8, 6, 0 };
        foreach (int v in ops)
        {
            val += op << v;
        }
    }

    private List<int> GetShiftOperands(int op)
    {
        List<int> ops = new List<int>();
        for (int i = 0; 2^i < op; i++)
        {

        }
        // ops.Add()
        return ops;
    }
}
