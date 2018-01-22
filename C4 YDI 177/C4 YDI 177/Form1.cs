using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4_YDI_177
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Day
        {   
            Sunday = 1, Monday, Tuesday, Wednesday, 
            Thursday, Friday, Saturday
               
        }
        private void btnGetSpecial_Click(object sender, EventArgs e)
        {
            
            int day = Convert.ToInt32(dayBox.Text);
            string special;
            switch((Day)day)
               {
                    case Day.Sunday:
                        special = "fried chicken";
                        break;
                    case Day.Monday:
                        special = "Sorry - closed";
                        break;
                    case Day.Tuesday:
                    case Day.Wednesday:
                    case Day.Thursday:
                        special = "meat loaf";
                        break;
                    case Day.Friday:
                        special = "fish day";
                        break;
                    case Day.Saturday:
                        special = "liver and onions";
                        break;
                    default:
                        special = "Invalid day";
                        break;
               }
               outputLabel.Text = "Today's special is " + special;
        }
    }
}

                
            
               
        
         
    
    

