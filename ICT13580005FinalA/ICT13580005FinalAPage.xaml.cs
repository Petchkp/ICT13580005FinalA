using System;
using System.Collections.Generic;
using ICT13580005FinalA.Models;
using Xamarin.Forms;

namespace ICT13580005FinalA
{
    public partial class ICT13580005FinalAPage : ContentPage
    {
        public ICT13580005FinalAPage()

        {
            InitializeComponent();

            newButton.Clicked += NewButton_Clicked;
        }
        protected override void OnAppearing()
        {
            LoadData();
        }
        void LoadData()
        {
            employeeListview.ItemsSource = App.DbHelper.GetEmployee();
        }
        void NewButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new EmployeeNewPage());
        }

        void Edit_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as MenuItem;
            var employee = button.CommandParameter as Employee;
            Navigation.PushModalAsync(new EmployeeNewPage(employee));
        }

        async void Delect_Clicked(object sender, System.EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการลบใช่หรือไม่", "ใช่", "ไม่ใช่");

            if (isOk)
            {
                var button = sender as MenuItem;
                var employee = button.CommandParameter as Employee;
                App.DbHelper.DeleteEmployee(employee);

                await DisplayAlert("ลบสำเร็จ", "ลบข้อมูลสินค้าเรียบร้อย", "ตกลง");
                LoadData();
            }
        }
    }
}
