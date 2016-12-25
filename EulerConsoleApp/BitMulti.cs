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
        //List<int> ops = new List<int>() { 11, 10, 7, 4, 0 };
        List<int> ops = GetShiftOperands(mul);
        foreach (int v in ops)
        {
            val += (v == 0) ? op : (op << v);
            //val += op << v;
        }
        return val;
    }

    private List<int> GetShiftOperands(int op)
    {
        List<int> ops = new List<int>();
        while (op > 0)
        {
            //int rem = op;
            int i;
            for (i = 0; (2 << i) < op; i++)
                //Console.WriteLine(i);
            ;
            Console.WriteLine(i);
            ops.Add(i);
            op -= (i > 1) ? (2 << (i - 1)) : (i > 0) ? op + op : op;
            /*
            if (i > 0)
            {
                //Console.WriteLine((2 << (i - 1)));
                op -= (2 << (i - 1));
                //Console.WriteLine(op);
            }
            else
                op = 0;
            */
        }

        return ops;
    }
}
