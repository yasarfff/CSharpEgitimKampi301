﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            lblLocationCount.Text = db.Location.Count().ToString(); // Lokasyon tablosunu say

            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString(); // Turdaki toplam kapasite

            lblGuideCount.Text = db.Guide.Count().ToString(); // Toplam rehber sayısı

            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).GetValueOrDefault().ToString("F2"); // Ortalama kapasite sayısı

            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).GetValueOrDefault().ToString("F2") + " ₺"; // Ortalama tur fiyatı

            int lastCountryId = db.Location.Max(x => x.LocationId); // Önce eklenen son ülkenin id'sini buluyoruz.
            lblLastCountryName.Text = db.Location.Where(x=>x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault(); // Eklenen Son Ülke

            lblCappadociaLocationCapacity.Text = db.Location.Where(x=>x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString(); // Kapadokya tur kapasitesini getirir

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).GetValueOrDefault().ToString("F2");    // Türkiye ortalama tur kapasitesi

            var romeGuideId = db.Location.Where(x => x.City == "Roma Turistlik").Select(y => y.GuideId).FirstOrDefault(); // ilk olarak roma gezisinin rehber id'sini buluyoruz.  
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();   // Roma gezisinin rehberinin ismini getirme

            var maxCapacity = db.Location.Max(x => x.Capacity);  // İlk olarak en yüksek kapasiteyi bulmamız gerekiyor.
            lblMAxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();    // En yüksek kapasiteli turun ismini bulur.

            var maxPrice = db.Location.Max(x => x.Price); // İlk olarak En yüksek tur fiyatını buluyoruz.
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString(); // En yüksek tur fiyatına sahip turu getirdik.

            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y =>y.GuideId).FirstOrDefault();  
            lblAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();

        }

        private void lblSumCapacity_Click(object sender, EventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
