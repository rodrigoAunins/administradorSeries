using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSeriesPS.DataLayer;

namespace AdminSeriesPS.BusinessLayer
{
    public class BLseries
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

        public BLseries()
        {
        }

        public BLseries(int id,string title, string description, DateTime dateSerie, int stars, string genre, decimal price, bool atp,string state)
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

        public BLseries(string title, string description, DateTime dateSerie, int stars, string genre, decimal price, bool atp, string state)
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
            bool result = false;
            result = serie.add(serie);
            return result;

        }

        public void update(DLseries serie)
        {
            DataLayer.DLseries serieDL = new DataLayer.DLseries();
            serieDL.update(serie);

        }

        public void delete(int idToDelete)
        {

         
            DataLayer.DLseries serieDL = new DataLayer.DLseries();
            serieDL.delete(idToDelete);

        }

        public void nulled(int idToCancel)
        {
            DataLayer.DLseries serieDL = new DataLayer.DLseries();
            serieDL.nulled(idToCancel);
        }

        public List<BLseries> load()
        {
            DLseries dLseries1 = new DLseries();
            List<DLseries> dLseries = new List<DLseries>();
            List<BLseries> bLseries = new List<BLseries>();
            bLseries = dLseries1.load();
            return bLseries;
 
        }
    }
}
