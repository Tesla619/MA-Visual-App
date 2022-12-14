using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mobile_App.Models;
using Xamarin.Forms;

namespace Mobile_App.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var notes = new List<Note>();

            // Create a Note object from each file.
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach (var filename in files)
            {
                notes.Add(new Note
                {
                    Filename = filename,
                    Text = File.ReadAllText(filename),
                    Date = File.GetCreationTime(filename)
                });
            }

            // Set the data source for the CollectionView to a
            // sorted collection of notes.
            collectionView.ItemsSource = notes
                .OrderBy(d => d.Date)
                .ToList();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the AddReportPage Page, without passing any data.
            await Shell.Current.GoToAsync(nameof(AddReportPage));
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the AddReportPage Page, passing the filename as a query parameter.
                Note note = (Note)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(AddReportPage)}?{nameof(AddReportPage.ItemId)}={note.Filename}");
            }
        }
    }
}