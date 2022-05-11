/*Statikusan tarolja azokat az adatokat, amiket
 * csak redundans modon lehetne megadni nagyon sokszor 
 * a programban.
 * Igy csak egyszer kell megadni, majd utana ezt az erteket
 * kell lehivni.
 * 
 * pl.: "https://localhost:8800"
 * 
 * Ezutan mehet az URI: "/assets/5"
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace karbantartasAdmin
{
    public static class ServerDataStore
    {
        public static String url = "https://localhost:44392";
        public static bool authUser = true; 
        public static void SetUrl(String url)
        {
            ServerDataStore.url = url;
        }
        public static string GetUrl()
        {
            return ServerDataStore.url;
        }
    }
}
