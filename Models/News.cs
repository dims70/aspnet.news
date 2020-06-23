using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class News
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Содержание")]
        public string Text { get; set; }
        [DisplayName("Дата публикации")]
        public DateTime DatePublish { get; set; }

        public override bool Equals(object obj)
        {
            bool res;
            var news = obj as News;
            if (news != null)
            {
                res = Id == news.Id;
                res = Name == news.Name;
                res = Text == news.Text;
                res = DatePublish == news.DatePublish;
                return res;
            }
            return false;
        }
        public override int GetHashCode()
        {
            var hash = Id.GetHashCode();
            hash ^= Name.GetHashCode();
            hash ^= Text.GetHashCode();
            hash ^= DatePublish.GetHashCode();
            return hash;
        }
    }
}