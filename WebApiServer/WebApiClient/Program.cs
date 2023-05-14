
namespace WebApiClient
{
    class Program
    {

        static  async Task  Main()
        {
            Console.WriteLine("press any key...");
            Console.ReadLine();

            using (HttpClient client = new HttpClient())
            {
                var responce = await client.GetAsync("http://localhost:5127/values"); 
                responce.EnsureSuccessStatusCode();
                if (responce.IsSuccessStatusCode)
                {
                    string message = await responce.Content.ReadAsStringAsync();
                }
                else{
                    Console.WriteLine($"responce error : {responce.StatusCode}");
                }
            }
            Console.ReadLine();
        }
    }
}
