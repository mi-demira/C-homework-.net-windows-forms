using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калкулатор_куриерски_пратки
{

  
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //zatvarqme formata - this sochi formata
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //validaciq dali informaciqta e pravilno vuvedena - ako ne - message box ! 
            string FirstName = txtFirstName.Text;
            string SecondName = txtSecondName.Text;

            //proverka dali sa vuvedeni imenata
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(SecondName))
            {
                MessageBox.Show("First and family name is needed. Please fill them in! ");
                return;
            }

            //proverka teglo i razstoqnie
            //out double weight - suzdavane na nova promenliva, ako vsichko e nared
            if (double.TryParse(txtWeight.Text, out double weight))
            {
                if (weight <= 0)
                {
                    MessageBox.Show("Insert valid weight! ");
                    return;
                }
            }
            else {
                MessageBox.Show("Insert a valid number - with decimal point, in kilograms!");
                return;
            }

            //proverka za distanciqta 
            if (double.TryParse(txtDistance.Text, out double distance))
            {
                if (distance <= 0)
                {
                    MessageBox.Show("Insert a valid distance, it cant be less than 0");
                    return;
                }
            }
            else {
                MessageBox.Show("Inser a valid number = with decimal point, in kilometers!");
            }

            //opredelqne na bazova cena po dostavka - radiobuttons

            double basePrice = 0.0;

            if (rButtonIconomic.Checked)
            {
                basePrice = 2;
            }
            else if (rBtnStandart.Checked)
            { basePrice = 3; }
            else if (rBtnExpress.Checked)
            {
                basePrice = 5;
            }
            else
            { MessageBox.Show("Chose a delivery type!");
                return;
            }

            //suzdavane na parcel
            int id = lBox.Items.Count + 1;
            Parcel parcel1 = new Parcel(id, FirstName, SecondName, weight, distance, basePrice, cBoxFragile.Checked, cBoxAdress.Checked);
           
            //dobavqne v list box
            lBox.Items.Add(parcel1);

            //izchislqvane na full sum i avg weight, cherz obhojdane na ListBox

            double totalSum = 0;
            double totalWeight = 0;

            foreach (Parcel parcel in lBox.Items)
            {
                totalSum += parcel.finalP;
                totalWeight += parcel.weight;

            }

            double avgWeight = totalWeight / lBox.Items.Count;

            lblFullSum.Text = "Full sum: " + totalSum.ToString("F2") + " euro";
            lblAvgW.Text = "Average weight: " + avgWeight.ToString("F2") + " kg";

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            //controls e bazov klas na vsichki, minavame prez vsichki kontrols v formata
            foreach (Control controls in this.Controls)
            {
                //izchistvame textboxs
                if (controls is TextBox)
                { controls.Text = ""; }

                //izchistvane radiobutton
                if (controls is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }

                //izchistvane na checkbox
                if (controls is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

        }
    }

    //class za da mojem da zapazvame informaciq za poveche ot 1 pratka
    class Parcel
    {   public int ID { get; set; }
        public string FN { get; set; }
        public string SN{ get; set; }
        public double weight { get; set; }
        public double distance { get; set; }
        public double finalP { get; set; }

        //konstruktor koito suzdava obekta i izchislqva cenata na pratkata chrez funkciq za tova

        public Parcel(int ID, string FN, string SN, double weight, double distance, double priceDelivery, bool fragile, bool adress)
        {
            this.FN = FN;
            this.SN = SN;
            this.weight = weight;
            this.distance = distance;
            this.ID = ID;

            this.finalP = CalcualtePrice(priceDelivery, weight, distance, fragile, adress);

        }

        public static double CalcualtePrice(double priceDelivery, double weight, double distance, bool fragile,bool adress)
        {
            double price = priceDelivery + (distance * 0.05) + (weight * 1.20);

            if (fragile)
            {
                price += (30 / 100) * price;
            }

            if (adress)
            {
                price += 2.50;
            }
            return price;
        }

        //za vizualizaciq v ListBox

        public override string ToString()
        {
            return ID + " " + FN + " " + SN + "\n Weight: " + weight + " kg. Price: " +
                finalP.ToString("F2") + " euro.";
        }
    }
}
