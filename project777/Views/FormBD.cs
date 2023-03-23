using project777.DataBase;
using project777.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project777
{
    public partial class FormBD : Form
    {

        private User _user;
        public FormBD(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBD_Load(object sender, EventArgs e)
        {
            var context = new Context();
            var usertrips = context.UserTrips
                .Join(context.Users, ut => ut.UserID, u => u.Id, (us, u) => new { UserTripId = us.Id, us.TripId, u.Lastname, u.Name, u.Surname })
                .Join(context.Trips, u => u.TripId, t => t.Id, (u, t) => new { u.UserTripId, u.Lastname, u.Name, u.Surname, t.BeginDate, t.EndDate, t.CityId })
                .Join(context.Cities, u => u.CityId, c => c.Id, (u, c) => new UserTripDataGrid
                {
                    Id = u.UserTripId,
                    LastName = u.Lastname,
                    Name = u.Name,
                    SurName = u.Surname,
                    BeginDate = u.BeginDate,
                    EndDate = u.EndDate,
                    City = c.Name
                }).ToList();
            var bindinglist = new BindingList<UserTripDataGrid>(usertrips);
            var source = new BindingSource(bindinglist, null);
            dg_bd.DataSource = source;

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
    }
}
