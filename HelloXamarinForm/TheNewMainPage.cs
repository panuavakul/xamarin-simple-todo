using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloXamarinForm
{
	public class TheNewMainPage : ContentPage {
		ObservableCollection<String> toDoList = new ObservableCollection<String>(){
			"Learn Xamarin Form",
			"Design UI",
			"Learn Unity",
			"Learn C#"
		};

		// Constructor Here
		public TheNewMainPage() {
			this.Title = "ToDo List";
			StackLayout stackLayout = new StackLayout();

			//var instructionLabel = new Label();
			//instructionLabel.Text = "Input your task below";
			/// Can make text and set property like this
			var instructionLabel = new Label {
				Text = "Welcome to ToDo List",
				TextColor = Color.Default
			};

			// Create list view to hold to do list
			var listView = new ListView {
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			listView.ItemsSource = toDoList;

			// Create Text Entry to enter to do
			var toDoEntry = new Entry {
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			// Make a horizontal stack to hold the button and To Do entry
			StackLayout toDoEntryHorizontalStack = new StackLayout{
				Orientation = StackOrientation.Horizontal
			};

			// Create button to Add To do
			Button addToDoButton = new Button {
				Text = "Add"
			};

			addToDoButton.Clicked += (sender, ea) => {
				toDoList.Add(toDoEntry.Text);
				toDoEntry.Text = "";
			};

			// Add the Above stuff to horizontal stack
			toDoEntryHorizontalStack.Children.Add(toDoEntry);
			toDoEntryHorizontalStack.Children.Add(addToDoButton);

			// Add everything to Stack View
			stackLayout.Children.Add(instructionLabel);
			stackLayout.Children.Add(toDoEntryHorizontalStack);
			stackLayout.Children.Add(listView);


			// Add the stackLayout to content
			this.Content = stackLayout;
		}
	}
}
