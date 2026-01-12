class sieve_of_eratosthenes {
    
      static void Main()
        {
            int n = 30;
            List<int> res = sieve(n);
    
            foreach (int ele in res)
            {
                Console.Write(ele + " ");
            }
        }
      
    static List<int> sieve(int n) {
        
        bool[] primes = new bool[n + 1];
        for (int i = 0; i <= n; i++) {
            primes[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            if (primes[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }

        List<int> res = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (primes[i])
            {
                res.Add(i);
            }
        }

        return res;
    }

  
}