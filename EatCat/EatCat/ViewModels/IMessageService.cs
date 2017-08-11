using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EatCat.ViewModels
{
    interface IMessageService
    {
        Task ShowAsync(string Menssage);
    }
}
