using MyPasswords.Business.Abstract;
using MyPasswords.Business.Concrete;
using MyPasswords.Business.DependencyResolvers.Ninject;
using MyPasswords.DAL.Concrete.EntityFramework;
using MyPasswords.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPasswords.WebFormsUI
{
    public partial class MyPasswords : Form
    {
        public MyPasswords()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _emailService = InstanceFactory.GetInstance<IEmailService>();
            _siteService = InstanceFactory.GetInstance<ISiteService>();
        }
        private IUserService _userService;
        private User _user;
        private IEmailService _emailService;
        private ISiteService _siteService;

        private void MyPasswords_Load(object sender, EventArgs e)
        {
            gbxEmails.Hide();
            gbxSites.Hide();
            dgwMyPasswords.Hide();
            btnLogout.Hide();
        }


        /*****************
            Loading
         *****************/
        private void LoadEmails()
        {
            cbxEmails.DataSource = _emailService.GetEmailsByUserId(_user.UserId);
            cbxEmails.DisplayMember = "EmailName";
            cbxEmails.ValueMember = "EmailId";
        }
        private void LoadPasswordsToDataGridView()
        {
            if (GetCurrentEmail() == null)
                dgwMyPasswords.DataSource = _siteService.GetAll();
            else
                dgwMyPasswords.DataSource = _siteService.GetSitesByEmailId(GetCurrentEmail().EmailId);
        }


        /*****************
           Getting Entity
         *****************/
        private User GetCurrentUser()
        {
            return _userService.GetUserById(_user.UserId);
        }
        private Email GetCurrentEmail()
        {
            return _emailService.GetEmailByEmailName(cbxEmails.Text);
        }


        /*****************
            Controlling
         *****************/
        private bool isUserExist()
        {
            foreach (var user in _userService.GetAll())
            {
                if (user.UserName.ToLower().Equals(tbxUserName.Text.ToLower()))
                    return true;
            }
            return false;
        }
        private bool isLogInSuccess()
        {
            foreach (var user in _userService.GetAll())
            {
                if (user.UserName.Equals(tbxUserName.Text) && user.UserPassword.Equals(tbxPassword.Text))
                {
                    _user = new User();
                    _user.UserId = user.UserId;
                    return true;
                }
            }
            return false;
        }


        /*********************
                Buttons
         *********************/
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!isUserExist())
            {
                _userService.Add(new User
                {
                    UserName = tbxUserName.Text,
                    UserPassword = tbxPassword.Text
                });
                MessageBox.Show("Kayıt eklendi !");
            }
            else
                MessageBox.Show("Bu kullanici adi daha once alinmistir !");
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (isLogInSuccess())
            {
                gbxLogIn.Hide();
                gbxEmails.Show();
                gbxSites.Show();
                btnLogout.Show();
                dgwMyPasswords.Show();
                LoadEmails();
                LoadPasswordsToDataGridView();
            }
            else
                MessageBox.Show("Bilgilerinizi kontrol ediniz !");
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            gbxEmails.Hide();
            dgwMyPasswords.Hide();
            gbxSites.Hide();
            gbxLogIn.Show();
            tbxUserName.Clear();
            tbxPassword.Clear();
            cbxEmails.Refresh();
        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            Email email = new Email
            {
                UserId = _user.UserId,
                EmailName = tbxEditEmail.Text
            };
            ControllingException(() => _emailService.Add(email));
            LoadEmails();
        }
        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
            Email email = _emailService.GetEmailByEmailName(tbxEditEmail.Text);
            ControllingException(() => _emailService.Delete(email));
        }

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            Site site = new Site
            {
                EmailId = GetCurrentEmail().EmailId,
                SiteName = tbxSiteName.Text,
                SiteUserName = tbxSiteUserName.Text,
                SitePassword = tbxSitePassword.Text
            };
            ControllingException(() => _siteService.Add(site));
        }
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            Site site = new Site
            {
                SiteId = Convert.ToInt32(dgwMyPasswords.CurrentRow.Cells[0].Value),
                EmailId = GetCurrentEmail().EmailId,
                SiteName = tbxSiteName.Text,
                SiteUserName = tbxSiteUserName.Text,
                SitePassword = tbxSitePassword.Text
            };
            ControllingException(() => _siteService.Update(site));
        }
        private void btnDeletePassword_Click(object sender, EventArgs e)
        {
            Site site = new Site
            {
                SiteId = Convert.ToInt32(dgwMyPasswords.CurrentRow.Cells[0].Value),
                EmailId = GetCurrentEmail().EmailId,
                SiteName = tbxSiteName.Text,
                SiteUserName = tbxSiteUserName.Text,
                SitePassword = tbxSitePassword.Text
            };
            ControllingException(() => _siteService.Delete(site));
        }


        /*********************
            Forms Changed
         *********************/
        private void cbxEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEmails.Text = cbxEmails.Text;
            LoadPasswordsToDataGridView();
        }
        private void dgwMyPasswords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwMyPasswords.CurrentRow;
            tbxSiteName.Text = row.Cells[2].Value.ToString();
            tbxSiteUserName.Text = row.Cells[3].Value.ToString();
            tbxSitePassword.Text = row.Cells[4].Value.ToString();
        }
        /************************
            Exception Management
         ************************/
        private void ControllingException(Action action)
        {
            try
            {
                action.Invoke();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
