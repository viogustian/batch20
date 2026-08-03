namespace Week1_Logic1
{
    public class FooBarr
    {
        public static void Generate(int n)
        {
            List<string> results = new List<string>();   // buat list result
            for(int x = 1; x<=n; x++ ) // loop dari x = 1 sampai x = n
            {    
                if(x % 3 == 0 && x % 5 == 0 )
                {
                    results.Add("foobar"); // jika x % 3 dan x % 5 = 0 tampilkan foobar
                } 
                else if (x % 3 == 0)
                {
                    results.Add("foo"); // jika x % 3 = 0 tampilkan foo
                } 
                else if(x % 5 == 0)
                {
                    results.Add("bar"); // jika x % 5 = 0 tampilkan bar
                } 
                else{
                    results.Add(x.ToString()); // jika tidak keduanya cetak angkanya
                }
            }
            Console.WriteLine(string.Join(", ", results));  // gabungkan semuanya
            
        }
    }
}
