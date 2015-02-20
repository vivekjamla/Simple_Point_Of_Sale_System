using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Xml;


/// <summary>
/// This Project can be Implemented way more. I could implement certain design patterns too but due to some time constrains and School work 
/// I did not got that much of time. i did not have any experience with .NET C# But now i can add one more technology to my resume.
/// Thank you for the opportunity.
/// </summary>

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        private BindingList<List<string>> vivek = new BindingList<List<string>>();
        private BindingList<double> priceList = new BindingList<double>();
        private List<string> items = new List<string>();
        private List<double> itemsprice = new List<double>();
        public Form1()
        {
            InitializeComponent();
           /// TestEncoding();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// On click event of AddtoOrder Button which allows to add custom item to order with Validation
        /// </summary>
        private void onclick(object sender, EventArgs e)
        {
            double result;
            if(!string.IsNullOrWhiteSpace(textBox1.Text))        ///Check for null or empty white space
            {
               if(double.TryParse(textBox3.Text,out result))      ///Price should be in valid decimal format.
               {
                   string desc = textBox1.Text;
                   items.Add(desc);
                   string pricee = textBox3.Text;
                   double price = double.Parse(pricee);
                   itemsprice.Add(price);
                   priceList.Add(price);
                   listBox1.Items.Add(textBox1.Text.PadRight(25)+price.ToString());
                   
               }
               else
               {
                   MessageBox.Show("Please enter Price");
               }
                
            }
            else
            {
                MessageBox.Show("Please enter Description");
            }
            double total = countTotal();
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
        /// <summary>
        /// On click event of chips Button.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            int chips_price = 2;
            priceList.Add(chips_price);
            itemsprice.Add(chips_price);
            items.Add(btnChips.Text);
            string temp = btnChips.Text.PadRight(25);
            string final = temp + chips_price.ToString();
            listBox1.Items.Add(final);
            double total = countTotal();

        }
        /// <summary>
        /// On click event of Coke Button.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            int coke_price = 3;
            priceList.Add(coke_price);
            itemsprice.Add(coke_price);
            items.Add(btnCoke.Text);
            string temp = btnCoke.Text.PadRight(25);
            string final = temp + coke_price.ToString();
            listBox1.Items.Add(final);
            double total = countTotal();
           
        }
        /// <summary>
        /// Simple method Counting Total and Tax.
        /// </summary>
        private double countTotal()
        {
            double k = 0;
            for (int i = 0; i < priceList.Count; i++)
            {

                k = k + priceList[i];
            }
            double tax = (6.5 * k) / 100;
            double SubTotal = k + tax;
            Taxbox.Text = string.Join("", tax.ToString());
            textBox2.Text = string.Join(" ", SubTotal.ToString());
            return k;
        }
        /// <summary>
        /// on click event of submit button which generates the XML file,
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("product.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("order");
            writer.WriteStartElement("AssociateId");
            writer.WriteString("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");
            writer.WriteEndElement();
            writer.WriteStartElement("Subtotal");
            writer.WriteString("715");
            writer.WriteEndElement();
            writer.WriteStartElement("taxrate");
            writer.WriteString("6.5%");
            writer.WriteEndElement();
            writer.WriteStartElement("Total");
            writer.WriteString("761");
            writer.WriteEndElement();
            writer.WriteStartElement("OrderNumber");
            writer.WriteString("1200");
            writer.WriteEndElement();
            writer.WriteStartElement("OrderItems");

            for (int i = 0; i < items.Count; i++)
            {
                createNode(i.ToString(), items[i], itemsprice[i].ToString(), writer);
                
            }
           
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            ///MessageBox.Show("XML File created ! "); ///for debug 
            XmlDocument document = new XmlDocument();
            document.Load("product.xml");
            string xmlcontent = document.OuterXml;            ///Get XML content as String
            ///MessageBox.Show(xmlcontent);
            TestEncoding(xmlcontent);                           ///Convert String and Encode as UTF8 and send over HTTP
        }

        /// <summary>
        /// Method which creates nodes for Every OrderItem.If needed more description like togo we can add it here.
        /// </summary>
        private void createNode(string SequenceNumber1, string Description1, string pPrice1, XmlTextWriter writer)
        {
            writer.WriteStartElement("OrderItem");
            writer.WriteStartElement("SequenceNumber");
            writer.WriteString(SequenceNumber1);
            writer.WriteEndElement();
            writer.WriteStartElement("Description");
            writer.WriteString(Description1);
            writer.WriteEndElement();
            writer.WriteStartElement("Price");
            writer.WriteString(pPrice1);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
        /// <summary>
        /// Simple method for encoding and making request for HTTP Post        /// </summary>
        void TestEncoding(string xmlcontents)
        {
            
            byte[] testdataBytes = Encoding.UTF8.GetBytes(xmlcontents);  ///Changed to UTF8 from ASCII 
            TMG.Web.WebHelper Sendobj = new TMG.Web.WebHelper();
            string endpoint1="http";
            Sendobj.SendPostRequest(endpoint1, testdataBytes);
            Debug.WriteLine(Utils.HexDump(testdataBytes));
            string convertedBytes = Encoding.UTF8.GetString(testdataBytes);    ///Changed to UTF8 from ASCII 
            Debug.WriteLine(convertedBytes);
        }

        

    }
}
