using System;
using System.Collections.Generic;
using System.Text;

namespace EKnjige.MobileApp.Models
{
    public enum MenuItemType
    {
        Knjige,
        PredloziKnjigu,
        KorisnickiProfil,
        UrediProfil,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
