﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using Kreta.Desktop.ViewModels.SchoolCitizens;

namespace Kreta.Desktop.ViewModels
{
    partial class  MainWindowViewModel : BaseViewModel
    {
        [ObservableProperty]
        private BaseViewModel _childViewModel;

        [ObservableProperty]
        private string _statusBarText="A program betölödött...";

        public MainWindowViewModel()
        {
            _childViewModel = new WelcomeViewModel();
        }

        [RelayCommand]
        private void ShowStudentView()
        {
            ChildViewModel=new StudentViewModel();
            StatusBarText = "Diák adatok kezelése";
        }

        [RelayCommand]
        private void ShowTeacherView()
        {
            ChildViewModel = new TeacherViewModel();
            StatusBarText = "Tanár adatok kezelése";
        }

        [RelayCommand]
        private void ShowParantView()
        {
            ChildViewModel = new ParentViewModel();
            StatusBarText = "Szülői adatok kezelése";
        }
    }
}
