using MVP1.MainViewPresenter.Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CurrentForm.ShowMessage("테스트");
        }

    }
}
