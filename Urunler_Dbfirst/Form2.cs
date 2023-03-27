using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urunler_Dbfirst.Models;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Urunler_Dbfirst
{
    
    public partial class Form2 : Form
    {
        ASILAR_TESTEntities2 db = new ASILAR_TESTEntities2();
        public string formid = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

     

        private void listeleButton_Click(object sender, EventArgs e)
        {
            if (formid == "1")
            {
                var inaktif = from p1 in db.TBL_URUN
                              where p1.URUN_TUR =="İnaktif"
                              join p2 in db.TBL_STOK
                              on p1.ID equals p2.STOK_ADI
                              join p3 in db.TBL_DOZ
                              on p2.S_ID equals p3.DOZ_ADI
                              join p4 in db.TBL_TASIMA
                              on p3.DOZ_ADI equals p4.U_TASIMA

                              select new
                              {
                                  URUN = p1.URUN_AD,
                                  SERI_NO = p2.SERİ_NO,
                                  TOPLAM_DOZ = p3.MIKTAR,
                                  MIAT = p3.MIAT,
                                  TASIMA_TIPI = p4.TASIMA_TIPI,
                                  URUN_TIPI = p1.URUN_TUR,
                                  ID = p2.S_ID,
                                  URUN_ID = p1.ID,
                                  DOZ_ID = p3.D_ID,
                                  TAS_ID = p4.T_ID
                              };

                dataGridView1.DataSource = inaktif.ToList();
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;

            }
            else if (formid =="2")
            {
                var aktifler = from p1 in db.TBL_URUN
                               where p1.URUN_TUR =="Aktif"
                               join p2 in db.TBL_STOK
                               on p1.ID equals p2.STOK_ADI
                               join p3 in db.TBL_DOZ
                               on p2.S_ID equals p3.DOZ_ADI
                               join p4 in db.TBL_TASIMA
                               on p3.DOZ_ADI equals p4.U_TASIMA

                               select new
                               {
                                   URUN = p1.URUN_AD,
                                   SERI_NO = p2.SERİ_NO,
                                   TOPLAM_DOZ = p3.MIKTAR,
                                   MIAT = p3.MIAT,
                                   TASIMA_TIPI = p4.TASIMA_TIPI,
                                   URUN_TIPI = p1.URUN_TUR,
                                   ID = p2.S_ID,
                                   URUN_ID = p1.ID,
                                   DOZ_ID = p3.D_ID,
                                   TAS_ID = p4.T_ID
                               };

                dataGridView1.DataSource = aktifler.ToList();
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;

            }
                        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxUrun.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxDoz.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBoxTasima.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            pictureBox1.Image = Image.FromFile("C:\\Users\\akif_\\OneDrive\\Resimler\\KAREKODLAR\\karekod.jpg");

        }

        private void araButton_Click(object sender, EventArgs e)
        {
            if (formid == "1")
            {
                var urunara = from p1 in db.TBL_URUN where p1.URUN_TUR =="İnaktif"
                              where p1.URUN_AD.Contains(textBoxara.Text)
                              join p2 in db.TBL_STOK
                              on p1.ID equals p2.STOK_ADI
                              join p3 in db.TBL_DOZ
                              on p2.S_ID equals p3.DOZ_ADI
                              join p4 in db.TBL_TASIMA
                              on p3.DOZ_ADI equals p4.U_TASIMA
                              select new
                              {
                                  URUN = p1.URUN_AD,
                                  SERI_NO = p2.SERİ_NO,
                                  TOPLAM_DOZ = p3.MIKTAR,
                                  MIAT = p3.MIAT,
                                  TASIMA_TIPI = p4.TASIMA_TIPI,
                                  URUN_TIPI = p1.URUN_TUR,
                                  ID = p2.S_ID,
                                  URUN_ID = p1.ID,
                                  DOZ_ID = p3.D_ID,
                                  TAS_ID = p4.T_ID
                              };


                dataGridView1.DataSource = urunara.ToList();
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }

            else if (formid =="2")
            {
                var urunara = from p1 in db.TBL_URUN
                              where p1.URUN_TUR == "Aktif"
                              where p1.URUN_AD.Contains(textBoxara.Text)
                              join p2 in db.TBL_STOK
                              on p1.ID equals p2.STOK_ADI
                              join p3 in db.TBL_DOZ
                              on p2.S_ID equals p3.DOZ_ADI
                              join p4 in db.TBL_TASIMA
                              on p3.DOZ_ADI equals p4.U_TASIMA
                              select new
                              {
                                  URUN = p1.URUN_AD,
                                  SERI_NO = p2.SERİ_NO,
                                  TOPLAM_DOZ = p3.MIKTAR,
                                  MIAT = p3.MIAT,
                                  TASIMA_TIPI = p4.TASIMA_TIPI,
                                  URUN_TIPI = p1.URUN_TUR,
                                  ID = p2.S_ID,
                                  URUN_ID = p1.ID,
                                  DOZ_ID = p3.D_ID,
                                  TAS_ID = p4.T_ID

                              };


                dataGridView1.DataSource = urunara.ToList();
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }



        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            var guncellestok = db.TBL_STOK.Find(id);
            guncellestok.SERİ_NO = textBox2.Text;

            int idurun = Convert.ToInt32(textBoxUrun.Text);
            var guncelleurun = db.TBL_URUN.Find(idurun);
            guncelleurun.URUN_AD = textBox1.Text;

            int iddoz = Convert.ToInt32(textBoxDoz.Text);
            var guncelledoz = db.TBL_DOZ.Find(iddoz);
            guncelledoz.MIKTAR = textBox5.Text;
            guncelledoz.MIAT = Convert.ToDateTime(textBox3.Text);

            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.");

            

        }

        private void silBbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            var stoksil = db.TBL_STOK.Find(id);
            db.TBL_STOK.Remove(stoksil);            

            int iddoz = Convert.ToInt32(textBoxDoz.Text);
            var dozsil = db.TBL_DOZ.Find(iddoz);
            db.TBL_DOZ.Remove(dozsil);

            int idtasima = Convert.ToInt32(textBoxTasima.Text);
            var tassil = db.TBL_TASIMA.Find(idtasima);
            db.TBL_TASIMA.Remove(tassil);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi!");


        }
    }
}
