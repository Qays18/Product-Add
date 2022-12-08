namespace Product;

public partial class MainPage : ContentPage
{
	public List<Product> Computer = new List<Product>();
	public List<Product> Mouse = new List<Product>();
	public List<Product> Purch = new List<Product>();
	double I1_Price = -1;
	string I1_Name;

	double I2_Price = -1;
	string I2_Name;


	public MainPage()
	{
		InitializeComponent();
		Computer.Add(new Product("comp1.jpg", "Hp", 1200));
		Computer.Add(new Product("comp2.jpg", "Lenovo", 2000));
		Computer.Add(new Product("comp3.jpg", "Accer", 1800));
		Computer_List_View.ItemsSource = Computer;

		Mouse.Add(new Product("mouse1.jpg", "LG", 1200));
		Mouse.Add(new Product("mouse2.jpg", "Tekno", 2000));
		Mouse.Add(new Product("mouse3.jpg", "Monester ", 1800));
		Mouse_List_View.ItemsSource = Mouse;



	}

	private void Computer_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var SelItem = e.Item as Product;
		I1_Name = SelItem.Name;
		I1_Price = SelItem.Price;


	}

	private void Btn1_Clicked(object sender, EventArgs e)

	

		{
			if (I1_Price == -1)
			{

			}

			if (I2_Price == -2)
			{

			}

			else
			{
			    double total = I1_Price + I2_Price;
				Purch.Clear();
				Purch.Add(new Product("", I1_Name, I1_Price));
				Purch.Add(new Product("", I2_Name, I2_Price));
			    
			    

				Purch_List_View.ItemsSource = null;
				Purch_List_View.ItemsSource = Purch;
			    text_bx1.Text = total.ToString();
			}
		}

		private void Mouse_List_View_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var SelItem = e.Item as Product;
			I2_Name = SelItem.Name;
			I2_Price = SelItem.Price;
		}
	}

