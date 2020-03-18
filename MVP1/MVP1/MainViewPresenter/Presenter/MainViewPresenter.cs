using MVP1.MainViewPresenter.Models;
using MVP1.MainViewPresenter.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP1.MainViewPresenter.Presenter
{
    public class MainViewPresenter : IMainViewPresenter
    {

        public IMainView CurrentForm { get; set; }

        /// <summary>
        /// 생성자
        /// </summary>
        public MainViewPresenter(IMainView view)
        {
            CurrentForm = view;
            CurrentForm.LoadEvent += CurrentForm_LoadEvent;
        }

        private void CurrentForm_LoadEvent(object sender, EventArgs e)
        {
            var memoModels = new ResultModel()
            {
                UserList = new List<MemoModel>()
                {
                    new MemoModel("크크루크크", "테스트"),
                    new MemoModel("크크루크크", "테스트"),
                    new MemoModel("크크루크크", "테스트")
                }
            };
            CurrentForm.CurrentData = memoModels;
            CurrentForm.GridBiddng(CurrentForm.CurrentData);

        }
    }
}

