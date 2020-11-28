namespace Assignment
{
    public class CustomerInformation
    {
        private string firstName;
        private string lastName;
        private string middleInitial;
        private string gender;
        private string favoriteColor;
        private string dateOfBirth;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string MiddleInitial
        {
            get => middleInitial;
            set => middleInitial = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public string FavoriteColor
        {
            get => favoriteColor;
            set => favoriteColor = value;
        }

        public string DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }
    }
}