using System;
// [24/11 10:56] Sujith Fernando
// 1 .Create a .Net Solution (c# language) 

// [24/11 10:57] Sujith Fernando
// 2.Create a class library that can talk to this API and returns list of universities per country 

// [24/11 10:59] Sujith Fernando
// 3. Create a Console  Application that can talk to the new class library you created and display Universities information in any format that you think of it 


// App to find Uni by name and then return a website
    // Use LINQ library to filter by name

namespace UniApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var api = new UniApi();
            await api.getUnis("united kingdom");
        }
    }
}