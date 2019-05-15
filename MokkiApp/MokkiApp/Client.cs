namespace MokkiApp
{
    class Client
    {
        public int ClientID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public Client(string Firstname, string Lastname, string Address, string Zip, string City, string Email, string Phone)
        {
            if (!(Firstname == "" || Lastname == "" || Address == "" || Zip == "" || City == "" || Email == "" || Phone == null))
            {
                this.Firstname = Firstname;
                this.Lastname = Lastname;
                this.Address = Address;
                this.Zip = Zip;
                this.City = City;
                this.Email = Email;
                this.Phone = Phone;
                ClientID = ClientUtils.GetId();
            }
        }

    }
}
