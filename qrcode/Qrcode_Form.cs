using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Forms;

using QRCoder;

namespace qrcode {
    public partial class Qrcode_Form : Form {
        public QRCodeGenerator qrGenerator = new QRCodeGenerator();
        public Bitmap qrCodeImage = null;

        private int qrCodeCounter = 1;

        public Qrcode_Form () {
            InitializeComponent ();
        }

        private void Qrcode_Form_Load (object sender, EventArgs e) {

        }

        private void generateqrcode_button_Click (object sender, EventArgs e) {
            string data = qrcodetext_textbox.Text.Trim();

            if (string.IsNullOrEmpty (data)) {
                System.Windows.MessageBox.Show ("Please Enter Something in the Textbox.", "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
                return;
            }
            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrData);
            qrCodeImage = qrCode.GetGraphic (10);

            qrcode_picturebox.Image = qrCodeImage;
            qrcode_picturebox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void saveqrcode_button_Click (object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Save QR Code";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Filter = "PNG (*.png)|*.png|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog () == DialogResult.OK) {
                qrCodeImage.Save (saveFileDialog.FileName);
            }

            qrCodeCounter++;
        }

        private void reset_button_Click (object sender, EventArgs e) {
            qrcodetext_textbox.Text = "";
            qrcode_picturebox.Image = null;
        }
    }
}
