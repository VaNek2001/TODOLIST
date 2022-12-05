using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System;

namespace ToDoList;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainViewModel() { };
    }
}

//public partial class MainPage : ContentPage
//{
//    public class Note
//    {
//        public string IdBtn { get; set; }
//        public string NoteText { get; set; }
//        public string IsChecked { get; set; } = "";
//    }

//    public ObservableCollection<Note> notes = new ObservableCollection<Note>();


//    public MainPage()
//    {
//        InitializeComponent();
//        NoteListView.ItemsSource = notes;
//    }

//    public int CountDelBtn = 0;

//    private void AddOnClicked(object sender, EventArgs e)
//    {
//        if (EntryNote.Text != null)
//        {
//            if (!Regex.Match(EntryNote.Text, @"^\s*$").Success)
//            {
//                var ID = CountDelBtn.ToString();
//                notes.Add(new Note() { IdBtn = ID, NoteText = EntryNote.Text });
//                CountDelBtn++;
//                NoteListView.BeginRefresh();
//                EntryNote.Text = "";
//                NoteListView.EndRefresh();
//            }
//        }
//    }

//    private void DelOnClicked(object sender, EventArgs e)
//    {
//        var btn = sender as Button;
//        int index;
//        Int32.TryParse(btn.AutomationId, out index);
//        foreach (var note in notes)
//        {
//            if (note.IdBtn == index.ToString())
//            {
//                notes.Remove(note);
//                break;
//            }
//        }
//        NoteListView.BeginRefresh();
//        NoteListView.EndRefresh();
//    }

//private async void OnAboutNote(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
//{
//    Note note = NoteListView.SelectedItem as Note;

//    await Navigation.PushAsync(new AboutNotePage.AboutNote(note.NoteText));
//}
//}

//<StackLayout>

//     <Label Text = "{Binding Count}" ></ Label >
//         < Button Command="{Binding  CountCommand}"
//                 Text="++"></Button>
//         <Button Command = "{Binding  ValueCommand}"
//                 CommandParameter="5"
//                 Text="+5"></Button>
//         <Button Command = "{Binding DecountCommand}"
//                 Text="--"></Button>
// </StackLayout>

//<StackLayout
//            Spacing = "25"
//            Padding="30">

//        <HorizontalStackLayout
//                Spacing = "20"
//                Padding="20"
//                HorizontalOptions="CenterAndExpand"
//                VerticalOptions="Fill">

//                    <Entry
//                        x:Name="EntryNote"
//                        Placeholder="Введите задачу"
//                        FontFamily="Helvetica"
//                        FontSize="Default"
//                        VerticalOptions="Center"
//                        WidthRequest="250"
//                        ClearButtonVisibility="WhileEditing"/>

//                    <Button
//                         Text = "+"
//                         TextColor="#4B2DCB"
//                         FontSize="Large"
//                         WidthRequest="50"
//                         BackgroundColor="AliceBlue"
//                         BorderWidth="3"
//                         BorderColor="#4B2DCB"
//                         HorizontalOptions="Center"
//                         Clicked="AddOnClicked"
//                         CornerRadius="25"/>

//        </HorizontalStackLayout>

//<ListView
//         ItemSelected = "OnAboutNote"
//         x:Name="NoteListView">
//    <ListView.ItemTemplate>
//        <DataTemplate>
//            <ViewCell>
//                <FlexLayout
//                    JustifyContent = "SpaceBetween" >

//                    < HorizontalStackLayout >

//                    < CheckBox
//                        x:Name="checkBox"
//                        VerticalOptions="Center"/>

//                    <Label
//                        VerticalTextAlignment = "Center"
//                        Text="{Binding NoteText}"
//                        InputTransparent="True"
//                        MaximumWidthRequest="280"
//                        LineBreakMode="TailTruncation">
//                        <Label.Triggers>
//                            <DataTrigger
//                                Binding = "{Binding Source={x:Reference checkBox}, Path=IsChecked}"
//                                Value="true"
//                                TargetType="Label">
//                                <Setter
//                                    Property = "TextDecorations"
//                                    Value="Strikethrough"/>
//                            </DataTrigger>
//                        </Label.Triggers>
//                    </Label>

//                </HorizontalStackLayout>

//                    <Button
//                        AutomationId = "{Binding IdBtn}"
//                        Clicked="DelOnClicked"
//                        Text="X"
//                        Scale="0.8"/>

//                </FlexLayout>
//            </ViewCell>
//        </DataTemplate>

//    </ListView.ItemTemplate>

//</ListView>

//        </StackLayout>