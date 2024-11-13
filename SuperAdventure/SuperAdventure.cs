using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(10,10,20,0,1 );
          
            lbl_Gold.Text = _player.Gold.ToString();
            lbl_Level.Text = _player.Level.ToString();
            lbl_Experience.Text = _player.ExperiencePoints.ToString();
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();

            Location location = new Location( 1, "Casa", "Essa é a sua casa");



        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnWeast_Click(object sender, EventArgs e)
        {

        }


        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
