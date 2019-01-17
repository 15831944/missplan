using System;
using System.Threading;
using System.Windows.Forms;



namespace MissionPlanner
{
    public partial class ConnectOrNo: Form
    {
        
        public bool state = false;
        public ConnectOrNo()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            state = true;
            this.Close();
            //Application.Run(new MainV2());
            
        }
        
    }
}
