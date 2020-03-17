using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP1.MainViewPresenter.Presenter.Interface
{
    public interface IMainViewPresenter
    {
        /// <summary>
        /// 현재 컨트롤러와 연결된 폼(Form)을 지정/반환합니다.
        /// </summary>
        IMainView CurrentForm { get; set; }
    }
}
