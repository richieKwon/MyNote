using System.Collections.Generic;
using MyNote.Model;

namespace MyNote.IDAL
{
    public interface INoticeDal
    {
        List<Notice> GetNoticeList();

        Notice GetNotice(int noticeNo);

        bool PostNotice(Notice notice);

        bool UpdateNotice(Notice notice);

        bool DeleteNotice(int noticeNo);
    }
} 