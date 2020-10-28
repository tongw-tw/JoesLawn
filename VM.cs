using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace JoesLawn
{
    class VM : INotifyPropertyChanged
    {
        public String Name { get => name; set { name = value; onChange(); } }
        private String name;
        public String Street { get => street; set { street = value; onChange(); } }
        private String street;
        public String City { get => city; set { city = value; onChange(); } }
        private String city;
        public String PostalCode { get => postalCode; set { postalCode = value; onChange(); } }
        private String postalCode;
        public String Phone { get => phone; set { phone = value; onChange(); } }
        private String phone;
        public decimal Size { get => size; set { size = value; onChange(); } }
        private decimal size;
        public String Date { get => date; set { date = value; onChange(); } }
        private String date;

        private decimal grassCost;
        const decimal GRASS_CHARGE = 4.99m;
        private decimal weedCost;
        const decimal WEED_CHARGE = 7.99m;
        private decimal fullCost;
        const decimal FULL_CHARGE = 9.99m;
        private decimal total;
        private decimal subtotal;
        private decimal hst;
        const decimal TAX_RATE = 0.13m;
        private string fileName;
        private string path;
        const string LAST_DIR = "JoeLawnService";

        public enum services
        {
            full,
            grass,
            weed
        }


        public Enum getValue(Enum serv)
        {
            return serv;
        }
        public void calc(Enum serv)
        {
            grassCost = size * GRASS_CHARGE;
            weedCost = size * WEED_CHARGE;
            fullCost = size * FULL_CHARGE;
            if (serv.full)
            {
                subtotal = fullCost;
            }
            else if (serv.grass)
            {
                subtotal = grassCost;
            }
            else
            {
                subtotal = weedCost;
            }

            hst = subtotal * TAX_RATE;
            total = subtotal + hst;
        }

        public void receipt()
        {
            fileName = name + date + ".txt";

            // create directory
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), LAST_DIR);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Path.Combine(path, fileName);

            File.WriteAllText(path, "Appointment #:".PadRight(100));
            string temp = $"\n\n{name}\n{street}\n{City}\t{postalCode}\n{phone}\n\n{date}";
            File.AppendAllText(path, temp.PadRight(100));
            File.AppendAllText(path, date.PadLeft(100));

        }




        #region PropChange
        public event PropertyChangedEventHandler PropertyChanged;

        private void onChange([CallerMemberName] string property = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        #endregion
    }
}
