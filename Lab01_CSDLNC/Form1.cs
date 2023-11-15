using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab01_CSDLNC
{
    public partial class Form1 : Form
    {
        IObjectContainer db = Manager.Database;
        public Form1()
        {
            //db.Store(new Pilot("Tuan", 3000));
            //db.Store(new Pilot("Huy", 2900));
            //db.Store(new Pilot("Thinh", 2500));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UploadForm();  
        }

        private void button_DeleteAll_Click(object sender, EventArgs e)
        {
   
            List<Pilot> query = db.Query<Pilot>().Where(u => u.Points < 4000).ToList<Pilot>();
            if (query.Count != 0)
            {
                Pilot a = query[0];
                db.Delete(a);
                db.Commit();
                UploadForm();
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            int point = Int32.Parse(textBox_Point.Text);
            if(name.Length > 0 && point > 0) {
                db.Store(new Pilot(name, point));
                UploadForm();
            }
        }

        private void UploadForm()
        {
            List<Pilot> query = db.Query<Pilot>().ToList<Pilot>();
            if (query.Count != 0)
            {
                List<Pilot> Pilots = query.ToList();
                dataGridView_Pilot.DataSource = Pilots;
            }
        }


    }
}
