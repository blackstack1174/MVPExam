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
            MainPresenter = new MainViewPresenter.Presenter.MainViewPresenter(this);
        }


        //************************
        //* IMainView
        //************************
        #region
        public List<IBaseModel> CurrentData { get; set; }
        public IMainViewPresenter MainPresenter { get; set; }
        IBaseModel IMainView.CurrentData { get; set; }

        public void InitializeSubViews() { }

        event EventHandler IMainView.LoadEvent
        {
            add { this.Load += value; }
            remove { this.Load -= value; }
        }


        public void ShowMessage(string message) { MessageBox.Show(message); }
        
        
        public void GridBiddng(IBaseModel baseModel)
        {
            baseModel.
            this.dataGridView1.DataSource = baseModel;
        }

        #endregion
    }
}
