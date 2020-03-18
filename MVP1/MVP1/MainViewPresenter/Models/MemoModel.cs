using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP1.MainViewPresenter.Models
{
    public class MemoModel : IBaseModel
    {

        /// <summary>
        /// 제목을 지정/반환합니다.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 내용을 지정/반환합니다.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 생성자
        /// </summary>
        public MemoModel(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public bool Save()
        {
            return true;
        }
    }
}
