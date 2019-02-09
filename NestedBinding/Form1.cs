using NestedBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            personBindingSource.DataSource = new Person
            {
                Alter = 21,
                Name = "Hans",
                Addresses = new List<Address>
                {
                    new Address { Ort = "Amerang", PLZ = 56789, Straße = "Nussbaumstraße" },
                    new Address { Ort = "Amerang2", PLZ = 56789, Straße = "Nussbaumstraße" }
                }
            };

            addressesBindingSource.DataSource = personBindingSource;
            addressesBindingSource.DataMember = nameof(Person.Addresses);
        }
    }
}
