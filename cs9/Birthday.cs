namespace cs9
{
    struct Birthday
    {
        public DateTime BirthDate;
        public Birthday(int year, int month, int day)
        {
            BirthDate = new DateTime(year, month, day);
        }
        public void SetBirthDate(int year, int month, int day)
        {
            BirthDate = new DateTime(year, month, day);
        }
        public DayOfWeek DayOfBirth()
        {
            return BirthDate.DayOfWeek;
        }

        public DayOfWeek DayOfWeekInYear(int year)
        {
            DateTime birthdayInYear = new DateTime(year, BirthDate.Month, BirthDate.Day);
            return birthdayInYear.DayOfWeek;
        }
        public int DaysUntilBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, BirthDate.Month, BirthDate.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            return (nextBirthday - today).Days;
        }
        public override string ToString() => $"Birth Date: {BirthDate}";
    }
}
