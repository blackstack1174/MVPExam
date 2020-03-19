using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP1.MainViewPresenter.Models
{
    public class ResultModel : IBaseModel
    {

        #region IBaseModel

        public bool Save()
        {
            return true;
        }

        #endregion IBaseModel
        public IList<MemoModel> UserList { get; set; }

        public int TotalCount
        {
            get
            {
                if (this.UserList == null)
                    return 0;

                return this.UserList.Count;
            }
        }


    }
}
