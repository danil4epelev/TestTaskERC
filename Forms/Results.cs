using System;
using System.Windows.Forms;
using TestTaskERC.Models;

namespace TestTaskERC.Forms
{
    public partial class Results : Form
    {
        ResultsMonth model;
        public Results(ResultsMonth results)
        {
            model = results;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Results_Load(object sender, EventArgs e)
        {
            label_V_HotWater.Text = model.Vol_HotWaterSupply.ToString() + label_V_HotWater.Text;
            label_Heating_Water.Text = model.Vol_HotWaterHeigh.ToString() + label_Heating_Water.Text;
            label_Sum_HotWater.Text = model.Sum_HotWaterSupply.ToString();
            label_SumHeating_Water.Text = model.Sum_HotWaterHeigh.ToString();
            label_V_ColdWater.Text = model.Vol_ColdWater.ToString() + label_V_ColdWater.Text;
            label_Sum_ColdWater.Text = model.Sum_ColdWater.ToString();
            if(model.Vol_Electricity != 0)
            {
                label_ElectNight.Visible = false;
                label_V_ElectNight.Visible = false;
                label_Sum_ElectNight.Visible = false;

                label_V_Elect.Text = model.Vol_Electricity.ToString() + label_V_Elect.Text;
                label_Sum_Elect.Text = model.Sum_Electricity.ToString();
            }

            else
            {
                label_Elect.Text = "Электроэнергия день";

                label_V_Elect.Text = model.Vol_ElectricityDay.ToString() + label_V_Elect.Text;
                label_V_ElectNight.Text = model.Vol_ElectricityNight.ToString() + label_V_ElectNight.Text;
                label_Sum_Elect.Text = model.Sum_ElectricityDay.ToString();
                label_Sum_ElectNight.Text = model.Sum_ElectricityNight.ToString();
            }

            double sum = 0;

            foreach (Control item in Controls)
            {
                if(((Control)item).Tag == "num") sum += Double.Parse(((Control)item).Text);
            }
            label_result.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
