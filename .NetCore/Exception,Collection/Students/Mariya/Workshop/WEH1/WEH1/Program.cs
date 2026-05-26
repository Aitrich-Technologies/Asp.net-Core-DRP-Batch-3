using WEH1.Interface;
using WEH1.Manager;

namespace WEH1
{
    internal class Program
    {
       private static void Main(string[] args)
        {
      
             IMenu menu = new PublicManager();
                menu.DisplayMenu();
            
        }
    }
}
