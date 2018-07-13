using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormSample
{
    public partial class DynamicControlForm : Form
    {
        IEnumerable<Button> buttonsOnForm = new Button[]
        {
            new Button { Text = "FRM_A", Width = 50, Height = 50, Location = new Point(0, 0), },
            new Button { Text = "FRM_B", Width = 50, Height = 50, Location = new Point(0, 50), },
            new Button { Text = "FRM_C", Width = 50, Height = 50, Location = new Point(0, 100), },
            new Button { Text = "FRM_D", Width = 50, Height = 50, Location = new Point(0, 150), },
        };

        IEnumerable<Button> buttonsForTableLayoutPanel = new Button[]
        {
            new Button { Text = "TLP_A", Width = 50, Height = 50, Location = new Point(0, 0), },
            new Button { Text = "TLP_B", Width = 50, Height = 50, Location = new Point(0, 50), },
            new Button { Text = "TLP_C", Width = 50, Height = 50, Location = new Point(0, 100), },
            new Button { Text = "TLP_D", Width = 50, Height = 50, Location = new Point(0, 150), },
        };

        public DynamicControlForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            Width = 450;
            Height = 250;
            Text = "Dynamic Control Event Sample";

            buttonsOnForm.ToList().ForEach(x => 
            {
                x.Click += DynamicButtonClicked;
                Controls.Add(x);
            });

            buttonsForTableLayoutPanel.ToList().ForEach(x => 
            {
                x.Click += DynamicButtonClicked;
                tableLayoutPanel.Controls.Add(x);
            });
        }

        private void DynamicButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine($"{sender.ToString()}");
        }
    }
}
