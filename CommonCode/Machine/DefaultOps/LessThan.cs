﻿namespace CommonCode.Machine.DefaultOps
{
    using System;

    public class LessThan : IOp
    {
        public int DataLength => 3;

        public void Act(IntMachine machine, ReadOnlySpan<long> opData, ReadOnlySpan<byte> modes)
        {
            if (machine.MarshallAccess(opData[0], modes[0]) < machine.MarshallAccess(opData[1], modes[1]))
            {
                machine.Write(opData[2], 1);
            }
            else
            {
                machine.Write(opData[2], 0);
            }
        }
    }
}
