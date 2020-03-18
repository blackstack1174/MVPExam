using MVP1.MainViewPresenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP1.MainViewPresenter.Presenter.Interface
{

    public interface IMainView
    {
        /// <summary>
        /// 현재 사용 데이터모델을 지정/반환합니다.
        /// </summary>
        IBaseModel CurrentData { get; set; }


        /// <summary>
        /// 컨트롤러를 지정/반환합니다.
        /// </summary>
        IMainViewPresenter MainPresenter { get; set; }

        void InitializeSubViews();

        void ShowMessage(string message);

        event EventHandler LoadEvent;

        void GridBiddng(IBaseModel baseModels);
    }
}
