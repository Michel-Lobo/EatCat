using System.Threading.Tasks;
using System.Windows.Input;

namespace EatCat.Commands
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}
