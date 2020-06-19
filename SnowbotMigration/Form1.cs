using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SnowbotMigration
{

    public partial class MainForm : Form
    {
        private const string _SB_DATA_FOLDER_NAME = @"\SwiftBot\Snowbot.exe_Url_vzscjvkefgnq2re4m5lqlagg2h2cjb4r\1.0.0.0";
        private XmlDocument _sbData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txt_sbDataFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _SB_DATA_FOLDER_NAME;
        }

        private void btn_generateList_Click(object sender, EventArgs e)
        {

            rich_exportedData.Clear();

            _sbData = new XmlDocument();
            _sbData.Load(txt_sbDataFolderPath.Text + @"\user.config");
            string unparsedData = _sbData.DocumentElement.SelectSingleNode("/configuration/userSettings/SwiftBot.My.MySettings/setting[@name='account']").InnerText;

            string[] accountsData = unparsedData.Split(';');

            foreach(string data in accountsData)
            {
                string[] accountsDataDeep = data.Split('|');

                if (accountsDataDeep.Count() >= 2)
                {
                    rich_exportedData.AppendText($"{accountsDataDeep[0]}:{accountsDataDeep[1]}");
                    if (accountsDataDeep[2] != "") rich_exportedData.AppendText($"|{accountsDataDeep[2]}");
                    rich_exportedData.AppendText(Environment.NewLine);
                }         
            }
        }
    }
}
