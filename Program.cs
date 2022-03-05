using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;

public class Routers {

   public int time { get; set; }


    
       
}

public class Route
{


    public List<Routers> router = new List<Routers>() ;

    internal int sum(List<Routers> router)
    {
        throw new NotImplementedException();
    }
}


public class UserInput
{


    public List<Route> routes = new List<Route>();
    
    public void CreateNewRoute()
    {
    
        int listLngth=routes.Count;

        int numberOfRouters=Convert.ToInt32(Console.ReadLine());

        routes.Add(new Route());
        
        
        
        for(int i = 0; i < numberOfRouters; i++)
        {      
            int input = Convert.ToInt32(Console.ReadLine());

            routes[numberOfRouters - 1].router.Add(new Routers { time = input });

        }
       
        }


    public void AddRouteToGivenRoute( int RouteNumber,int routerValue)
    {
        routerValue= Convert.ToInt32(Console.ReadLine()); 
        routes[RouteNumber - 1].router.Add(new Routers { time = routerValue });

    }

    } 


public class SyncAsync
{
    static int CalculateRouter(Route route)
    {
        int total = route.sum(route.router);
        return total;
    }
    public async Task<int> BestRouteAsync(List<Route> routes)
    {       
       // var minValue = await Task.Run(() => BestRouteAsync(routes));

        return routes.AsParallel()
            .WithDegreeOfParallelism(4)
            .Select(CalculateRouter)
            .Min();




    }



}









public class Program
{

    public static void Main()
    {


        UserInput userInput = new UserInput();
        userInput.CreateNewRoute();






    }
}









