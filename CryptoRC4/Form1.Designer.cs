/****************************************
          SAKARYA ÜNİVERSİTESİ
   BİLGİSAYAR ve BİLİŞİ BİLİMLERİ FAKÜLTESİ
          KRIPTOLOJİYE GİRİŞİ
              RC4 CİPHER
         ABDULRAHMAN ALSAMARAIE
             OĞUZHAN BOLAT
****************************************/
using System.Drawing;
using System.Windows.Forms;

namespace CryptoRC4
{
    public partial class Form1 : Form
    {

        
        private System.ComponentModel.IContainer components = null;
        private AutoScaleMode AutoScaleMode;
        private Size ClientSize;
        private string Text;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}

