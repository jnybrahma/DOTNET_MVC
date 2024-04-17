using Microsoft.AspNetCore.Mvc;
using UseCases;
using UseCases.TransactionsUseCases;

namespace WebApp1.ViewComponents
{
    [ViewComponent]
    public class TransactionsViewComponent : ViewComponent
    {
        private readonly IGetTodayTransactionsUseCase getTodayTransactionsUseCase;

        public TransactionsViewComponent(IGetTodayTransactionsUseCase getTodayTransactionsUseCase)
        {
            this.getTodayTransactionsUseCase = getTodayTransactionsUseCase;
        }

        public IViewComponentResult Invoke(string userName)
        {

          var transactions = getTodayTransactionsUseCase.Execute(userName);

            //return $"List of Transactions: { userName }";
            return View(transactions);        
        }
    }
}
