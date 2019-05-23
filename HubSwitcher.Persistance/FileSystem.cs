using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Security;

namespace HubSwitcher.Persistance {
    public class FileSystem {

        private readonly static string _configPath = @"C:\Program Files (x86)\Bluepoint Solutions\RDC\IP Admin";
        private readonly static string _configFile = @"IP Admin.exe.config";
        private string _systemName;
        private string _URI;
        private string _UIN;
        private static string _exePath = System.IO.Path.Combine(_configPath, _configFile);
        Configuration _config = ConfigurationManager.OpenExeConfiguration(_exePath);

    }

    public class ConfigSettings {
        private Dictionary<string, string> _configSettings =
            new Dictionary<string, string>();
        private Encrypt _encObj = new Encrypt();

        public ConfigSettings() {
            foreach (var _setting in ConfigurationManager.AppSettings.AllKeys) {
                string _settingName = _setting.ToString();
                _configSettings.Add(
                    _settingName,
                    ConfigurationManager.AppSettings.Get(_settingName)
                );
            }
        }

        public string GetValue(string KeyName) {
            if (_configSettings.TryGetValue(KeyName, out string _value)) {
                if (_value.StartsWith("~") && _value.Length > 1) {
                    _value = _encObj.DecryptValue(_value);
                }
            } else {
                _value = "ERROR: Unable to find " + KeyName;
            }
            return _value;
        }

        public Dictionary<string, string> GetSettings() {
            return _configSettings;
        }
    }

 /*   
    public class {
        string _fileName = "";
        ExeConfigurationFileMap map;
        Configuration config;
        Encrypt encObj = new Encrypt();

        private void readButton_Click(object sender, EventArgs e) {
            try {
                map = new ExeConfigurationFileMap {
                    ExeConfigFilename = _fileName
                };
                config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
                resultLabel.Text = "Read file: " + _fileName;
            } catch (Exception ex) {
                outTextBox.Text = ex.ToString();
                resultLabel.Text = "File Read Error!";
                return;
            }
        }

        private void displayButton_Click(object sender, EventArgs e) {
            outTextBox.Text = "";
            resultLabel.Text = "";

            outTextBox.Text = _displaySettings();
        }

        private void openButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Title = "Browse for Config Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "exe.config";
            openFileDialog1.Filter = "Config files (*.exe.config)|*.config|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = false;
            openFileDialog1.ShowReadOnly = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                resultLabel.Text = "Opened file: " + openFileDialog1.FileName;
                _fileName = openFileDialog1.FileName;
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            outTextBox.Text = "";
            resultLabel.Text = "";
            int _newUIN = 0;

            _newUIN = Convert.ToInt32(encObj.DecryptValue(config.AppSettings.Settings["UIN"].Value.ToString())) + 10;
            config.AppSettings.Settings["UIN"].Value = "~" + encObj.EncryptValue(_newUIN.ToString());

            outTextBox.Text = _displaySettings();
            resultLabel.Text = "UIN updated!";
        }

        private void saveButton_Click(object sender, EventArgs e) {
            try {
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                resultLabel.Text = "File Saved: " + _fileName;
            } catch (Exception ex) {
                outTextBox.Text = ex.ToString();
                resultLabel.Text = "File Read Error!";
            }

        }

        private string _displaySettings() {
            string _returnTXT = "";

            foreach (var _sName in config.AppSettings.Settings.AllKeys) {
                string _setName = _sName.ToString();
                _returnTXT += _setName
                    + " = "
                    + encObj.DecryptValue(config.AppSettings.Settings[_setName].Value.ToString())
                    + "\r\n";
            }
            return _returnTXT;
        }
    } */
}
