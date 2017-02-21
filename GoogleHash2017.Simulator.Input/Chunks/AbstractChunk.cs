using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash2017.Simulator.Inputs.Chunks
{
    public abstract class Chunk
    {
        public abstract void ParseChunk(
            InputReaderResult inputContruction,
            IList<string> chunkContent);
    }
}

