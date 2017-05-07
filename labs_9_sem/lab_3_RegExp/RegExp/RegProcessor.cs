using System;
using System.Text.RegularExpressions;
using System.Text;

namespace RegExp
{
    class RegProcessor
    {
        /// <summary>
        /// выбор из текста подстрок, соответствующих регулярным выражениям
        /// </summary>
        /// <param name="text">исходный текст</param>
        /// <param name="RegExpression">регулярное выражение</param>
        /// <param name="IgnoreCase">без учета регистра</param>
        /// <param name="Replaсe">c заменой</param>
        /// <returns>Текст, содержащий подстроки, разделенные символом переноса строки</returns>
        public String Filter(String text, String RegExpression, Boolean IgnoreCase = false, String Replaсe = "", int special = 0)
        {
            if (text == null || text.Length == 0)
                return "";
            Regex reg;
            try
            {
                //пихаем регулярку
                if (IgnoreCase)
                    reg = new Regex(RegExpression, RegexOptions.IgnorePatternWhitespace| RegexOptions.IgnoreCase);
                else
                    reg = new Regex(RegExpression, RegexOptions.IgnorePatternWhitespace);

                if (Replaсe != "")
                    return reg.Replace(text, Replaсe);
                
                return ProcessRegExp(text, reg);
            }
            catch (Exception)
            { return "некорректное выражение"; }
        }


        /// <summary>
        /// Выбор из текста подстрок, соответствующих регулярному выражению
        /// </summary>
        /// <param name="text">исходный текст</param>
        /// <param name="reg">регулярное выражение</param>
        /// <returns>текст, содержащий подстроки, разделенные символом переноса строки</returns>
        String ProcessRegExp(String text, Regex reg)
        {
            MatchCollection mc = reg.Matches(text);
            if (mc.Count == 0)
                return "ничего не найдено";
            StringBuilder sb = new StringBuilder();
            foreach (Match item in mc)
                 sb.AppendLine(item.ToString());
            return sb.ToString();
            
        }

        /// <summary>
        /// выбирает HTML-ссылки, соответствующие регулярному выражению и предоставляя дополнительное описание
        /// </summary>
        /// <param name="text">текст</param>
        /// <param name="reg">регулярное выражение</param>
        /// <returns>текст, содержащий подстроки HTML-ссылок и подстроки с их описанием</returns>
        public String ProcessHref(String text)
        {
            if (text == null || text.Length == 0)
                return "";
            Regex reg;
            reg = new Regex(@"<a (href=\"".+?\""|href='.+?')( title=\"".+?\""|title='.+?')?>(.)*?(<\/a>)", RegexOptions.IgnoreCase);
            String temp = text;
            MatchCollection mc = reg.Matches(temp);
            if (mc.Count == 0) return "ничего не найдено";
            StringBuilder sb = new StringBuilder();
            foreach (Match item in mc)
            {
                var str = item.ToString();
                sb.AppendLine(str);
                sb.AppendLine("      Адрес: " + reg.Replace(str, @"$1"));
                sb.AppendLine("      Свойства: " + reg.Replace(str, @"$2"));
            }
            temp = sb.ToString();
            return temp;
        }
    }
}
