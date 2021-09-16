﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmicitiaLibrary.IO;

namespace XNCPLib.XNCP
{
    public class CastMaterialInfo
    {
        public int[] SubImageIndices;

        public CastMaterialInfo()
        {
            SubImageIndices = new int[32];
        }

        public void Read(EndianBinaryReader reader)
        {
            for (int i = 0; i < 32; ++i)
                SubImageIndices[i] = reader.ReadInt32();
        }
    }
}
