using System;
using System.Collections.Generic;
using System.Linq;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using ReactiveUI;
using Suhareva_UP.Models;

namespace Suhareva_UP.ViewModels
{
	public class ChangePartnerViewModel : ReactiveObject
	{
        public string message;
        public List<Partnerstype> ptList => MainWindowViewModel.connection.Partnerstypes.ToList();

        Partner? curPartner;
        public Partner? CurPartner { get => curPartner; set => this.RaiseAndSetIfChanged(ref curPartner, value); }

		public ChangePartnerViewModel()
		{
            CurPartner = new Partner() { Partnerstype = new Partnerstype() };
        }

        public ChangePartnerViewModel(int id)
        {
            CurPartner = MainWindowViewModel.connection.Partners.FirstOrDefault(x => x.Partnersid == id);
        }

        public void BackButton()
        {
            MainWindowViewModel.Instance.Uc = new MenuPage();
        }

        public async void SaveChanges()
        {
            if (CurPartner.Inn.Length>10)
            {
                message = "ИНН не может быть длиннее 10";
            }
            else if (CurPartner.Rating > 10)
            {
                message = "Рейтинг не может быть больше 10";
            }
            else if (CurPartner.Rating < 0)
            {
                message = "Рейтинг не может быть меньше 0";
            }
            else
            {
                ButtonResult buttonResult;
                buttonResult = await MessageBoxManager.GetMessageBoxStandard("Сохранение", "Вы хотите сохранить изменения?", ButtonEnum.YesNo).ShowAsync();
                switch (buttonResult)
                {
                    case ButtonResult.Yes:
                        if (CurPartner.Partnersid == 0)
                        {
                            MainWindowViewModel.connection.Add(CurPartner);
                        }
                        MainWindowViewModel.connection.SaveChanges();
                        MainWindowViewModel.Instance.Uc = new MenuPage();
                        break;
                    case ButtonResult.No:
                        break;
                }
            }
            
        }
       
    }
}