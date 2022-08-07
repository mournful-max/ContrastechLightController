using System;
using System.Windows.Forms;

using ContrastechLightController.Classes;

namespace ContrastechLightController
{
    public partial class ViewFrm : Form
    {
        private VT_LT4_24150PWDC_4 _LightController;

        public ViewFrm()
        {
            InitializeComponent();
        }

        private void btnOpenConn_Click(object sender, EventArgs e)
        {
            try
            {
                _LightController.OpenConnection(txtComPortName.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            try
            {
                _LightController.CloseConnection();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetBrightness_Click(object sender, EventArgs e)
        {
            try
            {
                _LightController.SetBrightness(VT_LT4_24150PWDC_4.ConvertByteToChannelWord(Convert.ToByte(nudChannel.Value)), Convert.ToByte(nudBrightness.Value));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewFrm_Load(object sender, EventArgs e)
        {
            _LightController = new VT_LT4_24150PWDC_4();
        }
    }
}
