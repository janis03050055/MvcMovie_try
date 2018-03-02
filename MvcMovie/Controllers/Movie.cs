using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; //限制日期格式

namespace MvcMovie.Models
{
    public class Movie
    {
        //ID 是建置資料庫的重要欄位
        [Required]
        [Key]
        public int ID { get; set; }
        [DisplayName("標題")]
        public string Title { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}