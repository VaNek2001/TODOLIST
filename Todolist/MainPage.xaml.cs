using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System;

namespace ToDoList;

public partial class MainPage : ContentPage
{
    public class Note
    {
        public string IdBtn { get; set; }
        public string NoteText { get; set; }
        public string IsChecked { get; set; } = "";
    }

    public ObservableCollection<Note> notes = new ObservableCollection<Note>();


    public MainPage()
    {
        InitializeComponent();
        NoteListView.ItemsSource = notes;
    }

    public int CountDelBtn = 0  ;

    private void AddOnClicked(object sender, EventArgs e)
    {
        if (EntryNote.Text != null)
        {
            if (!Regex.Match(EntryNote.Text, @"^\s*$").Success)
            {
                var ID = CountDelBtn.ToString();
                notes.Add(new Note() { IdBtn = ID, NoteText = EntryNote.Text });
                CountDelBtn++;
                NoteListView.BeginRefresh();
                EntryNote.Text = "";
                NoteListView.EndRefresh();
            }
        }
    }

    private void DelOnClicked(object sender, EventArgs e)
    {
        var btn = sender as Button;
        int index;
        Int32.TryParse(btn.AutomationId, out index);
        foreach (var note in notes)
        {
            if (note.IdBtn == index.ToString())
            {
                notes.Remove(note);
                break;
            }
        }
        NoteListView.BeginRefresh();
        NoteListView.EndRefresh();
    }

    private async void OnAboutNote(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Note note = NoteListView.SelectedItem as Note;

        await Navigation.PushAsync(new AboutNotePage.AboutNote(note.NoteText));
    }
}


