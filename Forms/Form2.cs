using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTaskERC.Forms;
using TestTaskERC.Models;

namespace TestTaskERC
{
    public partial class Form2 : Form
    {
        private User model;

        private List<BackgroundInformation> list;

        public Form2(User value)
        {
            InitializeComponent();
            model = value;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_IdUSer.Text = label_IdUSer.Text + model.Id.ToString();
            foreach(Control item in Controls)
            {
                bool flag = false;

                if(item.Tag == "Hide")
                {
                    if(item is TextBox)
                    {
                        switch (item.Name.ToString())
                        {
                            case "tb_HotWater":
                                item.Text = model.HotWater.ToString();
                                flag = CheckIndicator(check_HotWater, model.HotWater);
                                break;
                            case "tb_ColdWater":
                                item.Text = model.ColdWater.ToString();
                                flag = CheckIndicator(check_ColdWater, model.ColdWater);
                                break;
                            case "tb_Elect":
                                item.Text = model.ElectricityDay.ToString();
                                flag = CheckIndicator(check_Ecect, model.ElectricityDay);
                                break;
                            case "tb_ElectNight":
                                item.Text = model.ElectricityNight.ToString();
                                flag = CheckIndicator(check_Ecect, model.ElectricityNight);
                                break;
                            default:
                                break;
                        }
                    }
                    if (!flag)
                    {
                        item.Visible = false;
                    }
                    
                }
            }

            if(check_Ecect.Checked)
            {
                label_Day.Visible = true;
                label_Night.Visible = true;
            }
        }
        //метод проверки данных, уже занесённых в базу. Всё, что уже есть в базе автоматически будет засчитываться как "имеется прибор учёта"
        private bool CheckIndicator(CheckBox box, double value) 
        {
            if(value > 0f)
            {
                box.Checked = true;
                box.AutoCheck = false;
                return true;
            }
            return false;
        }

        private void check_HotWater_CheckedChanged(object sender, EventArgs e)
        {
            tb_HotWater.Visible = ((CheckBox)sender).Checked;
        }

        private void check_ColdWater_CheckedChanged(object sender, EventArgs e)
        {
            tb_ColdWater.Visible = ((CheckBox)sender).Checked;
        }

        private void check_Ecect_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = ((CheckBox)sender).Checked;
            tb_Elect.Visible = flag;
            tb_ElectNight.Visible = flag;
            label_Day.Visible = flag;
            label_Night.Visible = flag;
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(number == 44)
            {
                foreach(var item in ((TextBox)sender).Text.ToString())
                {
                    if (item == 44)
                    {
                        e.Handled = true;
                        return;
                    }
                       
                }
            }
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void tb_CountPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }


        private void b_Calculate_Click(object sender, EventArgs e)
        {
            if (tb_CountPeople.Text == "")
            {
                MessageBox.Show("Вы не указали количество людей на жилплощади", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatabaseQuies.UpdateClient(
                model.Id,
                Double.Parse(tb_HotWater.Text),
                Double.Parse(tb_ColdWater.Text),
                Double.Parse(tb_Elect.Text),
                Double.Parse(tb_ElectNight.Text));

            list = DatabaseQuies.GetBackgroundInformation();

            ResultsMonth results = new ResultsMonth();

            double vol_ColdWater;
            double vol_HotWaterSupply;
            double vol_HotWaterHeigh;
            double sum_HotWaterSupply;
            double sum_HotWaterHeating;
            double vol_Elect;
            double vol_ElectDay;
            double vol_ElectNight;

            results.Sum_ColdWater = CalculateColdWater(out vol_ColdWater);

            CalculateHotWater(out vol_HotWaterSupply, out vol_HotWaterHeigh, out sum_HotWaterSupply, out sum_HotWaterHeating);

            if(check_Ecect.Checked)
            {
                results.Sum_ElectricityDay = CalculateElectricity( out vol_ElectDay, "ЭЭ день", tb_Elect, model.ElectricityDay);
                results.Sum_ElectricityNight = CalculateElectricity(out vol_ElectNight, "ЭЭ ночь", tb_ElectNight, model.ElectricityNight);

                results.Vol_ElectricityDay = vol_ElectDay;
                results.Vol_ElectricityNight = vol_ElectNight;
            }
            else
            {
                results.Sum_Electricity = CalculateElectricity(out vol_Elect);

                results.Vol_Electricity = vol_Elect;
            }

            results.Vol_ColdWater = vol_ColdWater;
            results.Vol_HotWaterSupply = vol_HotWaterSupply;
            results.Vol_HotWaterHeigh = vol_HotWaterHeigh;
            results.Sum_HotWaterSupply = sum_HotWaterSupply;
            results.Sum_HotWaterHeigh = sum_HotWaterHeating;

            Hide();
            Results form = new Results(results);
            form.Show();

        }

        private void CalculateHotWater(out double volume, out double volumeHeating, out double sumSupply, out double sumHeating)
        {
            var heating = list.First(x => x.Service == "ГВС Нагрев");
            var supply = list.First(y => y.Service == "ГВС Подача");

            double standartHeating = heating.Standart;

            
            if(check_HotWater.Checked)
            {
                volume = Double.Parse(tb_HotWater.Text) - model.HotWater;
            }
            else
            {
                double standartSupply = supply.Standart;

                volume = standartSupply * Int32.Parse(tb_CountPeople.Text);               
            }

            volumeHeating = volume * standartHeating;

            double rateHeating = heating.Rate;
            double rateSupply = supply.Rate;

            sumHeating = rateHeating * volumeHeating;
            sumSupply = rateSupply * volume;
        }

        private double CalculateColdWater(out double volume)
        {
            var coldWater = list.First(x => x.Service == "ХВС");

            if(check_ColdWater.Checked)
            {
                volume = Double.Parse(tb_ColdWater.Text) - model.ColdWater;
            }
            else
            {
                volume = coldWater.Standart * Int32.Parse(tb_CountPeople.Text);
            }

            return volume * coldWater.Rate;
        }

        private double CalculateElectricity(out double volume, string nameOfService, TextBox textBox, double previousValue)
        {
            var electricity = list.First(x => x.Service == nameOfService);

            volume = Double.Parse(textBox.Text) - previousValue;

            return volume * electricity.Rate;
        }

        private double CalculateElectricity(out double volume)
        {
            var electricity = list.First(x => x.Service == "ЭЭ");

            volume = electricity.Standart * Int32.Parse(tb_CountPeople.Text);

            return volume * electricity.Rate;
        }

        private void CheckNullValue(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        private void CheckValueTB(TextBox textBox, double value)
        {
            CheckNullValue(textBox);

            if (value > Double.Parse(textBox.Text))
            {
                textBox.Text = value.ToString();
            }
            
        }

        private void tb_HotWater_Leave(object sender, EventArgs e)
        {
            CheckValueTB((TextBox)sender, model.HotWater);            
        }

        private void tb_ColdWater_Leave(object sender, EventArgs e)
        {
            CheckValueTB((TextBox)sender, model.ColdWater);
        }

        private void tb_Elect_TextChanged(object sender, EventArgs e)
        {
            CheckValueTB((TextBox)sender, model.ElectricityDay);
        }

        private void tb_ElectNight_Leave(object sender, EventArgs e)
        {
            CheckValueTB((TextBox)sender, model.ElectricityNight);
        }
    }
}
