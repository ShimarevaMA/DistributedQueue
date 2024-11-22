using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DistributedQueue.Common
{
    public interface SumTo50
    {
        Task Sum50(string name, CancellationToken token);
    }
}
