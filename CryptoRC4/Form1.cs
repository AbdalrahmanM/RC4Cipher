/****************************************
          SAKARYA ÜNİVERSİTESİ
   BİLGİSAYAR ve BİLİŞİ BİLİMLERİ FAKÜLTESİ
          KRIPTOLOJİYE GİRİŞİ
              RC4 CİPHER
         ABDULRAHMAN ALSAMARAIE
             OĞUZHAN BOLAT
****************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CryptoRC4
{

	public class frmFrontEnd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button cmdEncrypt;
		private System.Windows.Forms.Button cmdDecrypt;
		private System.Windows.Forms.Label lblInputBox;
		private System.Windows.Forms.Label lblOutputBox;
		private System.Windows.Forms.Label lblKey;
		private System.Windows.Forms.TextBox txtEncryption;

		private System.ComponentModel.Container components = null;

		public frmFrontEnd()
		{
			// Required for Windows Form Designer support
			InitializeComponent();

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.lblInputBox = new System.Windows.Forms.Label();
            this.lblOutputBox = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtEncryption = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(8, 64);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(216, 160);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(368, 64);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(216, 160);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmdEncrypt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncrypt.Location = new System.Drawing.Point(232, 87);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(128, 32);
            this.cmdEncrypt.TabIndex = 2;
            this.cmdEncrypt.Text = "   EnCrypt ";
            this.cmdEncrypt.UseVisualStyleBackColor = false;
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmdDecrypt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecrypt.Location = new System.Drawing.Point(232, 156);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(128, 32);
            this.cmdDecrypt.TabIndex = 3;
            this.cmdDecrypt.Text = " DeCrypt ";
            this.cmdDecrypt.UseVisualStyleBackColor = false;
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // lblInputBox
            // 
            this.lblInputBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputBox.Location = new System.Drawing.Point(5, 28);
            this.lblInputBox.Name = "lblInputBox";
            this.lblInputBox.Size = new System.Drawing.Size(216, 24);
            this.lblInputBox.TabIndex = 4;
            this.lblInputBox.Text = "In Clear Text Box";
            this.lblInputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputBox
            // 
            this.lblOutputBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputBox.Location = new System.Drawing.Point(365, 28);
            this.lblOutputBox.Name = "lblOutputBox";
            this.lblOutputBox.Size = new System.Drawing.Size(216, 24);
            this.lblOutputBox.TabIndex = 5;
            this.lblOutputBox.Text = "Crypted Text Box";
            this.lblOutputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKey
            // 
            this.lblKey.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(12, 237);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(136, 24);
            this.lblKey.TabIndex = 6;
            this.lblKey.Text = "Encryption Key :";
            // 
            // txtEncryption
            // 
            this.txtEncryption.Location = new System.Drawing.Point(8, 264);
            this.txtEncryption.Name = "txtEncryption";
            this.txtEncryption.Size = new System.Drawing.Size(337, 20);
            this.txtEncryption.TabIndex = 7;
            this.txtEncryption.LostFocus += new System.EventHandler(this.txtEncryption_LostFocus);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(493, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(399, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "RESTART";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmFrontEnd
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(600, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEncryption);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblOutputBox);
            this.Controls.Add(this.lblInputBox);
            this.Controls.Add(this.cmdDecrypt);
            this.Controls.Add(this.cmdEncrypt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "frmFrontEnd";
            this.Text = "RC4 Cipher";
            this.Load += new System.EventHandler(this.frmFrontEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// The main entry point for the application.
		
		#region User control functions

		private void frmFrontEnd_Load(object sender, System.EventArgs e)
		{
			this.cmdDecrypt.Visible = false;
			this.cmdEncrypt.Visible = false;
		}

		private void txtEncryption_LostFocus(object sender, System.EventArgs e)
		{
			// check if key is null
			if (this.txtEncryption.Text.ToString() == "")
			{
				// key is null - display error message
				MessageBox.Show("The Encryption key must not be NULL!", "Error");
			}
		}


		private void txtInput_TextChanged(object sender, System.EventArgs e)
		{
			// Check if entered input text is not null
			if (this.txtInput.Text.ToString() != "")
			{
				// Enable Encrypt command button if it is not enabled yet
				if (!this.cmdEncrypt.Visible)
				{
					this.cmdEncrypt.Visible = true;
				}
			}
			else
			{
				// Disable Encrypt command button it is not disabled yet
				if (this.cmdEncrypt.Visible)
				{
					this.cmdEncrypt.Visible = false;
				}
			}
		}

		private void txtOutput_TextChanged(object sender, System.EventArgs e)
		{
			// Check if entered input text is not null
			if (this.txtOutput.Text.ToString() != "")
			{
				// Enable Encryp command button if it is not enabled yet
				if (!this.cmdDecrypt.Visible)
				{
					this.cmdDecrypt.Visible = true;
				}

				this.m_sCrypSave = this.txtOutput.Text;
			}
			else
			{
				// Disable dencryp command button if it is not disabled yet
				if (this.cmdDecrypt.Visible)
				{
					this.cmdDecrypt.Visible = false;
				}
			}
		}

		private void cmdEncrypt_Click(object sender, System.EventArgs e)
		{
			
			// Call Engine
			RC4Cipher myRC4Engine = new RC4Cipher();
			myRC4Engine.EncryptionKey = this.txtEncryption.Text;
			myRC4Engine.InClearText = this.txtInput.Text;
			myRC4Engine.Encrypt();
			// Save also to string the result because some char could be lost into textbox
			this.m_sCrypSave = myRC4Engine.CryptedText;
			this.txtOutput.Text = this.m_sCrypSave;
		}

		private void cmdDecrypt_Click(object sender, System.EventArgs e)
		{
			
			// Call Engine
			RC4Cipher myRC4Engine = new RC4Cipher();
			myRC4Engine.EncryptionKey = this.txtEncryption.Text;
			myRC4Engine.CryptedText = this.m_sCrypSave;
			myRC4Engine.Decrypt();
			this.txtInput.Text = myRC4Engine.InClearText;
		}
		#endregion

		#region User Private Field
		// Used to store Crypted Text
		private string m_sCrypSave = "";
        #endregion

        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
			string message = "Do you want to close the application?";
			string title = "Close Application";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
			if(result==DialogResult.Yes)
            {
				Application.Exit();
			}
            
        }

        private Button button2;

        private void button2_Click(object sender, EventArgs e)
        {
			this.txtInput.Text = "";
			this.txtOutput.Text = "";
			this.txtEncryption.Text = "";
		}

        private Button button3;

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to restart the application?";
            string title = "Restart Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            
        }
    }
}
