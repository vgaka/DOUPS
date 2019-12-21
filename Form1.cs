using System;
using System.Data;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Windows.Forms;


namespace Cshrp_doups
{
#pragma warning disable IDE1006
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "SrqpM36ABvqs0rBJRj5S6R4ATa4tzYdTPN0EEcgR",
            BasePath = "https://do-ups.firebaseio.com/",
            //RequestTimeout=300
        };
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btmsearch_Click(object sender, EventArgs e)
        {

            //ค้นหาข้อมูลทำตรงนี้
            /*
             *var customer = new Customer
             {
             custid = "",
             customeraccount = "",
             customername = "",
             custpreflang = ""
             };
             */
            dataGridView1.Rows.Clear();
            FirebaseResponse response = await client.GetAsync("customer/" + txtclientsearchkey.Text);
            Customer cust = response.ResultAs<Customer>();
            //debug.print command in vb = System.Diagnostics.Debug.WriteLine("Hello world");
            // or System.Console.WriteLine("Hello world"); 
            // and see result in output window debug section
            // System.Diagnostics.Debug.WriteLine(cust.customername.ToString());
            Console.WriteLine(this.comboBox1.Text);

            if (this.comboBox1.Text == "Customer ID")
            {
                Console.WriteLine(this.comboBox1.SelectedText.ToString());
            }
            else
            {
                Console.WriteLine(this.comboBox1.SelectedText.ToString());
            }
            if (cust != null)
            {
                Console.WriteLine(cust.custid.ToString());

                dataGridView1.Rows.Add(cust.custid, cust.customername, cust.customeraccount, cust.custpreflang);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            //this.Close();
            //Add shipment data here to open transaction window
            /* 1. เลือก Customer ID
             * 2. เลือกที่อยู่ ที่ต้องการออกใบกำกับภาษี
             * 3. เพิ่ม shipment เข้าไป
             * 4. เลือก chargetype = "DO"
             * 5. คำนวณ เงิน ตาม chargettype amount ที่กำหนด
             */

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            //txtclientsearchkey.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
        }

    

        private void btmaddnew_Click(object sender, EventArgs e)
        {
            Form newcust = new AddCustomer();
            newcust.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            FirebaseResponse ccust = await client.GetAsync("customer/");
            Customer allcus = ccust.ResultAs<Customer>();
            Customer allcust = ccust.ResultAs<Customer>();
            
            FirebaseResponse countercust = await client.GetAsync("counter/");
            Counter_class counter = countercust.ResultAs<Counter_class>();

            //Data allcust = respallcust.ResultAs<Data>();
            dataGridView1.Rows.Clear();
            int reccount = Convert.ToInt32(counter.customers.ToString());
            //MessageBox.Show(counter.customers.ToString());
            while (true)
            {
                if (i == reccount)
                {
                    break;
                }
                try
                {
                    i++;
                    dataGridView1.Rows.Add(i,allcust.custid,allcust.customername, allcust.customeraccount);
                    //dataGridView1.RowsAdded.cells[0].value = i;
                    //dataGridView1.Rows[i-1].Cells[0].Value = i; //allcust.custid;
                    //MessageBox.Show(i.ToString());
                    //allcust.customername, allcust.customeraccount, allcust.custpreflang);
                }
                catch
                {

                }
            }
        }

    }
#pragma warning restore IDE1006
}
