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
        poker s = new poker();
        List<int> poker = s.GetPoker(52);

        public frmGame()
        {
            InitializeComponent();

        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 53; i++)
            {
                
               
                
                pokerpicture.Add(Resources.p1);
                pokerpicture.Add(Resources.p2);
                pokerpicture.Add(Resources.p3);
                pokerpicture.Add(Resources.p4);
                pokerpicture.Add(Resources.p5);
                pokerpicture.Add(Resources.p6);
                pokerpicture.Add(Resources.p7);
                pokerpicture.Add(Resources.p8);
                pokerpicture.Add(Resources.p9);
                pokerpicture.Add(Resources.p10);
                pokerpicture.Add(Resources.p11);
                pokerpicture.Add(Resources.p12);
                pokerpicture.Add(Resources.p13);
                pokerpicture.Add(Resources.p14);
                pokerpicture.Add(Resources.p15);
                pokerpicture.Add(Resources.p16);
                pokerpicture.Add(Resources.p17);
                pokerpicture.Add(Resources.p18);
                pokerpicture.Add(Resources.p19);
                pokerpicture.Add(Resources.p20);
                pokerpicture.Add(Resources.p21);
                pokerpicture.Add(Resources.p22);
                pokerpicture.Add(Resources.p23);
                pokerpicture.Add(Resources.p24);
                pokerpicture.Add(Resources.p25);
                pokerpicture.Add(Resources.p26);
                pokerpicture.Add(Resources.p27);
                pokerpicture.Add(Resources.p28);
                pokerpicture.Add(Resources.p29);
                pokerpicture.Add(Resources.p30);
                pokerpicture.Add(Resources.p31);
                pokerpicture.Add(Resources.p32);
                pokerpicture.Add(Resources.p33);
                pokerpicture.Add(Resources.p34);
                pokerpicture.Add(Resources.p35);
                pokerpicture.Add(Resources.p36); 
                pokerpicture.Add(Resources.p37);
                pokerpicture.Add(Resources.p38);
                pokerpicture.Add(Resources.p39);
                pokerpicture.Add(Resources.p40);
                pokerpicture.Add(Resources.p41);
                pokerpicture.Add(Resources.p42);
                pokerpicture.Add(Resources.p43);
                pokerpicture.Add(Resources.p44);
                pokerpicture.Add(Resources.p45);
                pokerpicture.Add(Resources.p46);
                pokerpicture.Add(Resources.p47);
                pokerpicture.Add(Resources.p48);
                pokerpicture.Add(Resources.p49);
                pokerpicture.Add(Resources.p50);
                pokerpicture.Add(Resources.p51);
                pokerpicture.Add(Resources.p52);

                

            }
        }

        private void rtbshow_TextChanged(object sender, EventArgs e)
        {

        }
        


        int i = 1;
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
