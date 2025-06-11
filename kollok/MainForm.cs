using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kollok
{
    public partial class MainForm : Form
    {

        List<Equipment> equipments = new List<Equipment>();
        List<Booking> bookings = new List<Booking>();

        public MainForm()
        {
            InitializeComponent();
            equipments.Add(new Equipment("Экскаватор", "C", 3));
            equipments.Add(new Equipment("Бульдозер", "K", 2));
            equipments.Add(new Equipment("Кран", "L", 1));
            UpdateEquipmentList();
            UpdateBookingList();
        }

        private void UpdateEquipmentList()
        {
            listBoxEquipment.Items.Clear();
            foreach (var eq in equipments)
            {
                listBoxEquipment.Items.Add(eq);
            }
        }

        private void UpdateBookingList()
        {
            listBoxBooking.Items.Clear();
            foreach (var bk in bookings)
            {
                listBoxBooking.Items.Add(bk);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (listBoxEquipment.SelectedItem is Equipment selected)
            {
                var bookingForm = new BookingForm(selected);
                if (bookingForm.ShowDialog() == DialogResult.OK)
                {
                    bookings.Add(bookingForm.NewBooking);
                    selected.AvailableCount--;
                    UpdateEquipmentList();
                    UpdateBookingList();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            var filteredBookings = new List<Booking>();
            foreach (var booking in bookings)
            {
                if (booking.EndDate <= today)
                {
                    filteredBookings.Add(booking);
                }
            }
            bookings = filteredBookings;
            UpdateBookingList();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
