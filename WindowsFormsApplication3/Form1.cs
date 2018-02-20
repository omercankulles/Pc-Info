using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Management;
using System.Management.Instrumentation;

namespace WindowsFormsApplication3
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

       
            
        

        public string GetIP()
        {
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostByName(host);
            return ip.AddressList[0].ToString();
        }
        string neme = SystemInformation.UserName.ToString();//Bilgisayrımızda Tanımladığımız İliskili KullanıcıAdı.
        string biosname = SystemInformation.ComputerName.ToString();//Bios ta geçen bilgisayar adını alır.

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            label1.Text = GetIP();
            label2.Text = neme.ToString();
            label3.Text = biosname.ToString();
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            key.SetValue("C:\\bycan.exe", Application.ExecutablePath.ToString());
            

            //Burada Ekranın Sağ Alt Köşesini Ayarladım Ve Son Satırda Taskbarda Görünmesini Sağladım Böylece Görev Çubuğunda Görünmüyor Tool.
            var X = Screen.GetWorkingArea(this).Width;
            var Y = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(X - this.Width, Y - this.Height);
            



            ManagementObject cs = new ManagementObject("Win32_ComputerSystem='" + System.Environment.MachineName + "'"); // management referanslara ekledim öyle çalıştı
            label8.Text = cs["Domain"].ToString();

            
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
                
                
                
            }
        }

        

       

        }

    

