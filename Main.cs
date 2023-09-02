using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MK8Randomizer
{
    public partial class Main : Form
    {
        private BDD data = new BDD();

        public Main()
        {
            MaximizeBox = false;
            InitializeComponent();
            data.PrepareData();
            List<ProgressBar> longPb = new List<ProgressBar>()
            {
                pbCharacterWeight, pbCharacterAccel
            };
            List<ProgressBar> shortPb = new List<ProgressBar>() 
            {
                pbGliderAccel, pbGliderWeight, pbWheelAccel, pbWheelWeight, pbVehiculeAccel, pbVehiculeWeight
            };
            List<ProgressBar> globalPb = new List<ProgressBar>()
            {
                pbGlobalWeight, pbGlobalAccel
            };
            longPb.ForEach(p => { p.Minimum = 0; p.Maximum = 600; });
            shortPb.ForEach(p => { p.Minimum = 0; p.Maximum = 200; });
            globalPb.ForEach(p => { p.Minimum = 0; p.Maximum = 600; });
        }

        private void btnRandomizer_Click(object sender, EventArgs e)
        {
            
            Character myCharacter = data.getRandomCharacter();
            Vehicule myVehicule = data.getRandomVehicule();
            Wheel myWheel = data.getRandomWheel();
            Glider myGlider = data.getRandomGlider();

            setImage(pbCharacter, myCharacter._url);
            setImage(pbVehicule, myVehicule._url);
            setImage(pbWheel, myWheel._url);
            setImage(pbGlider, myGlider._url);

            lblCharacter.Text = myCharacter._name;
            lblVehicule.Text = myVehicule._name;
            lblWheel.Text = myWheel._name;
            lblGlider.Text = myGlider._name;

            if (myCharacter._isdlc == true)
            {
                setImage(characterDlcIcon, "https://cdn.discordapp.com/attachments/833121864972238878/1147355018316484608/Mk8dx_bcp_logo.webp.png");
            }
            else
            {
                setImage(characterDlcIcon, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/HD_transparent_picture.png/1280px-HD_transparent_picture.png");
            }

            pbCharacterWeight.Value = (int)(myCharacter._weight*100);
            pbCharacterAccel.Value = (int)(myCharacter._accel*100);
            
            pbVehiculeWeight.Value = (int)((myVehicule._weight+1)*100);
            pbVehiculeAccel.Value = (int)((myVehicule._accel+1)*100);

            pbWheelWeight.Value = (int)((myWheel._weight+1)*100);
            pbWheelAccel.Value = (int)((myWheel._accel+1)*100);
            
            pbGliderWeight.Value = (int)((myGlider._weight+1)*100);
            pbGliderAccel.Value = (int)((myGlider._accel + 1) * 100);

            pbGlobalWeight.Value = (int)((myCharacter._weight + myVehicule._weight + myWheel._weight + myGlider._weight) * 100);
            pbGlobalAccel.Value = (int)((myCharacter._accel + myVehicule._accel + myWheel._accel + myGlider._accel) * 100);
        }

        private void setImage(PictureBox pb, string imgLink)
        {
            if (!string.IsNullOrEmpty(imgLink))
            {
                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        // Téléchargez l'image à partir de l'URL.
                        byte[] data = webClient.DownloadData(imgLink);

                        // Créez un objet Image à partir des données téléchargées.
                        using (MemoryStream memoryStream = new MemoryStream(data))
                        {
                            Image image = Image.FromStream(memoryStream);

                            // Affichez l'image dans le PictureBox.
                            pb.Image = image;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérez les erreurs de téléchargement d'image ici.
                    MessageBox.Show("Erreur internet : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Erreur url");
            }
        }

        private void Credit_Click(object sender, EventArgs e)
        {
            AboutBox1 rpu = new AboutBox1();
            rpu.ShowDialog();
        }
    }
}
