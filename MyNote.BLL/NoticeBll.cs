using System;
using System.Collections.Generic;
using MyNote.IDAL;
using MyNote.Model;

namespace MyNote.BLL
{
    public class NoticeBll
    {
        private readonly INoticeDal _noticeDal;

        public NoticeBll(INoticeDal noticeDal)
        {
            _noticeDal = noticeDal;
        }

        public List<Notice> GetNoticeList()
        {
            return _noticeDal.GetNoticeList();
        }

        public Notice GetNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();
            return _noticeDal.GetNotice(noticeNo);
        }

        public bool PostNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentException();
            return _noticeDal.PostNotice(notice);
        }

        public bool UpdateNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentException();
            return _noticeDal.UpdateNotice(notice);
        }

        public bool DeleteNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();
            return _noticeDal.DeleteNotice(noticeNo);
        }
    }
}