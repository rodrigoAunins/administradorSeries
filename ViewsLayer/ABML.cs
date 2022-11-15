using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSeriesPS.BusinessLayer;
using AdminSeriesPS.ViewsLayer;
using AdminSeriesPS.DataLayer;

namespace AdminSeriesPS.ViewsLayer
{
    public partial class ABML : Form
    {
        //List<String> seriesDetailsList = new List<string>();
        //private bool isForModify = false;
        //private string nulledOrNo = "AC";



        public ABML()
        {
            InitializeComponent();
            viewGrid();
        }

        private void ABML_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ViewsLayer.seriesDetails series = new ViewsLayer.seriesDetails();
            series.Show();
            viewGrid();
            this.Hide();
        }

        private void viewGrid()
        {
            dgvSeries.Rows.Clear();
            loadGrid();
        }

        private void loadGrid()
        {
            List<BLseries> bLseries = new List<BLseries>();
            BLseries bLseries1 = new BLseries();
            bLseries = bLseries1.load();
            var bindingList = new BindingList<BLseries>(bLseries);
            var source = new BindingSource(bindingList, null);
            dgvSeries.DataSource = source;
            dgvSeries.Columns["id"].Visible = false;

        }

        private void dgvSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvSeries__SelectionChanged(object sender, EventArgs e)
        {


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSeries.Rows.Count != 1)
            {
                int fila = dgvSeries.CurrentRow.Index;

                if (dgvSeries.Rows[fila].Cells[8].Value.ToString() == "AC")
                {
                    DialogResult dialogResult = MessageBox.Show("¿Seguro que desea modificar este elemento?", "ADVERTEMCIA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (fila != dgvSeries.Rows.Count)
                        {
                            DLseries serie = new DLseries();
                            serie.Id = int.Parse(dgvSeries.Rows[fila].Cells[0].Value.ToString());
                            serie.Title = dgvSeries.Rows[fila].Cells[1].Value.ToString();
                            serie.Description = dgvSeries.Rows[fila].Cells[2].Value.ToString();
                            serie.DateSerie = DateTime.Parse(dgvSeries.Rows[fila].Cells[3].Value.ToString());
                            serie.Stars = int.Parse(dgvSeries.Rows[fila].Cells[4].Value.ToString());
                            serie.Genre = dgvSeries.Rows[fila].Cells[5].Value.ToString();
                            serie.Price = decimal.Parse(dgvSeries.Rows[fila].Cells[6].Value.ToString());
                            serie.Atp = bool.Parse(dgvSeries.Rows[fila].Cells[7].Value.ToString());
                            serie.State = dgvSeries.Rows[fila].Cells[8].Value.ToString();
                            if (serie.State == "AC")
                            {

                                seriesDetails details = new seriesDetails();
                                details.updateSerie(serie);
                                details.Show();
                                this.Hide();
                            }
                            viewGrid();
                        }
                    }
                }
                else { MessageBox.Show("no se puede modificar elementos anulados"); }
            }
            else { MessageBox.Show("no hay elementos seleccionados"); }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSeries.Rows.Count != 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar este elemento?", "ADVERTEMCIA", MessageBoxButtons.YesNo);
                int fila = dgvSeries.CurrentRow.Index;

                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvSeries.CurrentRow.Index != dgvSeries.Rows.Count)
                    {

                        BusinessLayer.BLseries deleteSerie = new BusinessLayer.BLseries();
                        int id = obtainId();
                        deleteSerie.delete(id);
                        viewGrid();
                    }
                }
            }
            else { MessageBox.Show("no hay elementos seleccionados"); }





        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvSeries.Rows.Count != 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Anular este elemento?", "ADVERTEMCIA", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvSeries.CurrentRow.Cells[8].Value.ToString() == "AC")
                    {
                        int id = obtainId();
                        new BLseries().nulled(id);
                        viewGrid();
                    }
                    else
                    { MessageBox.Show("no se puede anular elementos anulados"); }
                }
            }
            else { MessageBox.Show("no hay elementos seleccionados"); }

        }
        public int obtainId()
        {
            int id = int.Parse(dgvSeries.CurrentRow.Cells[0].Value.ToString());
            return id;
        }

        public void updateGreed()
        {
            this.viewGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.viewGrid();
        }
    }
}
