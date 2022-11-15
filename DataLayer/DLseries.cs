using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSeriesPS.BusinessLayer;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System.Globalization;

namespace AdminSeriesPS.DataLayer
{
    public class DLseries
    {
        private int id;
        private string title;
        private string description;
        private DateTime dateSerie;
        private int stars;
        private string genre;
        private decimal price;
        private bool atp;
        private string state;


        public DLseries()
        {
        }

        public DLseries(string title, string description, DateTime dateSerie, int stars, string genre, decimal price, bool atp, string state)
        {
            Title = title;
            Description = description;
            DateSerie = dateSerie;
            Stars = stars;
            Genre = genre;
            Price = price;
            Atp = atp;
            Title = title;
            Description = description;
            DateSerie = dateSerie;
            Stars = stars;
            Genre = genre;
            Price = price;
            Atp = atp;
            State = state;
        }
        public DLseries(int id,string title, string description, DateTime dateSerie, int stars, string genre, decimal price, bool atp, string state)
        {
            Id = id;
            Title = title;
            Description = description;
            DateSerie = dateSerie;
            Stars = stars;
            Genre = genre;
            Price = price;
            Atp = atp;
            Title = title;
            Description = description;
            DateSerie = dateSerie;
            Stars = stars;
            Genre = genre;
            Price = price;
            Atp = atp;
            State = state;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateSerie { get => dateSerie; set => dateSerie = value; }
        public int Stars { get => stars; set => stars = value; }
        public string Genre { get => genre; set => genre = value; }
        public decimal Price { get => price; set => price = value; }
        public bool Atp { get => atp; set => atp = value; }
        public string State { get => state; set => state = value; }

        public bool add(DLseries serie)
        {
            DataLayer.DLdataBase addSerie = new DataLayer.DLdataBase();
             return addSerie.add(serie);
        }

        public void update(DLseries serie)
        {
            DataLayer.DLdataBase updateSerie = new DataLayer.DLdataBase();
            updateSerie.update(serie);
        }

        public void delete(int idToDelete)
        {
            DataLayer.DLdataBase deleteSerie = new DataLayer.DLdataBase();
            deleteSerie.delete(idToDelete);
        }

        public void nulled(int idToDelete)
        {
            DataLayer.DLdataBase deleteSerie = new DataLayer.DLdataBase();
            deleteSerie.nulled(idToDelete);
        }

        public List<BLseries> load()
        {
            List<BLseries> series = new List<BLseries>();
            DLdataBase dataBase = new DLdataBase();
            series = dataBase.load();
            return series;
        }
    }
}
