using System;
using System.Linq;
// [24/11 10:56] Sujith Fernando
// 1 .Create a .Net Solution (c# language) 

// [24/11 10:57] Sujith Fernando
// 2.Create a class library that can talk to this API and returns list of universities per country 

// [24/11 10:59] Sujith Fernando
// 3. Create a Console  Application that can talk to the new class library you created and display Universities information in any format that you think of it 


// App to get universities
    //sort using LINQ library 
    //get user input to obtain all universities beginning with that letter

//exception handling
namespace UniApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var api = new UniApi();
            bool searching = true;
            while(searching){
                    Console.WriteLine("Welcome to Uni searcher! Enter country of where you would like to search");   
               
                    string country = Console.ReadLine();
                    await api.getUnis(country);
                    if(api.universities.Count == 0){
                        Console.WriteLine("Country Entered is wrong, try another version of the name. E.g. Britain => United Kingdom, America => United States");
                    }else{
                       Console.WriteLine("Narrow down your search with a keyword say `london` if you are looking for a university in london");
                       var criteria = Console.ReadLine().ToUpper();
                       var filteredList = api.universities.Where(b => b.name.ToUpper().Contains(criteria));
                       Console.WriteLine("Here is your narrowed down search\n");
                       foreach(var uni in filteredList){
                            Console.WriteLine($"name: {uni.name} webpage: {uni.web_pages[0]}" );
                       }
                    }
                
            }
            await api.getUnis("united kingdom");
        }
    }
}