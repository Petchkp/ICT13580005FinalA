using System;
using System.Collections.Generic;
using ICT13580005FinalA.Models;
using Xamarin.Forms;

namespace ICT13580005FinalA
{
    public partial class EmployeeNewPage : ContentPage
    {
        Employee employee;

        public EmployeeNewPage(Employee employee=null)
        {
            InitializeComponent();

            this.employee = employee;

            titleLabel.Text = employee == null ? "เพิ่มพนักงานใหม่" : "แก้ไขข้อมูลพนักงาน";

            saveButtun.Clicked += SaveButtun_Clicked;
            cancelButtun.Clicked += CancelButtun_Clicked;

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            depaetmentPicker.Items.Add("บุคคล");
            depaetmentPicker.Items.Add("การเงิน");
            depaetmentPicker.Items.Add("พัสดุ");

            cSlider.ValueChanged += CSlider_ValueChanged;
            sSlider.ValueChanged += SSlider_ValueChanged;

            if(employee != null)
            {
                nameEntry.Text = employee.Name;
                lastnameEntry.Text = employee.Lastname;



            }
        }

        async void SaveButtun_Clicked(object sender, EventArgs e)
        {
            var isOK = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");
            if(isOK)
            {
                if(employee == null)
                {
                    employee = new Employee();
                    employee.Name = nameEntry.Text;
                    employee.Lastname = lastnameEntry.Text;
                    employee.Age = ageEntry.Text;
                }
            }
        }

        void CancelButtun_Clicked(object sender, EventArgs e)
        {

        }

        void CSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabelc.Text = value.ToString();
        }

        void SSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabels.Text = value.ToString();
        }
    }
}
