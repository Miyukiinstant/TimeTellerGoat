using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTellerGoat
{
    internal class GTime
    {
        private static GTime _instance;
        public static GTime CreateMenu
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new GTime();
                }
                return _instance;
            }
        }
        private object g_menu
        {
            get
            {
                return g_menu;
            }
            set
            {
                g_menu = value;
            }
        }
        private GTime()
        {
            PopulateMenu();
        }
        private void PopulateMenu()
        {
            g_menu = UIExpansionKit.API.ExpansionKitApi.CreateCustomQuickMenuPage(UIExpansionKit.API.LayoutDescription.WideSlimList);
            ((UIExpansionKit.API.ICustomShowableLayoutedMenu)g_menu).AddSimpleButton("Time",OnMenuShow);
        }

        private void OnMenuShow()
        {
            
        }
    }
}
