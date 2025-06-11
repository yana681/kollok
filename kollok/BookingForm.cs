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
    public partial class BookingForm : Form
    {

        public Booking NewBooking { get; private set; }
        private Equipment equipment;

        public BookingForm(Equipment eq)
        {
            InitializeComponent();
            equipment = eq;
            Text = $"Бронирование: {eq.Type} {eq.Brand}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите имя прораба.");
                return;
            }

            if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала.");
                return;
            }

            NewBooking = new Booking(equipment, textBoxName.Text, dateTimePickerStart.Value, dateTimePickerEnd.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
