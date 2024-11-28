using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LookLikeSpecialist.Models;
using System.Collections.ObjectModel;

namespace LookLikeSpecialist.ViewModels
{
    public partial class SpecialistViewModel : ObservableObject
    {

        [ObservableProperty]
        private Specialist _specialist = new Specialist();



        [ObservableProperty]
        private ObservableCollection<Specialist> _specialists = new ObservableCollection<Specialist>();

        [ObservableProperty]
        private Specialist _selectedSpecialist = new Specialist();

        public SpecialistViewModel()
        {
            Specialist.Szuldatum = DateTime.Now.AddYears(-14);
        }

        [RelayCommand]
        public void DoSave(Specialist specialist)
        {
            Specialists.Add(specialist);
            Specialist = new Specialist();
            Specialist.Szuldatum = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(Specialist));
        }

        [RelayCommand]
        public void DoNewSpecialist()
        {
            Specialist = new Specialist();
            Specialist.Szuldatum = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(Specialist));
        }

        [RelayCommand]
        public void DoDelete(Specialist specialist)
        {
            Specialists.Remove(Specialist);
            Specialist = new Specialist();
            Specialist.Szuldatum = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(Specialist));
        }
    }
}