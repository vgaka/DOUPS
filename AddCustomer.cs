using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace Cshrp_doups
{
#pragma warning disable IDE1006
    public partial class AddCustomer : Form
    {
        
         IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "SrqpM36ABvqs0rBJRj5S6R4ATa4tzYdTPN0EEcgR",
            BasePath = "https://do-ups.firebaseio.com/",
            //RequestTimeout=300
        };
        IFirebaseClient client;
        
        public string custpreflang { get; set; }

        public AddCustomer()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            
            //ทำการค้นหาตรงนี้
            var customer = new Customer
            {
                custid = txt_Id.Text,
                customeraccount = txt_Acc.Text,
                customername = txt_Name.Text,
                custpreflang = ""
            };
            if (radioButton1.Checked == true) {
                customer.custpreflang = "TH";
            } else
            {
                customer.custpreflang = "EN";
            }
            
            //int lstcounterget;
            // get last customer counter
            FirebaseResponse resp = await client.GetAsync("counter/");
            Counter_class counter = resp.ResultAs<Counter_class>();
            counter.customers++;
            // save new customer value
            SetResponse response = await client.SetAsync("customer/" + customer.custid.ToString(), customer);

            //lstcounterget = Convert.ToInt32(counter.customers);
            //lstcounterget++;
            
            SetResponse response1 = await client.SetAsync("counter/customers" , counter.customers);

            //SetResponse counter_resp = await client.SetAsync("counter/customers/"+ lstcounterget);
            clearvalue();
            MessageBox.Show("New Customer was added");
        }
        void clearvalue()
        {
            txt_Acc.Text = "";
            txt_Id.Text = "";
            txt_Name.Text = "";
        
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                //MessageBox.Show("connected");
            }
            else
            {
                MessageBox.Show("cannot connect");
            }
        }

       
    }
#pragma warning restore IDE1006
}
