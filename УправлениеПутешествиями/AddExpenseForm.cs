using System.Windows.Forms;

namespace УправлениеПутешествиями
{

    public class AddExpenseForm : Form
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public AddExpenseForm()
        {
            this.Text = "Добавить расход"; this.Width = 300; this.Height = 150;
            CreateControls();
        }

        private void CreateControls()
        {
            var descriptionLabel = new Label
            {
                Location = new System.Drawing.Point(10, 10),
                Text = "Описание:",
                AutoSize = true
            };

            var amountLabel = new Label
            {
                Location = new System.Drawing.Point(10, 40),
                Text = "Сумма:",
                AutoSize = true
            };

            var descriptionTextBox = new TextBox
            {
                Location = new System.Drawing.Point(100, 10),
                Size = new System.Drawing.Size(170, 20)
            };

            var amountTextBox = new TextBox
            {
                Location = new System.Drawing.Point(100, 40),
                Size = new System.Drawing.Size(170, 20)
            };

            var okButton = new Button
            {
                Location = new System.Drawing.Point(10, 70),
                Text = "OK",
                Size = new System.Drawing.Size(75, 25)
            };
            okButton.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(descriptionTextBox.Text) && decimal.TryParse(amountTextBox.Text, out decimal amount))
                {
                    Description = descriptionTextBox.Text;
                    Amount = amount;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, заполните все поля корректными значениями.");
                }
            };

            var cancelButton = new Button
            {
                Location = new System.Drawing.Point(195, 70),
                Text = "Отмена",
                Size = new System.Drawing.Size(75, 25)
            };
            cancelButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            this.Controls.Add(descriptionLabel); this.Controls.Add(amountLabel); this.Controls.Add(descriptionTextBox); this.Controls.Add(amountTextBox); this.Controls.Add(okButton); this.Controls.Add(cancelButton);
        }
    }

}
