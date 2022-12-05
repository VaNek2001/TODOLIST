using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using System;

namespace ToDoList;

public class Item
{
    public string Title;
    public string Color;
}

public class MainViewModel : BindableObject
{
    private string _color;
    public string color { get => _color;
        set {
            _color = value;
            OnPropertyChanged(nameof(color));
        }
    }

    public MainViewModel()
    {
        AddItemCommand = new Command<string>(x =>
        {
            var item = new ToDoItem(x, color);
            ToDoItems.Add(item);
        }
        ,x => string.IsNullOrWhiteSpace(x) == false);

        DeleteItemCommand = new Command<ToDoItem>(x => ToDoItems.Remove(x));
        
    }
    public ICommand AddItemCommand { get; }
    public ICommand DeleteItemCommand { get; }

    public ObservableCollection<ToDoItem> ToDoItems { get; } = new ObservableCollection<ToDoItem>();
}

public class ToDoItem : BindableObject
{
    public ToDoItem(string title, string color)
    {
        _title = title;
        _color = Color.Parse(color);
    }


    private Color _color;
    public Color Color
    {
        get => _color;
        set
        {
            if (_color == value) return;
            _color = value;
            OnPropertyChanged(nameof(Color));
        }
    }
    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            if (_title == value) return;
            _title = value;
            OnPropertyChanged(nameof(Title));
        }
    }

    private string _text;
    public string Text
    {
        get => _text;
        set
        {
            if (_text == value) return;
            _text = value;
            OnPropertyChanged(nameof(Text));
        }
    }


    public override string ToString()
    {
        return Title;
    }
}

//private string _test;
//private int _count;

//public string Test { get { return _test; } set { if (_test == value) return; _test = value; OnPropertyChanged(nameof(Test)); } }
//public int Count { get { return _count; } set { if (_count == value) return; _count = value; OnPropertyChanged(nameof(Count)); } }

//public ICommand CountCommand { get; }
//public ICommand ValueCommand { get; }
//public ICommand DecountCommand { get; }

//public MainViewModel()
//{
//    CountCommand = new Command(() => Count++);
//    ValueCommand = new Command<string>(x => { Debug.WriteLine(x); Debug.WriteLine(x.GetType()); Count = Count + int.Parse(x); });
//    DecountCommand = new Command(() => Count--, () => Count > 0);
//}




//    {
//        AddItemCommand = new Command<Item>(x =>
//        {
//            Item item1 = x as Item;
//            if(item1 != null)
//            {
//                Console.WriteLine(item1.Title + " " + item1.Color);
//                var item = new ToDoItem(item1.Title, item1.Color);
//ToDoItems.Add(item);
//            }
//        },x =>
//          {
//              Item item = x as Item;
//              if (item != null)
//                  return string.IsNullOrWhiteSpace(item.Title) == false;
//              return false;
//          });



//public MainViewModel()
//{
//    AddItemCommand = new Command<string>(title =>
//    {
//        var item = new ToDoItem(title);
//        ToDoItems.Add(item);
//    }, title => string.IsNullOrWhiteSpace(title) == false);
//}

//public ICommand AddItemCommand { get; }

//public ObservableCollection<ToDoItem> ToDoItems { get; } = new ObservableCollection<ToDoItem>();

//public class ToDoItem : BindableObject
//{
//    public ToDoItem(string title)
//    {
//        _title = title;
//    }

//    private bool _done;
//    public bool Done
//    {
//        get => _done;
//        set
//        {
//            if (_done == value) return;
//            _done = value;
//            OnPropertyChanged(nameof(Done));
//        }
//    }

//    private string _title;
//    public string Title
//    {
//        get => _title;
//        set
//        {
//            if (_title == value) return;
//            _title = value;
//            OnPropertyChanged(nameof(Title));
//        }
//    }

//    public override string ToString()
//    {
//        return Title;
//    }
//}
