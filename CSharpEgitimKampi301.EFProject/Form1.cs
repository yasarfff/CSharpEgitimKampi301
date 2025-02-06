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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities(); // Tablo nesnesini tek tek yazmak yerine süslü parantezlerin dışına ekleyerek bütün süslü parantezler blogları içinden erişim sağlayabiliriz.
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide =new Guide();
            guide.GuideName =txtName.Text;
            guide.GuideSurname =txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Bilgisi Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Id değeri benzersiz olduğu için silme işlemlerini Id üzerinden gerçekleştireceğiz.

            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Bilgisi Başarıyla Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Güncelleme işlemi iki adımdan oluşur.
            // 1. adım : Güncellenecek olan Id bulunur.
            // 2. adım : verilen şarta göre güncellemeyi gerçekleştirir.

            int id= int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName =txtName.Text;
            updateValue.GuideSurname=txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Bilgisi Başarıyla Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x =>x.GuideId == id).ToList(); // Değerin getirilme şartı; girilen ıd ile eşleşen ıd yi getirir.
            dataGridView1.DataSource = values; // değeri getirir.
        }
    }
}
