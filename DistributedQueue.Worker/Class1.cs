using DistributedQueue.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Worker
{
    public class ComputeSum : SumTo50
    {
        public Task Sum50(string name, CancellationToken token) {
            var startTime = DateTime.Now;
            Console.Write($"{startTime}: Started compute: ");
            int sum = 0;

            for (int i = 1; i <= 50; i++)
            {
                sum += i;
                Console.WriteLine($"Сумма чисел от 1 до {i}: {sum}");

                if (token.IsCancellationRequested)
                {
                    Console.WriteLine($"{DateTime.Now}: Sum: Cancelled compute sum {name}");
                    break;
                }
            }

            Console.WriteLine($"ComputeSum: {name}, task completed");

            return Task.CompletedTask;

        }
    }
}
