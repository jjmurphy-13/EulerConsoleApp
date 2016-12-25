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
        List<int> ops = GetShiftOperands(mul);
        foreach (int v in ops)
        {
            val += op << v;
        }
        return val;
    }

    private List<int> GetShiftOperands(int op)
    {
        List<int> ops = new List<int>();
        while (op > 0)
        {
            int i = 0;
            for (; (2 << i) <= op; i++) /* NOOP */;
            //Console.WriteLine(i);
            ops.Add(i);
            op -= (i > 0) ? (2 << (i - 1)) : op;
        }

        return ops;
    }
}
