using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UczelniaApp.UczelniaTableAdapters;

namespace UczelniaApp
{
    public partial class MainForm : Form
    {
        private podrozeTableAdapter podrozeTableAdapter = new podrozeTableAdapter();
        private miejscowosciTableAdapter miejscowosciTableAdapter = new miejscowosciTableAdapter();
        private zdjeciaTableAdapter zdieciaTableAdapter = new zdjeciaTableAdapter();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.osobyTableAdapter.Fill(this.uczelnia.osoby);
            this.podrozeTableAdapter.Fill(this.uczelnia.podroze);
            this.miejscowosciTableAdapter.Fill(this.uczelnia.miejscowosci);
            this.zdieciaTableAdapter.Fill(this.uczelnia.zdjecia);

            //załadowanie danych do widoków
            LoadPodrozeDataSource();
            LoadPodrozeZdjecia();
            LoadRaportDataSource();
            SetRaportChartPoints();

            this.podrozeGridView.Columns["nr_podorozy"].Visible = false;
        }

        #region Wyszukiwanie po nazwisku, zapisywanie zmian w tabeli osób

        /// <summary>
        /// Czytanie zawartości textbox po nacisnieciusz szukaj i filtracja tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void osobySearchButton_Click(object sender, EventArgs e)
        {
            var filterParam = this.osobySearchTextBox.Text; 
            this.osobyBindingSource.Filter = $"nazwisko LIKE '%{filterParam}%'";
        }

