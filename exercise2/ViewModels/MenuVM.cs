using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace exercise2.ViewModels
{
    public class MenuVM
    {
        [Range(1, int.MaxValue, ErrorMessage = "Число должно быть положительным")]
        [Display(Name = "Частота обновления:")]
        public int FrequencyRefreshInMinutes { get; set; }
        [Url(ErrorMessage = "Введите действительную ссылку")]
        [Display(Name="Rss-ленты:")]
        public IEnumerable<SelectListItem> Urls { get; set; }

    }
}
