using CommunityToolkit.Mvvm.ComponentModel;
using SpecialistProjekt.Models;
using StudentProject.Models;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace StudentProject.ViewModels
{
    public partial class SpecialistViewModel : ObservableObject
    {
        [ObservableProperty]
        private Specialist _specialist;

        [ObservableProperty]
        private List<string> _educationLevels = new EducationLevel().AllEducationLevels;

        public SpecialistViewModel()
        {
            _specialist = new Specialist();
        }
    }
}