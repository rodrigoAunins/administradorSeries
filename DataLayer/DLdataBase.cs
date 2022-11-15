using AdminSeriesPS.BusinessLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSeriesPS.DataLayer
{
    public class DLdataBase
    {
        private string host;
        private string port;
        private string db;
        private string user;
        private string pass;

        public string Host { get => host; set => host = value; }
        public string Port { get => port; set => port = value; }
        public string Db { get => db; set => db = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        public bool connect(string host, string port, string db, string user, string pass)
        {
            DLdataBase conectData = new DLdataBase();
            
            bool connectOk = false;
            Host = host;
            Port = port;
            Db = db;
            User = user;
            Pass = pass;
            
            MySqlConnection connection = new MySqlConnection();
            try {
               
                
                string connectString = "server=" + Host + ";" + "port=" + Port + ";" + "user id=" + User + ";" + "password=" + Pass + ";" + "database=" + Db + ";" + "Convert Zero Datetime=true" + ";";
                connection.ConnectionString = connectString;
                connection.Open();
                MessageBox.Show("se establecio coneccion con la base de datos");
                connectOk = true;
                

            }
            catch (MySqlException e) {
                MessageBox.Show("no se pudo establecer coneccion. Error: " );
                
            }
            bool dbCreated;
            if (connectOk == true) {
                DLdatasConection dataForConection = DLdatasConection.GetInstance(host, port, db, user, pass);
                dbCreated = createDB();
                
            }
            return  connectOk;

        }

        public string stringForConection()
        {
            DLdatasConection dataForConection = DLdatasConection.GetInstance("host","Port","db","user","pass");
            string connectString = "server=" + dataForConection.Host + ";" + "port=" + dataForConection.Port + ";" + "user id=" + dataForConection.User + ";" + "password=" + dataForConection.Pass + ";" + "database=" + dataForConection.Db + ";" + "Convert Zero Datetime=true" + ";";
            return connectString;
        }

        public bool createDB()
        {
            bool createDB = true;
            try
            {
                DLdataBase add = new DLdataBase();
                string query = "CREATE TABLE `"+Db+"`.`series` ( `id` INT NOT NULL AUTO_INCREMENT, `title` varchar(150), `description` text(300), `dateSerie` date ,  `stars` INT, `genre` varchar(150) ,  `price` DECIMAL(7,2) ,  `atp` boolean,  `state` varchar(150), primary key(id)) ENGINE = InnoDB; ";
                MySqlCommand myCommand = new MySqlCommand(query, add.stablishConnect());
                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("base creada");
                Host = host;
                Port = port;
                Db = db;
                User = user;
                Pass = pass;
                return createDB;
            }
            catch (MySqlException e)
            {
                return createDB;
                MessageBox.Show("error al crear");
            }

        }

        public MySqlConnection stablishConnect()
        {
             MySqlConnection connection = new MySqlConnection();
            try
            {
                connection.Close();
                try { 
                connection.ConnectionString = stringForConection();
                connection.Open();
                }
                catch (System.ArgumentException e) { };


            }
            catch (MySqlException e)
            {
                MessageBox.Show("no se pudo establecer coneccion. Error: ");

            }
            return connection;

        }


        public List<BLseries> load()
        {
            DLdataBase connection = new DLdataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from series", connection.stablishConnect());
            DataTable dt = new DataTable();
            List<BLseries> series = new List<BLseries>();
            adapter.Fill(dt);
            series = (from DataRow dr in dt.Rows
                           select new BLseries()
                           {
                               Id = Convert.ToInt32(dr["id"]),
                               Title = dr["title"].ToString(),
                               Description = dr["description"].ToString(),
                               DateSerie = DateTime.Parse(dr["dateSerie"].ToString()),
                               Stars = int.Parse(dr["stars"].ToString()),
                               Genre = dr["genre"].ToString(),
                               Price = decimal.Parse(dr["price"].ToString()),
                               Atp = bool.Parse(dr["atp"].ToString()),
                               State = dr["state"].ToString(),
                           }).ToList();
            return series;
        }

        public bool add(DLseries serie)
        {
            DLdataBase add = new DLdataBase();
            string atpToDb;
            string host = Host;
            string port = Port;
            string db = Db;
            string user = User;
            string pass = Pass;
            var isoDateTimeFormat = serie.DateSerie.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            if (serie.Atp == true)
            {
                atpToDb = "1";
            }
            else
            {
                atpToDb = "0";
            }
            var priceFormatted = serie.Price.ToString(CultureInfo.InvariantCulture);
            string query = "insert into " + "series" + " (title,description,dateSerie,stars,genre,price,atp,state)" + "values ('" + serie.Title + "','" + serie.Description + "','" + isoDateTimeFormat + "','" + serie.Stars + "','" + serie.Genre + "','" + priceFormatted + "','" + atpToDb + "','" + "AC" + "');";
            MySqlCommand myCommand = new MySqlCommand(query, add.stablishConnect());
            MySqlDataReader reader = myCommand.ExecuteReader();
            MessageBox.Show("se guardo correctamente");
            bool ok = true;
            add.close();
            return true;
        }

        public void update(DLseries serie)
        {
            DLdataBase add = new DLdataBase();
            string atpToDb;
            string host = Host;
            string port = Port;
            string db = Db;
            string user = User;
            string pass = Pass;
            var isoDateTimeFormat = serie.DateSerie.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            if (serie.Atp == true)
            {
                atpToDb = "1";
            }
            else
            {
                atpToDb = "0";
            }
            var priceFormatted = serie.Price.ToString(CultureInfo.InvariantCulture);
            string query = "update " + "series " + "set title = '" + serie.Title + "'," + " description = '" + serie.Description + "'," + " dateSerie = '" + isoDateTimeFormat + "'," + " stars = '" + serie.Stars + "'," + " genre = '" + serie.Genre + "'," + " price = '" + priceFormatted + "'," + " atp = '" + atpToDb + "'," + " state = '" + serie.State + "' " + "WHERE id = '" + serie.Id + "'";
            MySqlCommand myCommand = new MySqlCommand(query, add.stablishConnect());
            MySqlDataReader reader = myCommand.ExecuteReader();
            MessageBox.Show("se actualizo correctamente");
            add.close();
        }

        public void delete(int idToDelete)
        {
            DLdataBase add = new DLdataBase();
            
            string query = "DELETE FROM `series` WHERE id = " + idToDelete.ToString();
            string host = Host;
            string port = Port;
            string db = Db;
            string user = User;
            string pass = Pass;

            MySqlCommand myCommand = new MySqlCommand(query, add.stablishConnect());
            MySqlDataReader reader = myCommand.ExecuteReader();
            MessageBox.Show("se elimino correctamente");
            add.close();
        }

        public void nulled(int idToNull)
        {
            DLdataBase add = new DLdataBase();
           
            string query = "update " + "series " + "set  state = 'AN' " + "WHERE id = '" + idToNull + "'";
            string host = Host;
            string port = Port;
            string db = Db;
            string user = User;
            string pass = Pass;

            MySqlCommand myCommand = new MySqlCommand(query, add.stablishConnect());
            MySqlDataReader reader = myCommand.ExecuteReader();
            MessageBox.Show("se anulo correctamente");
            add.close();
        }

        public void close()
        {
            
            MySqlConnection connection = new MySqlConnection();
            
                connection.Close();
                
            
        }
    }
}
