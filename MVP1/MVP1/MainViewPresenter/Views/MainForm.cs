using MVP1.MainViewPresenter.Models;
using MVP1.MainViewPresenter.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP1
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //************************
        //* IMainView
        //************************
        #region
        public IBaseModel CurrentData { get; set; }
        public IMainViewPresenter MainPresenter { get; set; }

        public void InitializeSubViews()
        {
            
        }
        #endregion
    }
}
