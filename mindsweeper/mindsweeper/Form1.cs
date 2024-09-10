using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindsweeper
{
    public partial class Form1 : Form
    {
        Button[] btnGrid=new Button[100];
        public Form1()
        {
            InitializeComponent();
            btnGrid[0] = button1;
            btnGrid[1] = button2;
            btnGrid[2] = button3;
            btnGrid[3] = button4;
            btnGrid[4] = button5;
            btnGrid[5] = button6;
            btnGrid[6] = button7;
            btnGrid[7] = button8;
            btnGrid[8] = button9;
            btnGrid[9] = button10;
            for (int i = 0; i < 10; i++)
            {
                btnGrid[i].BackColor= Color.Yellow;
            }
        }
    }
}
