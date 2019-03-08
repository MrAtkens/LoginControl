using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EarthQueakeWpf
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var uri = new Uri("default.xaml", UriKind.Relative);

			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

			Application.Current.Resources.Clear();

			Application.Current.Resources.MergedDictionaries.Add(resourceDict);
		}
 

		private void WindowMover(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void ExitButtonClick(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}

		private void MinimazeClick(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void Swap(object sender, RoutedEventArgs e)
		{

		}

		private void ButtonSwitchClick(object sender, RoutedEventArgs e)
		{
			string buffer = buttonSwitcher.Content.ToString();
			
			string style = buffer.Split(' ').Last();

			var uri = new Uri(style + ".xaml", UriKind.Relative);

			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

			Application.Current.Resources.Clear();

			Application.Current.Resources.MergedDictionaries.Add(resourceDict);
		}

		private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
