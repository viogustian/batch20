namespace Week1_Logic1_VioGustian
{
    public class FooBarr
    {
        public static void Generate(int n)
        {
            List<string> results = new List<string>();
            for(int x = 1; x<=n; x++ )
            {    
                if(x % 3 == 0 && x % 5 == 0 )
                {
                    results.Add("foobar");
                } 
                else if (x % 3 == 0)
                {
                    results.Add("foo");
                } 
                else if(x % 5 == 0)
                {
                    results.Add("bar");
                } 
                else{
                    results.Add(x.ToString());
                }
            }
            Console.WriteLine(string.Join(", ", results));
            
        }
    }
}
