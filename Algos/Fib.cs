using System.Collections.Generic;

namespace Algos
{
    public class Fib
    {
        private readonly long _n;
        private Dictionary<long, long> _visited = new();

        public Fib(long n)
        {
            _n = n;
        }

        public long RecursiveFib() => RecursiveFib(_n);

        public long RecursiveFib(long n)
        {
            if (n <= 1)
                return n;
            return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }

        public long MemoidizedFib() => MemoidizedFib(_n);

        public long MemoidizedFib(long n)
        {
            if (_visited.ContainsKey(n))
                return _visited[n];
            if (n <= 1)
            {
                _visited[n] = n;
                return n;
            }
            var result = MemoidizedFib(n - 2) + MemoidizedFib(n - 1);
            _visited[n] = result;
            return result;
        }

        public long NonRecursiveFib()
        {
            var s1 = 0;
            var s2 = 1;
            var s3 = 0;
            var control = _n;
            while (control > 0)
            {
                s3 = s1 + s2;
                s1 = s2;
                s2 = s3;
                control -= 1;
            }
            return s3;
        }
    }
}
