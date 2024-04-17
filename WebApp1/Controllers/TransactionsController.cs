using Microsoft.AspNetCore.Mvc;
using CoreBusiness;
using UseCases;
using WebApp1.ViewModels;
using UseCases.TransactionsUseCases;
using Microsoft.AspNetCore.Authorization;

namespace WebApp1.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {

        private readonly ISearchTransactionsUseCase searchTransactionsUseCase;

        public TransactionsController(ISearchTransactionsUseCase searchTransactionsUseCase)
        {
            this.searchTransactionsUseCase = searchTransactionsUseCase;
        }

        public IActionResult Index()
        {
            TransactionsViewModel transactionsViewModel = new TransactionsViewModel();
            return View(transactionsViewModel);
        }

        public IActionResult Search(TransactionsViewModel transactionsViewModel)
        {
            var transactions = searchTransactionsUseCase.Execute(
                transactionsViewModel.CashierName ?? string.Empty,
                transactionsViewModel.StartDate,
                transactionsViewModel.EndDate);

            transactionsViewModel.Transactions = transactions;

            return View("Index", transactionsViewModel);
        }
    }
}
