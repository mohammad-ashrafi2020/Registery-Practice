using Microsoft.Win32;
using System.Windows.Forms;

namespace Project1
{
    public partial class form1 : Form
    {
        private const string _parentKet = "Software";
        private const string _keyPrefix = "_custom";
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var keys = Registry.CurrentUser
                .OpenSubKey(_parentKet, true)
                .GetSubKeyNames().Where(r => r.EndsWith("_custom"));
            foreach (var key in keys)
            {
                cb_keys.Items.Add(key.Replace(_keyPrefix, ""));
            }
            if (cb_keys.Items.Count > 0)
                cb_keys.SelectedIndex = 0;

            UpdateKeyCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = txtbox_key_name.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("مقدار مورد نظر را وارد کنید");
                return;
            }
            if (cb_keys.Items.Contains(value))
            {
                MessageBox.Show("این کلید قبلا ساخته شده است");
                return;
            }
            Registry.CurrentUser
                .OpenSubKey(_parentKet, true)
                .CreateSubKey(value + _keyPrefix);

            cb_keys.Items.Add(value);
            cb_keys.SelectedItem = value;
            MessageBox.Show($"کلید با موفقیت ساخته شد");
            txtbox_key_name.Text = "";
            UpdateKeyCount();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_key_Click(object sender, EventArgs e)
        {
            var selectedItem = cb_keys.SelectedItem.ToString();
            if (selectedItem == null)
            {
                MessageBox.Show("برای حذف باید یک مورد را انتخاب کنید");
                return;
            }

            try
            {
                Registry.CurrentUser.OpenSubKey(_parentKet, true)
                    .DeleteSubKey(selectedItem + _keyPrefix, true);
                cb_keys.Items.Remove(selectedItem);
                MessageBox.Show("کلید با موفیت حذف شد");
                if (cb_keys.Items.Count > 0)
                    cb_keys.SelectedItem = 0;
            }
            catch
            {
                MessageBox.Show("کلید مورد نظر یافت نشد");
            }
            UpdateKeyCount();
        }

        private void cb_keys_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_values.Items.Clear();
            lbl_value.Text = "";
            var selectedItem = cb_keys.SelectedItem.ToString();
            if (selectedItem != null)
            {
                var values = Registry.CurrentUser.OpenSubKey(_parentKet)
                    .OpenSubKey(selectedItem + _keyPrefix, true)
                    .GetValueNames();
                cb_values.Items.AddRange(values);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void UpdateKeyCount()
        {
            lbl_keyCount.Text = $" {cb_keys.Items.Count} | ";
        }

        private void btn_value_create_Click(object sender, EventArgs e)
        {
            var selectedKey = cb_keys.SelectedItem.ToString();
            if (selectedKey == null)
            {
                MessageBox.Show("از لیست بالا یک کلید را انتخاب کنید");
                return;
            }

            var label = txt_key_valueName.Text;
            var value = txt_key_value.Text;
            if (string.IsNullOrWhiteSpace(label)
                || string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("مقادیر را به درستی وارد کنید");
                return;
            }
            Registry.CurrentUser.OpenSubKey(_parentKet)
                .OpenSubKey(selectedKey + _keyPrefix, true)
                .SetValue(label, value);

            MessageBox.Show("عملیات با موفقیت انجام شد");
            txt_key_valueName.Text = "";
            txt_key_value.Text = "";
            cb_values.Items.Add(label);
        }

        private void cb_values_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedKey = cb_keys.SelectedItem.ToString();
            if (selectedKey == null)
            {
                MessageBox.Show("از لیست بالا یک کلید را انتخاب کنید");
                return;
            }
            var selectedValue = cb_values.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(selectedValue))
            {
                MessageBox.Show("از لیست بالا یک مقدار را انتخاب کنید");
                return;
            }
            var res = Registry.CurrentUser.OpenSubKey(_parentKet)
                 .OpenSubKey(selectedKey + _keyPrefix, true)
                 .GetValue(selectedValue, "null");
            lbl_value.Text = res.ToString();
        }

        private void btn_delete_value_Click(object sender, EventArgs e)
        {
            var selectedKey = cb_keys.SelectedItem.ToString();
            var selectedValue = cb_values.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(selectedValue))
            {
                MessageBox.Show("از لیست بالا یک مقدار را انتخاب کنید");
                return;
            }
            try
            {
                Registry.CurrentUser.OpenSubKey(_parentKet, true)
                    .OpenSubKey(selectedKey + _keyPrefix, true)
                    .DeleteValue(selectedValue, true);

                cb_values.Items.Remove(selectedValue);
                MessageBox.Show("مقدار با موفیت حذف شد");
                lbl_value.Text = "| ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("مقدار مورد نظر یافت نشد");
            }
        }
    }
}