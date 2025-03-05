using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;
using Suhareva_UP.Models;

namespace Suhareva_UP.ViewModels
{
	public class RealizationHistoryViewModel : ReactiveObject
	{

		List<Partnersproduct> partnerAndProducts;
		public List<Partnersproduct> PartnerAndProducts { get => partnerAndProducts; set => this.RaiseAndSetIfChanged(ref partnerAndProducts, value); }

		public RealizationHistoryViewModel() { }
		public RealizationHistoryViewModel(int id)
		{
			PartnerAndProducts = MainWindowViewModel.connection.Partnersproducts.Include(x=>x.Partners).Include(x=>x.Products).Where(x=>x.Partnersid==id).ToList();
        }

        public void BackButton()
        {
            MainWindowViewModel.Instance.Uc = new MenuPage();
        }
    }
}