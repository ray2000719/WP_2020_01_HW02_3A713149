using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713149.Properties;

namespace WP_2020_01_HW02_3A713149
{
    
    public partial class frmGame : Form
    {

        List<Image> pokerpicture = new List<Image>();
        poker p = null;
        List<int> poker;

        public frmGame()
        {
            InitializeComponent();

        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 53; i++)
            {
                string resourceName = i.ToString();
                string resourceNum = "p" + resourceName;
                Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceNum);
                pokerpicture.Add(bmp);
                p = new poker();
                poker = p.GetPoker(52);
               
                
                
            }
        }

        private void rtbshow_TextChanged(object sender, EventArgs e)
        {

        }
        


        int i = 0;
        private void btnPump_Click(object sender, EventArgs e)
        {
            if (i<52)
            {
                


                pbshow.Image = pokerpicture[poker[i]];
                rtbshow.Text += poker[i]+1 + ",";
                i =  i + 1;
                
            }
         
            
        }

        private void pbshow_Click(object sender, EventArgs e)
        {

        }

        
    }
}
