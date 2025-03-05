using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;
using Suhareva_UP.Models;

namespace Suhareva_UP.ViewModels
{
	public class MenuPageViewModel : ReactiveObject
	{
		List<Partner> partners;
		public List<Partner> Partners { get => partners; set => this.RaiseAndSetIfChanged(ref partners, value); }

        public MenuPageViewModel()
		{
			Partners = MainWindowViewModel.connection.Partners.Include(x => x.Partnerstype).Include(x=>x.Partnersproducts).ToList();
        }

		public void ToChangePage()
		{
			MainWindowViewModel.Instance.Uc = new ChangePartner();
		}

        public void ToChangePageEdit(int id)
        {
            MainWindowViewModel.Instance.Uc = new ChangePartner(id);
        }

        public void ToHistoryPage(int id)
        {
            MainWindowViewModel.Instance.Uc = new RealizationHistory(id);
        }

    }
}