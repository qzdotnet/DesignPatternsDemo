using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        public ISubject Subject;

        private void MainFrom_Load(object sender, EventArgs e)
        {
            Restaurant restaurantSubject = new Restaurant();
            restaurantSubject.Menus = @"糖醋排骨 50
                                        油焖大虾 20
                                        糖醋里脊 10
                                        土豆丝   15";
            this.txtMenu.Text = restaurantSubject.Menus;
            Subject = restaurantSubject;
            Customer customer = new Customer("客户小张", this.txtLog);
            Customer customer2 = new Customer("客户小李", this.txtLog);
            Buyer buyer = new Buyer("采购小王", this.txtLog);
            lbxObserver.Items.Add(customer);
            lbxObserver.Items.Add(customer2);
            lbxObserver.Items.Add(buyer);
            Subject.Attach(customer);
            Subject.Attach(customer2);
            Subject.Attach(buyer);

        }

       


        private void btnChangeMenus_Click(object sender, EventArgs e)
        {
            ((Restaurant)Subject).Menus = this.txtMenu.Text;
            Subject.Notify();
        }

        private void btnAddObserver_Click(object sender, EventArgs e)
        {
            if (this.cbxObserverType.Text == "客户")
            {
                IObserver observer = new Customer("客户" + this.txtName.Text, this.txtLog);
                lbxObserver.Items.Add(observer);
                Subject.Attach(observer);
            }
            else if (this.cbxObserverType.Text == "采购")
            {
                IObserver observer = new Buyer("采购" + this.txtName.Text, this.txtLog);
                lbxObserver.Items.Add(observer);
                Subject.Attach(observer);

            }
        }

        private void btnDelObserver_Click(object sender, EventArgs e)
        {
           IObserver item = lbxObserver.SelectedItem as IObserver;

            lbxObserver.Items.Remove(item);
            Subject.Detach(item);
        }
    }
}
