using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UIHintPlusSample.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// Account
        /// </summary>
        [UIHint("PlaceHolder", "MVC", "PlaceHolderText", "帳號")]
        public string Account { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        [UIHint("PlaceHolder", "MVC", "PlaceHolderText", "密碼")]
        public string Password { get; set; }
    }
}
