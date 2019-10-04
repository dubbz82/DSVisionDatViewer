using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace DSVisionDatViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.RestoreDirectory = true;
            d.Title = "DS Vision PCPROPERTY.DAT";
            d.Multiselect = false;
            d.Filter = "DS Vision Metadata File|PCPROPERTY.DAT";
            DialogResult r = d.ShowDialog();
            if (r == DialogResult.OK)
            {
                XmlDataDocument xmlDoc = new XmlDataDocument();
                
                int i = 0;
                FileStream fs = new FileStream(d.FileName, FileMode.Open);
                xmlDoc.Load(fs);
                writeXML(lblID, "id", xmlDoc);
                writeXML(lblGenre, "name", xmlDoc);
                writeXML(lblMediaType, "mediaType", xmlDoc);
                writeXML(lblTitle, "title", xmlDoc);
                
                writeXMLText(txtDescription, "description", xmlDoc);
                writeXML(lblNavigationText, "navigationText", xmlDoc);
                writeXML(lblNavigationURL, "navigationURL", xmlDoc);
                writeXML(lblManualText, "manualText", xmlDoc);
                writeXML(lblManualURL, "manualURL", xmlDoc);
                writePicture(pbBannerImage, "bannerImage", xmlDoc);
                writePicture(pbPropertyImage, "propertyImage", xmlDoc);
                grpInfo.Visible = true;
                grpImageInformation.Visible = true;
                
            }
        }

       private void writeXML(Label inlabel, string tagName, XmlDataDocument xmlDoc)
        {
            XmlNodeList nodeList;
            nodeList = xmlDoc.GetElementsByTagName(tagName);
            inlabel.Text = nodeList[0].ChildNodes.Item(0).InnerText;
        }

        private void writeXMLText(TextBox inText, string tagName, XmlDataDocument xmlDoc)
        {
            XmlNodeList nodeList;
            nodeList = xmlDoc.GetElementsByTagName(tagName);
            inText.Text = nodeList[0].ChildNodes.Item(0).InnerText;
        }

        private void writePicture(PictureBox b, string tagName, XmlDataDocument xmlDoc)
        {
            XmlNodeList nodeList;
            nodeList = xmlDoc.GetElementsByTagName("bannerImage");
            byte[] bytes = Convert.FromBase64String(nodeList[0].ChildNodes.Item(0).InnerText);
            Image img;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                img = Image.FromStream(ms);
            }
            b.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpInfo.Visible = false;
            grpImageInformation.Visible = false;
        }

        private void lblNavigationURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lblNavigationURL.Text);
        }

        private void lblManualURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lblManualURL.Text);
        }

        private void pbBannerImage_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pbPropertyImage_Click(object sender, EventArgs e)
        {

        }

        private void pbPropertyImage_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
