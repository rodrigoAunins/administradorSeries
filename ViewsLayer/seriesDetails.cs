using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSeriesPS.DataLayer;
using AdminSeriesPS.BusinessLayer;
using AdminSeriesPS.ViewsLayer;
using System.Globalization;

namespace AdminSeriesPS.ViewsLayer
{
    public partial class seriesDetails : Form
    {
      

        public seriesDetails()
        {
            InitializeComponent();
            cboxGenres.Items.Add("comedia");
            cboxGenres.Items.Add("drama");
            cboxGenres.Items.Add("romance");
            cboxGenres.Items.Add("ciencia ficcion");
            cboxGenres.Items.Add("anime");
            cboxGenres.Items.Add("accion");
            cboxGenres.Items.Add("far west");
            cboxGenres.Items.Add("musical");
            cboxGenres.Items.Add("drama comico");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            BLseries addSerie = new BLseries();
            DLseries serie = new DLseries();
            int num1 = 1;
            decimal num2 = 2;
            bool readyForContinue = false;
            
            if (txtId.Text == string.Empty)
            {
                if (txtTitle.Text != string.Empty && txtDescription.Text != string.Empty && txtStars.Text != string.Empty && txtPrice.Text != string.Empty)
                {

                    if (int.TryParse(txtStars.Text, out num1) && decimal.TryParse(txtPrice.Text, out num2))
                    {
                        if (int.Parse(txtStars.Text) <= 5)
                        {
                            serie.Title = txtTitle.Text;
                            serie.Description = txtDescription.Text;
                            serie.Stars = int.Parse(txtStars.Text);
                            serie.Price = decimal.Parse(txtPrice.Text.ToString(), CultureInfo.InvariantCulture); 
                            serie.DateSerie = dateTimePremiere.Value;
                            serie.Atp = cboxAtp.Checked;
                            serie.Genre = cboxGenres.Text;
                            serie.State = "AC";
                            readyForContinue = true;
                            addSerie.add(serie);
                        }
                        else { MessageBox.Show("no puede calificar con mas de 5 estrellas"); }

                    }
                    else { MessageBox.Show("el precio y las estrellas deben ser numeros"); }


                }
                else { MessageBox.Show("No puede haber elementos vacios, llene todos los campos porfi"); }
            }




            else
            {
                if (txtTitle.Text != string.Empty && txtDescription.Text != string.Empty && txtStars.Text != string.Empty && txtPrice.Text != string.Empty)
                {

                    if (int.TryParse(txtStars.Text, out num1) && decimal.TryParse(txtPrice.Text, out num2))
                    {
                        if (int.Parse(txtStars.Text) <= 5)
                        {
                            serie.Id = int.Parse(txtId.Text);
                            serie.Title = txtTitle.Text;
                            serie.Description = txtDescription.Text;
                            serie.Stars = int.Parse(txtStars.Text);
                            serie.Price = decimal.Parse(txtPrice.Text.ToString(), CultureInfo.InvariantCulture); 
                            serie.DateSerie = dateTimePremiere.Value;
                            serie.Atp = cboxAtp.Checked;
                            serie.Genre = cboxGenres.Text;
                            serie.State = "AC";
                            readyForContinue = true;
                            addSerie.update(serie);
                        }
                        else { MessageBox.Show("no puede calificar con mas de 5 estrellas"); }

                    }

                    else { MessageBox.Show("el precio y las estrellas deben ser numeros"); }

                    }
                else { MessageBox.Show("No puede haber elementos vacios, llene todos los campos porfi"); }


            }
            
            if (readyForContinue == true) 
            { 
                this.Hide();
                new ABML().Show();
            }


        }


        private void seriesDetails_Load(object sender, EventArgs e)
            {

            }

            public void updateSerie(DataLayer.DLseries serie)
            {

                txtId.Text = serie.Id.ToString();
                txtTitle.Text = serie.Title;
                txtDescription.Text = serie.Description;
                dateTimePremiere.Text = serie.DateSerie.ToString();
                txtStars.Text = serie.Stars.ToString();
                cboxGenres.Text = serie.Genre;
                txtPrice.Text = serie.Price.ToString();
                cboxAtp.Checked = serie.Atp;
                txtState.Text = serie.State;



            }

            private void label5_Click(object sender, EventArgs e)
            {

            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.Hide();
                new ABML().Show();
            }

            private void cboxGenres_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void cboxAtp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    } 