        /// <summary>
        /// Nacisniecie zapisz, zapisuje zmiany w tabeli do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void osobySaveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.osobyBindingSource.EndEdit();
            this.osobyTableAdapter.Update(this.uczelnia.osoby);
            MessageBox.Show("Zakutalizowano dane", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Wyszukiwanie po nazwisku, zapisywanie zmian w tabeli osób

        #region Obsługa nawigacji w panelu podróże

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LoadPodrozeDataSource();
            LoadPodrozeZdjecia();
        }
        
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LoadPodrozeDataSource();
            LoadPodrozeZdjecia();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LoadPodrozeDataSource();
            LoadPodrozeZdjecia();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LoadPodrozeDataSource();
            LoadPodrozeZdjecia();
        }

        #endregion Obsługa nawigacji w panelu podróże

        #region Obsługa zdarzeń w listach, tabelach

        /// <summary>
        /// Wybór zdjęcia do wyswietlenia z listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void zdjeciaListView_MouseClick(object sender, MouseEventArgs e)
        {
            SetPictureBoxImage();
        }

        /// <summary>
        /// Załadowanie zdjęć do listy zdjęć z wybranej podróży
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void podrozeGridView_MouseClick(object sender, MouseEventArgs e)
        {
            LoadPodrozeZdjecia();
            SetPictureBoxImage();
        }

        /// <summary>
        /// Załadowanie danych to wykresu podczas zmiany osoby na lisci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void raportGridVIew_Click(object sender, EventArgs e)
        {
            SetRaportChartPoints();
        }

        #endregion Obsługa zdarzeń w listach, tabelach

        #region Metody Pomocnicze
        private void LoadPodrozeDataSource()
        {
            var currentOsoba = ((DataRowView)this.osobyBindingSource.Current).Row as Uczelnia.osobyRow;

            var podroze = podrozeTableAdapter.GetData();
            var miejscowosci = miejscowosciTableAdapter.GetData();

            this.podrozeBindingSource.DataSource = podroze
                .Where(x => x.nr_osoby == currentOsoba.nr_osoby)
                .Join(miejscowosci,
                    p => p.nr_miejscowosci,
                    m => m.nr_miejscowosci,
                    (p, m) => new
                    {
                        p.nr_podrozy,
                        p.data,
                        nazwa = m.IsnazwaNull() ? String.Empty : m.nazwa.ToString(),
                        opis = p.IsopisNull() ? String.Empty : p.opis.ToString()
                    });
        }

        private void LoadPodrozeZdjecia()
        {
            var currentPodroz = this.podrozeBindingSource.Current;
            var nrPodrozyPropertyInfo = currentPodroz.GetType().GetProperty("nr_podrozy");
            
            if(nrPodrozyPropertyInfo != null)
            {
                var nrPodrozy = nrPodrozyPropertyInfo.GetValue(currentPodroz, null);

                var zdjecia = this.zdieciaTableAdapter.GetData()
                    .Where(x => x.nr_podrozy == (int)nrPodrozy);

                ImageConverter converter = new ImageConverter();
                this.zdjeciaImageList.Images.Clear();
                foreach (var item in zdjecia)
                {
                    try
                    {
                        var image = (Image)converter.ConvertFrom(item.zdjecie);
                        this.zdjeciaImageList.Images.Add($"{image.GetHashCode()}", image);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                this.zdjeciaListView.Items.Clear();
                for (int j = 0; j < this.zdjeciaImageList.Images.Count; j++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = j;
                    this.zdjeciaListView.Items.Add(item);
                }
            }

        }

        private void SetPictureBoxImage()
        {
            if(zdjeciaListView.SelectedItems.Count > 0)
            {
                var item = zdjeciaListView.SelectedItems[0];
                this.podrozePictureBox.Image = item.ImageList.Images[item.ImageIndex];
            }
            else
            {
                this.podrozePictureBox.Image = null;
            }
        }

        private void LoadRaportDataSource()
        {
            var osoby = osobyTableAdapter.GetData();
            var podroze = podrozeTableAdapter.GetData();
            var miejscowosci = miejscowosciTableAdapter.GetData();

            // połaczenie podróży z miejscowosciami
            var podrozeWithMiejscowosci = 
                from p in podroze
                join m in miejscowosci on p.nr_miejscowosci equals m.nr_miejscowosci
                select new {
                    p.nr_osoby,
                    p.nr_podrozy,
                    m.nazwa
                };

            // LEFT JOIN osób z podróżami
            this.chartBindingSource.DataSource = (
                from o in osoby
                join pm in podrozeWithMiejscowosci on o.nr_osoby equals pm.nr_osoby into opm
                from z in opm.DefaultIfEmpty()
                select new {
                    o.nr_osoby,
                    o.imie,
                    o.nazwisko,
                    nazwa = z?.nazwa
                })
                .GroupBy(x => x.nr_osoby)
                .Select(x => new {
                    x.FirstOrDefault().nr_osoby,
                    x.FirstOrDefault().imie,
                    x.FirstOrDefault().nazwisko,
                    podrozeCount = x.Count(d => d.nazwa != null)
                });
        }

        private void SetRaportChartPoints()
        {
            var currentOsoba = this.chartBindingSource.Current;
            var nrOsobyPropertyInfo = currentOsoba.GetType().GetProperty("nr_osoby");

            this.raportChart.Series[0].Points.DataBindXY(Enumerable.Empty<string>(), Enumerable.Empty<int>());

            if(nrOsobyPropertyInfo != null)
            {
                var nrOsoby = nrOsobyPropertyInfo.GetValue(currentOsoba, null);

                var podroze = podrozeTableAdapter.GetData();
                var miejscowosci = miejscowosciTableAdapter.GetData();

                var chartData = (
                    from p in podroze
                    join m in miejscowosci on p.nr_miejscowosci equals m.nr_miejscowosci
                    where p.nr_osoby == (int)nrOsoby
                    select new
                    {
                        p.nr_podrozy,
                        m.nr_miejscowosci,
                        m.nazwa
                    })
                    .GroupBy(x => x.nr_miejscowosci)
                    .Select(x => new {
                        x = x.FirstOrDefault().nazwa,
                        y = x.Count()
                    });

                this.raportChart.Series[0].Points.DataBindXY(chartData.Select(data => data.x).ToArray(), chartData.Select(data => data.y).ToArray());
            }



        }

        #endregion Metody Pomocnicze
    }
}