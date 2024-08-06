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

            _player = new Player();

            _player.CurrentHitPoints = 10;
            _player.MaximunHitPoints = 20;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;

            lbl_Gold.Text = _player.Gold.ToString();
            lbl_Level.Text = _player.Level.ToString();
            lbl_Experience.Text = _player.ExperiencePoints.ToString();
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            
        }

        
    }
}
