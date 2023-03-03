using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;


namespace PDC03_MODULE02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity05 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();
		public ObservableCollection<employee> Employees { get { return employees; } }
		public Activity05 ()
		{
			InitializeComponent ();

			{
				lst.ItemsSource = employees;

				employees.Add(new employee { DisplayName = "Cohen", Position = "President", profileimage = "download2.jpg" });
				employees.Add(new employee { DisplayName = "Musky", Position = "Vice President", profileimage = "download1.jpg" });
				employees.Add(new employee { DisplayName = "Wendy", Position = "Secretary", profileimage = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmydramalist.com%2Fpeople%2F11861-wendy&psig=AOvVaw2duyWtxB5BrYfp5milL0dZ&ust=1677894704668000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCKj-7oLTvv0CFQAAAAAdAAAAABAD" });
			}
		}
	}
}