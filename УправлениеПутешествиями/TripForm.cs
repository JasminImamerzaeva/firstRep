using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УправлениеПутешествиями
{
    public partial class TripForm : Form
    {
        private Trip trip;
        private Button addExpenseButton;
        private Button displayDetailsButton;

        public TripForm(Trip trip)
        {
            this.trip = trip;
            this.Text = "Управление путешествием";
            this.Width = 300;
            this.Height = 150;
            CreateControls();
        }

        private void CreateControls()
        {
            addExpenseButton = new Button
            {
                Location = new System.Drawing.Point(10, 20),
                Text = "Добавить расход",
                Size = new System.Drawing.Size(100, 25)
            };
            addExpenseButton.Click += (sender, e) =>
            {
                var addExpenseForm = new AddExpenseForm();
                addExpenseForm.ShowDialog();
                if (addExpenseForm.DialogResult == DialogResult.OK)
                {
                    var expense = new Expense(addExpenseForm.Description, addExpenseForm.Amount);
                    trip.AddExpense(expense);
                }
            };

            displayDetailsButton = new Button
            {
                Location = new System.Drawing.Point(120, 20),
                Text = "Показать детали",
                Size = new System.Drawing.Size(100, 25)
            };
            displayDetailsButton.Click += (sender, e) => trip.DisplayTripDetails();

            this.Controls.Add(addExpenseButton);
            this.Controls.Add(displayDetailsButton);
        }
    }

}
