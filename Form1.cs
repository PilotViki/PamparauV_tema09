using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slotss
{
    public partial class Form1 : Form
    {
        List<Image> imaginiSloturi = new List<Image>();
        Random rnd = new Random();

        
        int credite = 100;      
        int costTragere = 10;   
        int premiu = 50;        

        public Form1()
        {
            InitializeComponent();
            IncarcaImagini();
            ActualizeazaCrediteUI(); 
        }

        private void IncarcaImagini()
        {
            
            imaginiSloturi.Add(Properties.Resources.img1);
            imaginiSloturi.Add(Properties.Resources.img2);
            imaginiSloturi.Add(Properties.Resources.img3);
            imaginiSloturi.Add(Properties.Resources.img4);

           
            pbSlot1.Image = imaginiSloturi[0];
            pbSlot2.Image = imaginiSloturi[0];
            pbSlot3.Image = imaginiSloturi[0];
        }

        private void ActualizeazaCrediteUI()
        {
            lblCredite.Text = "Credite: " + credite;

           
            if (credite < costTragere)
            {
                lblCredite.ForeColor = Color.Red;
            }
            else
            {
                lblCredite.ForeColor = Color.Black; 
            }
        }

        private async void btnTrage_Click(object sender, EventArgs e)
        {
            
            if (credite < costTragere)
            {
                MessageBox.Show("Nu mai ai suficiente credite! Jocul s-a terminat.", "Game Over");
                return; 
            }

            credite = credite - costTragere;
            ActualizeazaCrediteUI();

            lblRezultat.Text = "Rotire...";
            lblRezultat.ForeColor = Color.Black;
            btnTrage.Enabled = false;
            numCicluri.Enabled = false;

            int numarCicluri = (int)numCicluri.Value;
            int index1 = 0, index2 = 0, index3 = 0;

            
            for (int i = 0; i < numarCicluri; i++)
            {
                index1 = rnd.Next(imaginiSloturi.Count);
                index2 = rnd.Next(imaginiSloturi.Count);
                index3 = rnd.Next(imaginiSloturi.Count);

                pbSlot1.Image = imaginiSloturi[index1];
                pbSlot2.Image = imaginiSloturi[index2];
                pbSlot3.Image = imaginiSloturi[index3];

                await Task.Delay(200); 
            }

            
            VerificaCastig(index1, index2, index3);

            
            btnTrage.Enabled = true;
            numCicluri.Enabled = true;
        }

        private void VerificaCastig(int i1, int i2, int i3)
        {
            if (i1 == i2 && i2 == i3)
            {
                credite = credite + premiu; 
                ActualizeazaCrediteUI();

                lblRezultat.Text = "JACKPOT! Ai câștigat " + premiu + " credite!";
                lblRezultat.ForeColor = Color.Green;
                MessageBox.Show("Bravo! Ai câștigat " + premiu + " credite!", "Victorie");
            }
            else
            {
                lblRezultat.Text = "Mai încearcă";
                lblRezultat.ForeColor = Color.Red;
            }
        }
        private void pSlot1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
