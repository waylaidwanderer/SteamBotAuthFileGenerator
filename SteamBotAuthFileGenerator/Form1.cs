using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SteamAuth;
using SteamBotAuthFileGenerator.Properties;

namespace SteamBotAuthFileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            var username = textBox_account_name.Text.Trim();
            var password = textBox_password.Text.Trim();
            var sharedSecret = textBox_shared_secret.Text.Trim();
            var identitySecret = textBox_identity_secret.Text.Trim();
            button_generate.Enabled = false;
            button_generate.Text = Resources.Form1_button_generate_Click_Generating___;

            new Thread(() =>
            {
                var authFile = Path.Combine("authfiles", string.Format("{0}.auth", username));
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "authfiles"));
                var steamGuardAccount = new SteamGuardAccount
                {
                    SharedSecret = sharedSecret,
                    IdentitySecret = identitySecret
                };
                var login = new UserLogin(username, password);                
                var loginResult = login.DoLogin();
                if (loginResult == LoginResult.Need2FA)
                {
                    for (var i = 0; i < 3; i++)
                    {
                        TimeAligner.AlignTime();
                        login.TwoFactorCode = steamGuardAccount.GenerateSteamGuardCode();
                        loginResult = login.DoLogin();
                        if (loginResult == LoginResult.LoginOkay) break;
                    }
                    if (loginResult == LoginResult.LoginOkay)
                    {
                        steamGuardAccount.DeviceID = AuthenticatorLinker.GenerateDeviceID();
                        steamGuardAccount.Session = login.Session;
                        File.WriteAllText(authFile, Newtonsoft.Json.JsonConvert.SerializeObject(steamGuardAccount));
                        MessageBox.Show(Resources.Form1_button_generate_Click_Successfully_generated_your_auth_file_, Resources.Form1_button_generate_Click_Success);
                        ResetGenerateButton();
                    }
                    else
                    {
                        MessageBox.Show(Resources.Form1_button_generate_Click_Error_logging_in__ + loginResult, Resources.Form1_button_generate_Click_Error);
                        ResetGenerateButton();
                    }
                }
                else
                {
                    MessageBox.Show(Resources.Form1_button_generate_Click_This_account_does_not_appear_to_have_2FA_enabled__Login_result__ + loginResult, Resources.Form1_button_generate_Click_Error);
                    ResetGenerateButton();
                }
            }).Start();                    
        }

        private void ResetGenerateButton()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate {
                    button_generate.Enabled = true;
                    button_generate.Text = Resources.Form1_ResetGenerateButton_Generate;
                });
            }
            else
            {
                button_generate.Enabled = true;
                button_generate.Text = Resources.Form1_ResetGenerateButton_Generate;
            }      
        }
    }
}
