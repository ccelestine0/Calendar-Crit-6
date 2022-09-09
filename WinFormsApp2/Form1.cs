namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        //The numbered words papir with an integer to be used later on in the code
        Dictionary<string, int> dictDay = new Dictionary<string, int>()
            {
                {"one", 2},
                {"two", 5},
                {"three", 3},
                {"four", 8},
            };
        //Month dates are differentiated in the code with a capitalised first letter
        //the function of this dictionary is mostly identical to the one above
        Dictionary<string, int> dictMonth = new Dictionary<string, int>()
            {
                {"One", 1},
                {"Two", 8},
                {"Three", 3},
                {"Four", 8},
            };
        public Form1()
        {
            InitializeComponent();
            int count = Convert.ToInt32(Math.Round(numDay.Value, 0));

            //Setting the dates that will be bolded to the units specified in the dictionary above
            monthCalendar1.MaxSelectionCount = 1;
            DateTime SetDate1 = new (2022, dictMonth["Two"], dictDay["one"]);
            //Setting the dates specified above to bold
            DateTime[] SetBoldDates = { SetDate1, };
            monthCalendar1.BoldedDates = SetBoldDates;
            monthCalendar1.FirstDayOfWeek = Day.Monday;

            //Caps the maximum values you can input
            numDay.Maximum = 31;
            numDay.Minimum = 1;
            numMonth.Maximum = 12;
            numMonth.Minimum = 1;
        }

        private void MonthCalendar1_Click(object sender, DateRangeEventArgs e)
        {
            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete all of the dates?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //I clear all of the bolded dates by setting them to nothing and updating them
                DateTime[] SetBoldDates = Array.Empty<DateTime>();
                monthCalendar1.BoldedDates = SetBoldDates;
                monthCalendar1.UpdateBoldedDates();
            }
            else
            {
             
            }
            

        }

        private void BtnAddDate_Click(object sender, EventArgs e)
        {
            //assigns name to the currently selected value from both
            //numericalupdown1 and 2, then it sets it to bold and refreshes all of the dates
            dictDay[txtName.Text] = (int)numDay.Value;
            dictMonth[txtName.Text] = (int)numMonth.Value;
            DateTime SetDate1 = new(2022, dictMonth[txtName.Text], dictDay[txtName.Text]);
            DateTime[] SetBoldDates = { SetDate1 };
            monthCalendar1.BoldedDates = SetBoldDates;
            monthCalendar1.UpdateBoldedDates();

            //List<DateTime> SetDateList = new List<DateTime>();
            //SetDateList.Add(new(2022, dictMonth[txtName.Text], dictDay[txtName.Text]));
            //DateTime[] SetBoldDates = { SetDateList.AddRange() };
            //monthCalendar1.BoldedDates = SetDateList.ToArray();

        }
    }
}